using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_IHEC
{
    public partial class Annuler_reservation : UserControl
    {
        public Annuler_reservation()
        {
            InitializeComponent();
        }

        private void btnAnnulerReservation_Click(object sender, EventArgs e)
        {
            string codeRes = txtCodereservation.Text.Trim();//.Trim() enlève les espaces inutiles au début ou à la fin

            if (string.IsNullOrEmpty(codeRes))
            {
                MessageBox.Show("Veuillez saisir un code de réservation.");
                return;
            }

            // --- CONFIRMATION D'ANNULATION ---
            DialogResult dialogResult = MessageBox.Show(
                "Êtes-vous sûr de vouloir annuler cette réservation ?\n\n" +
                "Attention : Si vous annulez, vous ne pourrez pas effectuer une autre réservation pour ce même jour.",
                "Confirmation d'annulation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            // Utilisation d'une transaction pour garantir que les deux mises à jour réussissent ensemble
            using (SqlConnection conn = new SqlConnection(BD.ConnString))
            {
                try
                {
                    conn.Open();
                    //sqlTransaction est utulisée pour garantir l'execution de tous les taches
                    //dans notre cas: modification du statut et l'ajout du qte au menu
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            //Récupérer le menu_id associé à cette réservation
                            string queryGetMenu = "SELECT id_menu FROM Reservations WHERE id_reservation = @code AND statut != 'annulé'";
                            SqlCommand cmdGetMenu = new SqlCommand(queryGetMenu, conn, transaction);
                            cmdGetMenu.Parameters.AddWithValue("@code", codeRes);
                            object result = cmdGetMenu.ExecuteScalar();

                            if (result != null)
                            {
                                int menuId = Convert.ToInt32(result);
                                //Changer le statut de la réservation
                                string queryUpdateRes = "UPDATE Reservations SET statut = 'annulé' WHERE id_reservation = @code";
                                SqlCommand cmdUpdateRes = new SqlCommand(queryUpdateRes, conn, transaction);
                                cmdUpdateRes.Parameters.AddWithValue("@code", codeRes);
                                cmdUpdateRes.ExecuteNonQuery();

                                //Ajouter +1 à la quantité du menu 
                                string queryUpdateMenu = "UPDATE Menus SET quantite_dispo = quantite_dispo + 1 WHERE id_menu = @menuId";
                                SqlCommand cmdUpdateMenu = new SqlCommand(queryUpdateMenu, conn, transaction);
                                cmdUpdateMenu.Parameters.AddWithValue("@menuId", menuId);
                                cmdUpdateMenu.ExecuteNonQuery();

                                //Valider les 2 changement
                                transaction.Commit();
                                MessageBox.Show("Réservation annulée avec succès !");
                                txtCodereservation.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Code de réservation invalide ou déjà annulé.");
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erreur lors de l'annulation : " + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Erreur de connexion
                    MessageBox.Show("Erreur de connexion : " + ex.Message);
                }


            }
        }

       
    }
}


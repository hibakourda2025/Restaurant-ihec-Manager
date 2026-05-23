using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_IHEC
{
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            //Récupération des informations
            string dateReservation = dtpDatereservation.Value.ToShortDateString();
            string menuSelectionne = rbMenu1.Checked ? "Menu 1" : "Menu 2";

            //Message de confirmation initial
            //le symbol $ pour concatiner la date et menu sans "+"
            DialogResult confirmation = MessageBox.Show(
                $"Êtes-vous sûr d'assurer une réservation pour la date {dateReservation} pour le {menuSelectionne} ?",
                "Confirmation de réservation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirmation == DialogResult.No)
            {
                return;
            }
            if (confirmation == DialogResult.Yes)
            {
                VerifierEtReserver(dtpDatereservation.Value, menuSelectionne);
            }
        }
        private void VerifierEtReserver(DateTime date, string menu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    conn.Open();

                    //verifie que l'etudiant peut effectuer qu'un seul reservation par jour
                    string queryDoubleRes = @"SELECT COUNT(*) FROM reservations r 
                                     INNER JOIN Menus m ON r.id_menu = m.id_menu 
                                     WHERE r.cin_etudiant = @cin AND m.date_menu = @date";

                    using (SqlCommand cmdCheckDouble = new SqlCommand(queryDoubleRes, conn))
                    {
                        cmdCheckDouble.Parameters.AddWithValue("@cin", Session.cin);
                        cmdCheckDouble.Parameters.AddWithValue("@date", date.Date);

                        int dejaReserve = (int)cmdCheckDouble.ExecuteScalar();
                        if (dejaReserve > 0)
                        {
                            MessageBox.Show("Vous avez déjà une réservation pour cette date.", "Action impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // On arrête tout si l'étudiant a déjà réservé aujourd'hui
                        }
                    }

                    //Vérifier si le plat existe ET s'il reste des quantités disponibles
                    string queryCheck = "SELECT quantite_dispo FROM Menus WHERE date_menu = @date AND nom_choix = @menu";
                    using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@date", date.Date);
                        cmdCheck.Parameters.AddWithValue("@menu", menu);
                        object result = cmdCheck.ExecuteScalar();

                        // Si Le plat existe et est disponible,On procède à la réservation
                        if (result != null && Convert.ToInt32(result) > 0)
                        {
                            //generer un code et verifie la non existance dans la table reservations
                            Random rnd = new Random();
                            string codeReservation;
                            bool existeDeja;
                            //on repete la boucle tantque le code existe dans la table reservations
                            do
                            {
                                // Génère un code composer de date et un code alèatoire de 4 chiffre
                                codeReservation = date.ToString("yyyyMMdd") + rnd.Next(1000, 10000).ToString();
                                // Vérification en base de données
                                string sql = "SELECT COUNT(*) FROM reservations WHERE id_reservation = @code";
                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@code", codeReservation);
                                    //(int) c'est pour transformer le resultat en entier
                                    int count = (int)cmd.ExecuteScalar();
                                    existeDeja = (count > 0);
                                }
                            } while (existeDeja);

                            // Début d'une transaction pour garantir que les deux opérations (Update + Insert) réussissent ensemble
                            SqlTransaction transaction = conn.BeginTransaction();
                            try
                            {
                                // 1. Récupérer l'id_menu correspondant au choix (Menu 1 ou Menu 2) pour cette date
                                int idMenuTrouve = 0;
                                string queryGetId = "SELECT id_menu FROM Menus WHERE date_menu = @date AND nom_choix = @menu";

                                using (SqlCommand cmdId = new SqlCommand(queryGetId, conn, transaction))
                                {
                                    cmdId.Parameters.AddWithValue("@date", date.Date);
                                    cmdId.Parameters.AddWithValue("@menu", menu);
                                    object idResult = cmdId.ExecuteScalar();
                                    if (idResult != null)
                                    {
                                        idMenuTrouve = Convert.ToInt32(idResult);
                                    }
                                }

                                // Ajouter la réservation dans la table 'reservations'
                                string queryInsert = "INSERT INTO reservations (id_reservation, cin_etudiant, id_menu, date_reservation) VALUES (@code, @cin, @menu, @date)";
                                using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, transaction))
                                {
                                    cmdInsert.Parameters.AddWithValue("@code", codeReservation);
                                    cmdInsert.Parameters.AddWithValue("@date", date.Date);
                                    cmdInsert.Parameters.AddWithValue("@menu", idMenuTrouve);
                                    cmdInsert.Parameters.AddWithValue("@cin", Session.cin);
                                    cmdInsert.ExecuteNonQuery();
                                }

                                // Décrémenter la quantité dans la table 'Menus'
                                string queryUpdate = "UPDATE Menus SET quantite_dispo = quantite_dispo - 1 WHERE id_menu = @idm";
                                using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn, transaction))
                                {
                                    // Utilisation de l'ID trouvé pour être plus précis
                                    cmdUpdate.Parameters.AddWithValue("@idm", idMenuTrouve);
                                    cmdUpdate.ExecuteNonQuery();
                                }

                                // Valider toutes les opérations
                                transaction.Commit();

                                // Envoi du mail après le succès de la transaction
                                EmailService.EnvoyerCodeReservation(codeReservation, date, menu);

                                MessageBox.Show(
                                    "La réservation est effectuée. Votre code a été envoyé par mail",
                                    "Succès",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                //Si une erreur survient durant l'insertion ou l'update, cette commande annule tout pour revenir à l'état initial
                                transaction.Rollback();
                                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
                            }
                        }
                        else
                        {
                            // Pas de plat ou quantité épuisée
                            MessageBox.Show(
                                "Nous n'avons plus de plat disponible pour cette sélection. Essayez de changer le menu ou la date.",
                                "Indisponible",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message);
            }
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            dtpDatereservation.MinDate = DateTime.Today;
        }
    }
}

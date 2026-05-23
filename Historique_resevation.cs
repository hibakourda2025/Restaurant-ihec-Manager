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
    public partial class Historique_resevation : UserControl
    {
        public Historique_resevation()
        {
            InitializeComponent();
        }
        private BindingSource bsReservation = new BindingSource();
        private SqlDataAdapter adapterReservation;
        private DataSet dsReservation = new DataSet();

        private void Historique_resevation_Load(object sender, EventArgs e)
        {
            //charger historique
            using (SqlConnection conn = new SqlConnection(BD.ConnString))
            {
                // Utilisation d'un INNER JOIN pour récupérer le type_repas depuis la table Menus
                // R (alias pour Reservations) et M (alias pour Menus)
                string query = @"SELECT R.id_reservation, 
                                            R.date_reservation, 
                                            M.nom_choix AS Type_repas, 
                                            R.statut 
                     FROM Reservations R
                     INNER JOIN Menus M ON R.id_menu = M.id_menu
                     WHERE R.cin_etudiant = @id 
                     ORDER BY R.date_reservation DESC";

                try
                {
                    adapterReservation = new SqlDataAdapter(query, conn);
                    adapterReservation.SelectCommand.Parameters.AddWithValue("@id", Session.cin);
                    adapterReservation.Fill(dsReservation, "Reservations");
                    bsReservation.DataSource = dsReservation.Tables["Reservations"];
                    dgvHistorique.DataSource = bsReservation;
                    DataTable dt = new DataTable();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement : " + ex.Message);
                }
            }
        }

        private void dgvHistorique_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // On vérifie que nous sommes sur la colonne "statut"
            // Et qu'il y a bien une valeur dans la cellule
            if (dgvHistorique.Columns[e.ColumnIndex].Name == "statut" && e.Value != null)
            {
                string statut = e.Value.ToString().ToLower();

                // Application de la couleur sur TOUTE la ligne (Row)
                if ( statut == "validé")
                {
                    dgvHistorique.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dgvHistorique.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (statut == "en cours")
                {
                    dgvHistorique.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    dgvHistorique.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (statut == "annulé")
                {
                    dgvHistorique.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dgvHistorique.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}

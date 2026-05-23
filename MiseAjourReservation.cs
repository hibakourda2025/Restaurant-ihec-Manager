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
    public partial class MiseAjourReservation : UserControl
    {
        public MiseAjourReservation()
        {
            InitializeComponent();
        }
        private string ConnString =
            @"Data Source=EMNA-PC;Initial Catalog=Restaurant_IHEC;Integrated Security=True";
        private BindingSource bsReservation = new BindingSource();
        private SqlDataAdapter adapterReservation;
        private DataSet dsReservation = new DataSet();
        private void MiseAjourReservation_Load(object sender, EventArgs e)
        {
            // Évite de recharger si les données sont déjà là
            if (dsReservation.Tables["Reservation"] != null) return;

            try
            {
                const string sql = "SELECT * FROM Reservations";
                adapterReservation = new SqlDataAdapter(sql, ConnString);
                adapterReservation.Fill(dsReservation, "Reservations");
                bsReservation.DataSource = dsReservation.Tables["Reservations"];
                dgvReservation.DataSource = bsReservation;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement Reservation : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextCode_TextChanged(object sender, EventArgs e)
        {
            // On récupère le texte sans les caractères du masque (le "prompt")
            string saisie = maskedTextCode.Text.Replace("_", "").Trim();

            if (!string.IsNullOrEmpty(saisie))
            {
                // On filtre sur le BindingSource global
                bsReservation.Filter = string.Format("id_reservation LIKE '{0}%'", saisie);
            }
            else
            {
                bsReservation.RemoveFilter();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bsReservation.EndEdit();
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapterReservation);
                adapterReservation.Update(dsReservation.Tables["Reservations"]);
                MessageBox.Show("La mise à jour a été effectuée avec succès!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur:" + ex.Message);
            }
        }

        private void maskedTextCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("try a number",
               "invalid data type",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }

        
    }
}

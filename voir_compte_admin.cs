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
    public partial class voir_compte_admin : UserControl
    {
        public voir_compte_admin()
        {
            InitializeComponent();
            txtNom.Text = Session.nom;
            txtPrenom.Text = Session.prenom;
            txtCIN.Text = Session.cin;
            txtNum.Text = "216"+Session.numEtudiant;
            txtPoste.Text = Session.poste;
            txtPassword.Text = Session.password;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(BD.ConnString);
            SqlDataAdapter adapter;
            DataTable table;
            string sql = "SELECT * FROM Personnel";
            adapter = new SqlDataAdapter(sql, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            table = new DataTable();
            adapter.Fill(table);

            // 1. Trouver la ligne dans le DataTable (par CIN)
            DataRow row = table.Select("cin = '" + Session.cin + "'")[0];

            // 2. Modifier le DataTable (pas la base directement)
            row["nom"] = txtNom.Text;
            row["prenom"] = txtPrenom.Text;
            row["contact"] = txtNum.Text;
            row["poste"] = txtPoste.Text;

            // 3. Mise à jour Session
            Session.nom = txtNom.Text;
            Session.prenom = txtPrenom.Text;
            Session.numEtudiant = txtNum.Text;
            Session.poste = txtPoste.Text;

            // 4. Synchroniser avec la base
            adapter.Update(table);

            MessageBox.Show("Mise à jour réussie !");
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void labelNometudiant_Click(object sender, EventArgs e)
        {

        }
    }
}

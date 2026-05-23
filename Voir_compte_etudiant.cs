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
    public partial class Voir_compte_etudiant : UserControl
    {
        public Voir_compte_etudiant()
        {
            InitializeComponent();
            txtNom.Text = Session.nom;
            txtPrenom.Text = Session.prenom;
            txtCIN.Text = Session.cin;
            txtEmail.Text = Session.email;
            txtNumEtudiant.Text = Session.numEtudiant;
            txtFiliere.Text = Session.filiere;
            dtpNaissance.Value = Convert.ToDateTime(Session.dateNaissance);
            dtpInscription.Value= Convert.ToDateTime(Session.dateInscription);
            txtPassword.Text = Session.password;
        }

        private void changer_mdp_Click(object sender, EventArgs e)
        {
            Session.modeVerification = "resetPassword";
            Mot_de_passe f = new Mot_de_passe();
            f.Show();
            Hide();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(BD.ConnString);
            SqlDataAdapter adapter;
            DataTable table;
            string sql = "SELECT * FROM etudiant";
            adapter = new SqlDataAdapter(sql, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            table = new DataTable();
            adapter.Fill(table);

            // 1. Trouver la ligne dans le DataTable (par CIN)
            DataRow row = table.Select("cin_etudiant = '" + Session.cin + "'")[0];

            // 2. Modifier le DataTable (pas la base directement)
            row["nom"] = txtNom.Text;
            row["prenom"] = txtPrenom.Text;
            row["telephone"] = txtNumEtudiant.Text;
            row["filiere"] = txtFiliere.Text;

            // 3. Mise à jour Session
            Session.nom = txtNom.Text;
            Session.prenom = txtPrenom.Text;
            Session.numEtudiant = txtNumEtudiant.Text;
            Session.filiere = txtFiliere.Text;

            // 4. Synchroniser avec la base
            adapter.Update(table);

            // changer l'affichage de username dans i'interface
            Session.user_name = row["nom"].ToString() + " " + row["prenom"].ToString();

            MessageBox.Show("Mise à jour réussie !");

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

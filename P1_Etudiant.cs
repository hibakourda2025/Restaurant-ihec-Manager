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
    public partial class P1_Etudiant : Form
    {
        public P1_Etudiant()
        {
            InitializeComponent();
            labelEtudiant.Text = Session.user_name;
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            Classuserform.LoadUserForm(panelMain, new Reservation());
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMoncompte_Click(object sender, EventArgs e)
        {
            Classuserform.LoadUserForm(panelMain, new Voir_compte_etudiant());
        }

        private void btnMenuSemaine_Click(object sender, EventArgs e)
        {
            Classuserform.LoadUserForm(panelMain, new Menu_semaine("Etudiant"));
        }

        private void btnAnnulerreservation_Click(object sender, EventArgs e)
        {
            Classuserform.LoadUserForm(panelMain, new Annuler_reservation());
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            Classuserform.LoadUserForm(panelMain, new Historique_resevation());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Etudiant";
            SqlConnection con = new SqlConnection(BD.ConnString);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment supprimer votre compte ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // 1. Trouver la ligne dans le DataTable
                DataRow[] rows = table.Select("cin_etudiant = '" + Session.cin + "'");

                if (rows.Length > 0)
                {
                    // 2. Supprimer du DataTable
                    rows[0].Delete();

                    // 3. Synchroniser avec la base de données
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(table);

                    // 4. Nettoyer la session
                    Session.nom = null;
                    Session.prenom = null;
                    Session.cin = null;
                    Session.email = null;
                    Session.filiere = null;
                    Session.numEtudiant = null;
                    Session.dateNaissance = null;
                    Session.dateInscription = null;
                    Session.password = null;
                    Session.codeVerification = 0;
                    Session.modeVerification = null;

                    MessageBox.Show("Compte supprimé avec succès.");

                    // 5. Retour à l'écran login
                    P1_acceuil f = new P1_acceuil();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur : utilisateur introuvable.");
                }
            }
            else
            {
                MessageBox.Show("Opération annulée.");
            }
        }

        private void btnAvis_Click(object sender, EventArgs e)
        {
            
            Classuserform.LoadUserForm(panelMain, new AvisEtudiant());
    
        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?",
                                       "Confirmation",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            // Si l'utilisateur clique sur OUI (Yes)
            if (res == DialogResult.Yes)
            {

                P1_acceuil login = new P1_acceuil();
                login.Show();
                this.Close();
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

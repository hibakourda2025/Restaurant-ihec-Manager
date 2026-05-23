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
    public partial class P1_acceuil : Form
    {
        public P1_acceuil()
        {
            InitializeComponent();
        }
        public static string role = "";
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creer_compte_etudiant f = new creer_compte_etudiant();
            f.Show();
            this.Hide();
        }
        private void btnEtudiant_Click(object sender, EventArgs e)
        {
            role = "etudiant";
            panelbackground.BackgroundImage = null;
            panelinscription.Visible = true;
            label4.Visible = true;
            btn_creer_compte.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            role = "personnel";
            panelbackground.BackgroundImage = null;
            panelinscription.Visible = true;
            label4.Visible = false;
            btn_creer_compte.Visible = false;
        }

        private void btnChef_Click(object sender, EventArgs e)
        {
            role = "personnel";
            panelbackground.BackgroundImage = null;
            panelinscription.Visible = true;
            label4.Visible = false;
            btn_creer_compte.Visible = false;
        }

        private void btn_connx_Click(object sender, EventArgs e)
        {
            string cin = txtCIN.Text;
            string password = txtMdp.Text;

            // Vérification simple
            if (cin.Length != 8)
            {
                MessageBox.Show("Le CIN doit contenir 8 chiffres !");
                return;
            }

            string sql = "";

            if (role == "etudiant")
            {
                sql = "SELECT * FROM Etudiant";
            }
            else if (role == "personnel")
            {
                sql = "SELECT * FROM Personnel";
            }
            else
            {
                MessageBox.Show("Veuillez choisir un rôle !");
                return;
            }

            // Mode déconnecté
            SqlConnection con = new SqlConnection(BD.ConnString);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();

            adapter.Fill(table); // Remplir en mémoire

            bool found = false;
            DataRow selectedRow = null; // on garde la ligne trouvée

            foreach (DataRow row in table.Rows)
            {
                if (role == "etudiant")
                {
                    if (row["cin_etudiant"].ToString() == cin && row["mot_de_passe"].ToString() == password)
                    {
                        found = true;
                        selectedRow = row;
                        break;
                    }
                }
                else if (role == "personnel")
                {
                    if (row["cin"].ToString() == cin && row["mot_de_passe"].ToString() == password)
                    {
                        found = true;
                        selectedRow = row;
                        break;
                    }
                }
            }

            if (found)
            {
                Session.user_name = selectedRow["nom"].ToString() + " " + selectedRow["prenom"].ToString();
                if (role == "etudiant")
                {
                    // récupération des données depuis la ligne trouvée
                    Session.cin = selectedRow["cin_etudiant"]?.ToString();
                    Session.nom = selectedRow["nom"]?.ToString();
                    Session.prenom = selectedRow["prenom"]?.ToString();
                    Session.numEtudiant = selectedRow["telephone"]?.ToString();
                    Session.dateNaissance = selectedRow["date_naissance"]?.ToString();
                    Session.dateInscription = selectedRow["date_inscription"]?.ToString();
                    Session.email = selectedRow["mail"]?.ToString();
                    Session.filiere = selectedRow["filiere"]?.ToString();
                    Session.password = selectedRow["mot_de_passe"]?.ToString();

                    // espace etudiant
                    P1_Etudiant f = new P1_Etudiant();
                    f.Show();
                    Hide();
                }
                else
                {
                    if (selectedRow["poste"].ToString() == "Chef" || selectedRow["poste"].ToString() == "Sous-Chef")
                    {
                        // récupération des données depuis la ligne trouvée
                        Session.cin = selectedRow["cin"]?.ToString();
                        Session.nom = selectedRow["nom"]?.ToString();
                        Session.prenom = selectedRow["prenom"]?.ToString();
                        Session.numEtudiant = selectedRow["contact"]?.ToString();
                        Session.poste = selectedRow["poste"]?.ToString();
                        Session.password = selectedRow["mot_de_passe"]?.ToString();

                        P1_Chef f = new P1_Chef();
                        f.Show();
                        Hide();
                    }
                    else
                    {
                        // récupération des données depuis la ligne trouvée
                        Session.cin = selectedRow["cin"]?.ToString();
                        Session.nom = selectedRow["nom"]?.ToString();
                        Session.prenom = selectedRow["prenom"]?.ToString();
                        Session.numEtudiant = selectedRow["contact"]?.ToString();
                        Session.poste = selectedRow["poste"]?.ToString();
                        Session.password = selectedRow["mot_de_passe"]?.ToString();

                        P1_Admin f = new P1_Admin();
                        f.Show();
                        Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vérifiez votre coordonnées !");
            }
        }

        private void btn_creer_compte_Click(object sender, EventArgs e)
        {
            Session.modeVerification = "inscription";
            creer_compte_etudiant f = new creer_compte_etudiant();
            f.Show();
            Hide();
        }

        private void labelMdpoublié_Click(object sender, EventArgs e)
        {
            Session.modeVerification = "mdp_forgot";
            mdp_oublie f = new mdp_oublie();
            f.Show();
            Hide();
        }

    }
}

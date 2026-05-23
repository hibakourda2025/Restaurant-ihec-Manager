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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Restaurant_IHEC
{
    public partial class Verif_mail : Form
    {
        public Verif_mail()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == Session.codeVerification.ToString())
            {
                MessageBox.Show("Code correct !");
                if (Session.modeVerification == "inscription")
                {
                    InsererEtudiant();
                    P1_Etudiant f = new P1_Etudiant();
                    f.Show();
                    this.Hide();
                }
                else if (Session.modeVerification == "resetPassword")
                {
                    ModifierMotDePasse();
                    Session.password = Session.newpassword;
                    Voir_compte_etudiant f = new Voir_compte_etudiant();
                    f.Show();
                    this.Hide();
                }
                else if (Session.modeVerification == "mdp_forgot")
                {
                    string sql = "SELECT * FROM Etudiant";
                    SqlConnection con = new SqlConnection(BD.ConnString);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataRow selectedRow = null;

                    foreach (DataRow row in table.Rows)
                    {
                        if (row["mail"].ToString() == Session.email) // email saisi
                        {
                            selectedRow = row;
                            break;
                        }
                    }

                    if (selectedRow != null)
                    {
                        Session.cin = selectedRow["cin_etudiant"]?.ToString();
                        Session.nom = selectedRow["nom"]?.ToString();
                        Session.prenom = selectedRow["prenom"]?.ToString();
                        Session.numEtudiant = selectedRow["telephone"]?.ToString();
                        Session.dateNaissance = selectedRow["date_naissance"]?.ToString();
                        Session.dateInscription = selectedRow["date_inscription"]?.ToString();
                        Session.email = selectedRow["mail"]?.ToString();
                        Session.filiere = selectedRow["filiere"]?.ToString();

                        Voir_compte_etudiant f = new Voir_compte_etudiant();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Aucun compte trouvé avec cet email !");
                    }
                }
            }
            //else
            //{
            //    MessageBox.Show("Code incorrect !");
            //}

        }

        public void InsererEtudiant()
        {
            string cs = "Data Source=.;Initial Catalog=Restaurant_IHEC;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Etudiant", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow row = dt.NewRow();

                row["nom"] = Session.nom;
                row["prenom"] = Session.prenom;
                row["cin_etudiant"] = Session.cin;
                row["telephone"] = Session.numEtudiant;
                row["date_naissance"] = Session.dateNaissance;
                row["date_inscription"] = Session.dateInscription;
                row["mail"] = Session.email;
                row["filiere"] = Session.filiere;
                row["mot_de_passe"] = Session.password;

                dt.Rows.Add(row);

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(dt);

                MessageBox.Show("Compte créé avec succès !");
            }
        }

        public void ModifierMotDePasse()
        {
            using (SqlConnection con = new SqlConnection(BD.ConnString))
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT cin_etudiant, mot_de_passe FROM Etudiant WHERE cin_etudiant = @cin",con);                da.SelectCommand.Parameters.AddWithValue("@cin", Session.cin);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dt.Rows[0]["mot_de_passe"] = Session.newpassword;

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(dt);

                    MessageBox.Show("Mot de passe modifié !");
                }
            }
        }

        private void linklabel_renvoyer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailService.EnvoyerEmailAuthentification();
            MessageBox.Show("Nouveau code envoyé !");
        }
    }
}

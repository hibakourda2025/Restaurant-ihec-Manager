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
    public partial class AvisEtudiant : UserControl
    {
        public AvisEtudiant()
        {
            InitializeComponent();
        }

        private void AvisEtudiant_Load(object sender, EventArgs e)
        {
            txtNom.Text = Session.nom;
            txtPrenom.Text = Session.prenom;
        }

        private void btnSoumettre_Click(object sender, EventArgs e)
        {
            // Vérification : Menu existant + Réservation effectuée
            if (!PeutPosterAvis(Session.cin, dtpDateMenu.Value.Date))
            {
                MessageBox.Show("Impossible de soumettre l'avis :\n" +
                                "- Soit aucun menu n'est enregistré à cette date.\n" +
                                "- Soit vous n'avez pas de réservation validée pour ce jour.",
                                "Accès Refusé", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    conn.Open();
                    Random rnd = new Random();
                    string codeAvis;
                    bool existeDeja;
                    //on repete la boucle tantque le code existe dans la table avisEtudiant
                    do
                    {
                        // Génère un code composer de date et un code alèatoire de 4 chiffre
                        codeAvis = DateTime.Now.ToString("yyyyMMdd") + rnd.Next(1000, 10000).ToString();
                        // Vérification en base de données
                        string sql = "SELECT COUNT(*) FROM AvisEtudiants WHERE id_avis = @code";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@code", codeAvis);
                            //(int) c'est pour transformer le resultat en entier
                            int count = (int)cmd.ExecuteScalar();
                            existeDeja = (count > 0);
                        }
                    } while (existeDeja);

                    string insertQuery = @"INSERT INTO AvisEtudiants 
                (id_avis,cin_etudiant, date_avis, date_consommation, type_menu, 
                 qualite_plats, quantite_portions, temps_attente, 
                 proprete_lieu, accueil_personnel, rapport_qualite_prix, 
                 note_globale, commentaire_libre) 
                VALUES (@id,@cin, GETDATE(), @dateC, @menu, @qP, @qPort, @att, @prop, @acc, @rqp, @note, @comm)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", codeAvis);
                        cmd.Parameters.AddWithValue("@cin", Session.cin);
                        cmd.Parameters.AddWithValue("@dateC", dtpDateMenu.Value.Date);
                        cmd.Parameters.AddWithValue("@menu", CBtypemenu.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@qP", (int)rateQuality.Value);
                        cmd.Parameters.AddWithValue("@qPort", (int)rateQuantity.Value);
                        cmd.Parameters.AddWithValue("@att", (int)rateTempsattente.Value);
                        cmd.Parameters.AddWithValue("@prop", (int)rateProprete.Value);
                        cmd.Parameters.AddWithValue("@acc", (int)rateAcceuil.Value);
                        cmd.Parameters.AddWithValue("@rqp", (int)rateRapportprix.Value);
                        cmd.Parameters.AddWithValue("@note", CBrateglobale.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@comm", textCommentaire.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Merci " + Session.user_name+ ", votre avis est enregistré !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void dtpDateMenu_ValueChanged(object sender, EventArgs e)
        {
            if (!MenuExiste(dtpDateMenu.Value))
            {
                MessageBox.Show("Désolé, aucun menu n'est enregistré pour le " +
                                dtpDateMenu.Value.ToShortDateString() +
                                ". Veuillez choisir une autre date.",
                                "Menu Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtpDateMenu.Value = DateTime.Now;//remet la date actuelle
            }
        }
        private bool MenuExiste(DateTime date)
        {
            bool existe = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    conn.Open();
                    // On compte combien de menus existent pour cette date précise
                    string query = "SELECT COUNT(*) FROM Menus WHERE date_menu = @date";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // On utilise .Date pour ne comparer que le jour, sans l'heure
                        cmd.Parameters.AddWithValue("@date", date.Date);

                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0) existe = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vérification du menu : " + ex.Message);
            }
            return existe;
        }
        private bool PeutPosterAvis(string cin, DateTime date)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    conn.Open();
                    // Cette requête vérifie si le menu existe ET si l'étudiant a réservé
                    // On utilise une jointure (JOIN) pour être certain de la cohérence
                    string query = @"
                SELECT COUNT(*) 
                FROM Menus m
                INNER JOIN Reservations r ON m.date_menu = r.date_reservation
                WHERE r.cin_etudiant = @cin 
                AND m.date_menu = @date 
                AND r.statut = 'validé'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cin", cin);
                        cmd.Parameters.AddWithValue("@date", date.Date);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0; // Retourne vrai si les deux conditions sont remplies
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de vérification : " + ex.Message);
                return false;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textCommentaire_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Voir_Avis_Etudiant : UserControl
    {
        public Voir_Avis_Etudiant()
        {
            InitializeComponent();
        }
        private BindingSource bsAvis = new BindingSource();
        private SqlDataAdapter adapterAvis;
        private DataSet dsAvis = new DataSet();
        private void Voir_Avis_Etudiant_Load(object sender, EventArgs e)
        {
            chargerStatistiques();
            chargerdgv();
        }
        private void chargerStatistiques()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    conn.Open();


                    string sqlStats = @"
    SELECT 
        COUNT(*) as totalReviews,
        ISNULL(SUM(qualite_plats), 0) as sumQualite,
        ISNULL(SUM(accueil_personnel), 0) as sumS,
        ISNULL(SUM(temps_attente), 0) as sumA,
        ISNULL(SUM(proprete_lieu), 0) as sumP,
        ISNULL(SUM(quantite_portions), 0) as sumquantite,
        ISNULL(SUM(rapport_qualite_prix), 0) as sumPrix
    FROM AvisEtudiants
    WHERE MONTH(date_consommation) = MONTH(GETDATE()) 
    AND YEAR(date_consommation) = YEAR(GETDATE())";

                    SqlCommand cmdStats = new SqlCommand(sqlStats, conn);
                    using (SqlDataReader reader = cmdStats.ExecuteReader())
                    {
                        //remplir les label
                        if (reader.Read() && reader["totalReviews"] != DBNull.Value)
                        {
                            int total_review = Convert.ToInt32(reader["totalReviews"]);
                            if (total_review>0)
                            {
                                // 1. On récupère les valeurs numériques du SQL d'abord
                                double q = Convert.ToDouble(reader["sumQualite"]) / total_review;
                                double s = Convert.ToDouble(reader["sumS"]) / total_review;
                                double a = Convert.ToDouble(reader["sumA"]) / total_review;
                                double p = Convert.ToDouble(reader["sumP"]) / total_review;
                                double qt = Convert.ToDouble(reader["sumquantite"]) / total_review;
                                double r = Convert.ToDouble(reader["sumPrix"]) / total_review;

                                // 2. On les affiche (en utilisant .Text)
                                labelqualite.Text = q.ToString("0.00");
                                labelService.Text = s.ToString("0.00");
                                labeltemps.Text = a.ToString("0.00"); // ICI: Correction du bug
                                labelproprete.Text = p.ToString("0.00");
                                labelquantite.Text = qt.ToString("0.00");
                                labelrapportprix.Text = r.ToString("0.00");

                                // 3. Moyenne Globale (on utilise les variables q, s, a, p... c'est plus propre)
                                double totalSomme = q + s + a + p + qt + r;
                                labelmoyenneglobale.Text = (totalSomme / 6).ToString("0.00");
                            }
                            else
                            {
                                // Valeurs par défaut si aucun avis n'est enregistré ce mois-ci
                                labelqualite.Text = "0";
                                labelService.Text = "0";
                                labeltemps.Text = "0";
                                labelproprete.Text = "0";
                                labelquantite.Text = "0";
                                labelrapportprix.Text = "0";
                                labelmoyenneglobale.Text = "0";
                            }

                        }
                        
                    }

                }
            }
            catch (Exception ex) 
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
                }
            }
        private void chargerdgv()
        {
            try
            {
                // 1. Vider la table actuelle pour éviter les doublons lors d'un refresh
                if (dsAvis.Tables["AvisEtudiants"] != null)
                {
                    dsAvis.Tables["AvisEtudiants"].Clear();
                }
                const string sql = "SELECT * FROM AvisEtudiants";
                adapterAvis = new SqlDataAdapter(sql, BD.ConnString);
                adapterAvis.Fill(dsAvis, "AvisEtudiants");
                bsAvis.DataSource = dsAvis.Tables["AvisEtudiants"];
                dgvAvis.DataSource = bsAvis;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement AvisEtudiant : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FiltrerAvis()
        {
            //Vérifie si des données sont chargées. Si le tableau est vide, on arrête tout pour éviter un crash.
            if (bsAvis.DataSource == null) return;

            //On crée une liste de mots (strings) qui contiendra nos conditions (Nom, Prénom, Poste).
            List<string> filtres = new List<string>();

            
            if (CBnoteglobale.Text != "tous" && !string.IsNullOrEmpty(CBnoteglobale.Text))
            {
                filtres.Add(string.Format("note_globale = '{0}'", CBnoteglobale.Text.Replace("'", "''")));
            }
            //AJOUT : Filtrage par Date (date_consomation)
            // On récupère la date du DateTimePicker (ex: dtpFiltreDate)
            // On la formate en YYYY-MM-DD pour que le BindingSource comprenne bien la comparaison
            string dateSelectionnee = dtpDateconsomation.Value.ToString("yyyy-MM-dd");
            filtres.Add(string.Format("date_consomation >= '{0} 00:00:00' AND date_consomation <= '{0} 23:59:59'", dateSelectionnee));

            //Fusion des conditions
            // On transforme la liste en une seule phrase. 
            // Si la liste contient [FiltreNom, FiltrePoste], cela devient "FiltreNom AND FiltrePoste".
            bsAvis.Filter = string.Join(" AND ", filtres);
        }

        private void CBnoteglobale_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerAvis();
        }

        private void dtpDateconsomation_ValueChanged(object sender, EventArgs e)
        {
            FiltrerAvis();
        }
    }
}

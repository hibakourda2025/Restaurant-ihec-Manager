using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Restaurant_IHEC
{
    public partial class Dashbord : UserControl
    {
        public Dashbord()
        {
            InitializeComponent();
        }
        private void Dashbord_Load(object sender, EventArgs e)
        {
            ChargerStatistiques();
            ChargerDiagrammeBarres();
            ChargerPieChartFiliere();
        }
        private void ChargerDiagrammeBarres()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    chartConsommation.Titles.Add("Consomation Des Menus Pour Cette Semaine");
                    conn.Open();
                    //on Extrait le numéro du jour
                    //Si réservation = Menu 1/2 → ajoute 1, sinon 0
                    //puis on relie Reservations à Menus pour accéder à nom_choix
                    // puis on faire preciser le weekn actuel 
                    // DATEADD(DAY, 2 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))
                    //par exemple si on est jeudi (5) on fait 2-5=-3 on dois reculer 3 jour pour arriver au lundi de cette semaine
                    //DATEADD(DAY, 8 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))
                    //par exemple si on est jeudi (5) on fait 8-5=-3 on dois avancer 3 jour pour arriver au dimanche de cette semaine
                    // AJOUT DE SET DATEFIRST 1 pour que Lundi soit le jour 1
                    string sql = @"
    SET DATEFIRST 1; 
    SELECT 
        DATEPART(WEEKDAY, r.date_reservation) AS JourSemaine,
        SUM(CASE WHEN m.nom_choix = 'Menu 1' THEN 1 ELSE 0 END) AS Menu1,
        SUM(CASE WHEN m.nom_choix = 'Menu 2' THEN 1 ELSE 0 END) AS Menu2
    FROM Reservations r
    JOIN Menus m ON r.id_menu = m.id_menu
    WHERE r.statut = 'validé'
    AND r.date_reservation >= DATEADD(DAY, 1 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))
    AND r.date_reservation <= DATEADD(DAY, 7 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))
    GROUP BY DATEPART(WEEKDAY, r.date_reservation)
    ORDER BY JourSemaine";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Vider les anciennes données
                    chartConsommation.Series["Series1"].Points.Clear();
                    chartConsommation.Series["Series2"].Points.Clear();

                    // Renommer les séries
                    chartConsommation.Series["Series1"].Name = "Menu 1";
                    chartConsommation.Series["Series2"].Name = "Menu 2";

                    // //le clé du dictionnaire est int et la valeure est le tulpe(menu1,menu2) 
                    Dictionary<int, (int menu1, int menu2)> donnees =
                    new Dictionary<int, (int, int)>();//crée le dictionnaire en mémoire

                    while (reader.Read())//Lit les résultats ligne par ligne depuis la BD.
                    {
                        int jourSemaine = Convert.ToInt32(reader["JourSemaine"]);
                        int menu1 = Convert.ToInt32(reader["Menu1"]);
                        int menu2 = Convert.ToInt32(reader["Menu2"]);
                        donnees[jourSemaine] = (menu1, menu2);
                    }
                    //Clé = int :numéro du jour SQL
                    //Valeur = string : nom français du jour
                    Dictionary<int, string> nomsJours = new Dictionary<int, string>()
                {
                    { 1, "Lundi" },
                    { 2, "Mardi" },
                    { 3, "Mercredi" },
                    { 4, "Jeudi" },
                    { 5, "Vendredi" },
                    { 6, "Samedi" }
                };
                    //Affichage sur le graphe
                    foreach (var jour in nomsJours)
                    {
                        //ce jour existe dans la BD ?
                        //si oui , prend la vraie valeur ex: 45 si non , met 0(jour futur sans réservations)
                        int menu1 = donnees.ContainsKey(jour.Key) ? donnees[jour.Key].menu1 : 0;
                        int menu2 = donnees.ContainsKey(jour.Key) ? donnees[jour.Key].menu2 : 0;

                        chartConsommation.Series["Menu 1"].Points.AddXY(jour.Value, menu1);
                        chartConsommation.Series["Menu 2"].Points.AddXY(jour.Value, menu2);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du graphique : " + ex.Message);
            }
        }
        
        private void ChargerPieChartFiliere()
        {
            try
            {
                // Nettoyage pour éviter les doublons au rafraîchissement
                chartFilieres.Titles.Clear();
                chartFilieres.Titles.Add("Répartition des Réservations par Filière");
                chartFilieres.Series[0].Points.Clear();
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    conn.Open();
                    // case pour regrouper les filieres en 5:1/2/3/M1/M2
                    // Relie Reservations à Etudiant via cin pour accéder à e.filiere
                    //on choisit uniquement les réservations de cette année
                    string sql = @"
                SELECT 
                    CASE 
                        WHEN e.filiere LIKE '1%' THEN '1ère Année'
                        WHEN e.filiere LIKE '2%' THEN '2ème Année'
                        WHEN e.filiere LIKE '3%' THEN '3ème Année'
                        WHEN e.filiere LIKE 'M1%' THEN 'Master 1'
                        WHEN e.filiere LIKE 'M2%' THEN 'Master 2'
                        ELSE 'Autre'
                    END AS Groupe,
                    COUNT(r.id_reservation) AS NbReservations
                FROM Reservations r
                INNER JOIN Etudiant e ON r.cin_etudiant = e.cin_etudiant
                WHERE r.statut = 'validé' 
                AND YEAR(r.date_reservation) = YEAR(GETDATE())
                GROUP BY 
                    CASE 
                        WHEN e.filiere LIKE '1%' THEN '1ère Année'
                        WHEN e.filiere LIKE '2%' THEN '2ème Année'
                        WHEN e.filiere LIKE '3%' THEN '3ème Année'
                        WHEN e.filiere LIKE 'M1%' THEN 'Master 1'
                        WHEN e.filiere LIKE 'M2%' THEN 'Master 2'
                        ELSE 'Autre'
                    END
                ORDER BY NbReservations DESC";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    //Vide le graphique avant d'ajouter les nouvelles données
                    chartFilieres.Series[0].Points.Clear();

                    while (reader.Read())
                    {
                        string groupe = reader["Groupe"].ToString();
                        int nb = Convert.ToInt32(reader["NbReservations"]);
                        chartFilieres.Series[0].Points.AddXY(groupe, nb);//Ajoute une part au gâteau avec le nom du groupe et le nombre
                    }

                    chartFilieres.Series[0]["PieLabelStyle"] = "Outside";//Place les étiquettes à l'extérieur du cercle
                    chartFilieres.Series[0].Label = "#VALX\n#PERCENT"; // ecrire sur l'axe x les valeurs en pourcentage
                    chartFilieres.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Erreur lors du chargement du graphique : " + ex.Message);
            }   
        }
        private void ChargerStatistiques()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    conn.Open();

                    // Places disponibles
                    //on filtre la table par la date d'aujourd'hui 
                    //puis on additionne la qte de menu1 et menu2
                    // isnull  on affiche zero si on n'a pas de menus pour aujourd'hui(dimanche)
                    string sqlPlaces = @"
                    SELECT ISNULL(SUM(quantite_dispo), 0)
                    FROM Menus
                    WHERE date_menu = CAST(GETDATE() AS DATE)";
                    SqlCommand cmd1 = new SqlCommand(sqlPlaces, conn);
                    labelPlacedispo.Text = cmd1.ExecuteScalar().ToString();

                    // Réservations annulées
                    //filtre uniquement les réservations annulées pour aujourd'hui
                    // compte le nombre de lignes qui correspondent
                    string sqlAnnul = "SELECT COUNT(*) FROM Reservations WHERE statut = 'annulé'";
                    SqlCommand cmd2 = new SqlCommand(sqlAnnul, conn);
                    labelReservationAnnulee.Text = cmd2.ExecuteScalar().ToString();

                    // Revenu aujourd'hui
                    //relie Reservations à Menus pour accéder au prix avec join
                    // puis on additionne le prix de chaque réservation confirmée
                    string sqlRevAuj = @"
                  SELECT ISNULL(SUM(m.prix), 0)
                  FROM Reservations r
                  JOIN Menus m ON r.id_menu = m.id_menu
                  WHERE r.statut = 'validé'
                  AND CAST(r.date_reservation AS DATE) = CAST(GETDATE() AS DATE)";
                    SqlCommand cmd3 = new SqlCommand(sqlRevAuj, conn);
                    labelRevenueToday.Text = cmd3.ExecuteScalar().ToString() + " DT";

                    // Revenu mois dernier
                    //relie Reservations à Menus pour accéder au prix avec join
                    // puis on additionne le prix de chaque réservation confirmée du moins dernier
                    //on utuilise month pour extraire month d'aujourd'hui et on recule avec 1 
                    //puis on verifie avec year pour ne pas fuisionner entre les année
                    string sqlRevMois = @"
                    SELECT ISNULL(SUM(m.prix), 0)
                    FROM Reservations r
                    JOIN Menus m ON r.id_menu = m.id_menu
                    WHERE r.statut = 'validé'
                    AND MONTH(r.date_reservation) = MONTH(DATEADD(MONTH,-1,GETDATE()))
                    AND YEAR(r.date_reservation) = YEAR(DATEADD(MONTH,-1,GETDATE()))";
                    SqlCommand cmd4 = new SqlCommand(sqlRevMois, conn);
                    labelRevenue_last_month.Text = cmd4.ExecuteScalar().ToString() + " DT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
}

        
    }
}

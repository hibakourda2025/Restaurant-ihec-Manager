using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_IHEC
{
    public partial class Menu_jour : UserControl
    {
        private DateTime date_jour;
        private string role;

        public Menu_jour(DateTime date_onglet,string role_user)
        {
            InitializeComponent();
            this.date_jour = date_onglet;
            this.labeldate.Text = date_jour.ToShortDateString();
            role = role_user;
            user_access(role);
        }
        private void user_access(string role)//limite l'acces au etudiant au readonly et le chef peut faire tous les modification
        {
            if (role == "Etudiant")
            {
                panelChef.Visible = false;
                panelaucunmenu.Visible = false;
                panelEtudiant.Visible = false;
                charger_menu();
            }
            else if (role == "Chef")
            {
                panelChef.Visible = true;
                panelEtudiant.Visible = false;
                panelaucunmenu.Visible = false;
                add_menus();
            }
            

        }
        private void charger_menu()
        {
            using (SqlConnection conn = new SqlConnection(BD.ConnString))
            {
                bool menutrouve = false;
                string query = "SELECT nom_choix, plat_principal, entree, dessert, prix,quantite_dispo FROM Menus WHERE CAST(date_menu AS DATE) = CAST(@date AS DATE)";
                SqlCommand cmd = new SqlCommand(query, conn);
                // On donne à SQL la date précise de l'onglet (ex: lundi, puis mardi...)
                cmd.Parameters.AddWithValue("@date", date_jour.Date);
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    //Boucle de lecture des résultats
                    while (dr.Read())
                    {
                        menutrouve = true;
                        //Identification du menu (Menu 1 ou Menu 2)
                        string typeMenu = dr["nom_choix"].ToString();

                        // Remplissage Menu 1
                        if (typeMenu == "Menu 1")
                        {
                            textEntree1.Text = dr["entree"].ToString();
                            textplatprincipal1.Text = dr["plat_principal"].ToString();
                            textDessert1.Text = dr["dessert"].ToString();
                            prix1.Text = dr["prix"].ToString();
                            qte1.Text = dr["quantite_dispo"].ToString();
                        }
                        //Remplissage Menu 2
                        else if (typeMenu == "Menu 2")
                        {
                            textEntree2.Text = dr["entree"].ToString();
                            textplatprincipal2.Text = dr["plat_principal"].ToString();
                            textDessert2.Text = dr["dessert"].ToString();
                            prix2.Text = dr["prix"].ToString();
                            qte2.Text = dr["quantite_dispo"].ToString();
                        }
                    }
                    if (menutrouve)
                    {
                        panelEtudiant.Visible = true;
                        panelEtudiant.BringToFront();
                    }
                    else
                    {
                        panelaucunmenu.Visible = true;
                        panelaucunmenu.BringToFront();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement : " + ex.Message);
                }
            }
        }
        private void add_menus()
        {
            //charger les suggestions plats existant : menu1
            ChargerCombo(CBentree1, "entree");
            ChargerCombo(CBplatprincipale1, "plat_principal");
            ChargerCombo(CBdessert1, "dessert");
            //charger les suggestions plats existant : menu2
            ChargerCombo(CBentree2, "entree");
            ChargerCombo(CBplatprincipale2, "plat_principal");
            ChargerCombo(CBdessert2, "dessert");
        }
        private void ChargerCombo(ComboBox cb, string colonne)
        {
            cb.Items.Clear();//On vide la liste actuelle de la ComboBox pour éviter de cumuler les anciens éléments
            // Elle permet au chef de taper un nouveau plat directement au clavier s'il n'existe pas dans la liste déroulante
            cb.DropDownStyle = ComboBoxStyle.DropDown;
            //Pendant que le chef tape, Visual Studio lui suggère automatiquement des plats existants
            cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb.AutoCompleteSource = AutoCompleteSource.ListItems;//source d'info pour auto_complete

            try
            {
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    conn.Open();
                    string sql = $"SELECT DISTINCT [{colonne}] FROM dbo.Menus " +
                                 $"WHERE [{colonne}] IS NOT NULL " +
                                 $"ORDER BY [{colonne}]";//ordre alphabetique
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                        cb.Items.Add(dr[0].ToString());// ajoute le resultat ds combobox

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement combo : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {

            //verification que les champ sont remplis
            if (CBentree1.Text == "" || CBplatprincipale1.Text == "" || CBdessert1.Text == "" || maskedTextPrix1.Text == "" ||
                textQte1.Text == "" || CBentree2.Text == "" || CBplatprincipale2.Text == "" || CBdessert2.Text == "" ||
                maskedTextPrix2.Text == "" ||textQte2.Text == "")
            {
                MessageBox.Show("veuillez remplir les champs obligatoires!");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(BD.ConnString))
                {
                    conn.Open();

                    //Appel de la fonction pour le Menu 1 et 2
                    // On récupère les valeurs des contrôles de l'interface
                    SauvegarderLigneMenu(conn,"Menu 1", CBentree1.Text,CBplatprincipale1.Text, CBdessert1.Text,
                        maskedTextPrix1.Text, textQte1.Text );
                    SauvegarderLigneMenu(conn, "Menu 2", CBentree2.Text, CBplatprincipale2.Text, CBdessert2.Text,
                        maskedTextPrix2.Text, textQte2.Text);

                    // Message de succès à l'utilisateur
                    MessageBox.Show(
                        "Les menus pour le " + date_jour.ToShortDateString() + " ont été enregistrés avec succès.",
                        "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Une erreur est survenue lors de l'enregistrement : " + ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
       
        private void SauvegarderLigneMenu(SqlConnection conn, string nomChoix, string entree, string plat, string dessert, string prix,string quantite)
        {
            // 1. Définition de la requête SQL (Logique "Mise à jour ou Insertion")
            string sql = @"
        IF EXISTS (SELECT 1 FROM Menus WHERE date_menu = @date AND nom_choix = @nom)
        BEGIN
            UPDATE Menus 
            SET plat_principal = @p, entree = @e, dessert = @d, prix = @prix,quantite_dispo=@qte
            WHERE date_menu = @date AND nom_choix = @nom
        END
        ELSE
        BEGIN
            INSERT INTO Menus (date_menu, nom_choix, plat_principal, entree, dessert, prix,quantite_dispo)
            VALUES (@date, @nom, @p, @e, @d, @prix,@qte)
        END";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                //  Passage des paramètres sécurisés
                cmd.Parameters.AddWithValue("@date", this.date_jour.Date);
                cmd.Parameters.AddWithValue("@nom", nomChoix); // "Menu 1" ou "Menu 2"
                cmd.Parameters.AddWithValue("@e", entree);
                cmd.Parameters.AddWithValue("@p", plat);
                cmd.Parameters.AddWithValue("@d", dessert);

                //  Conversion du prix et qte
                decimal prixDecimal = 0;
                decimal.TryParse(prix, out prixDecimal);
                cmd.Parameters.AddWithValue("@prix", prixDecimal);
                int qteInt = 0;
                int.TryParse(quantite, out qteInt); // On convertit le texte en nombre entier (int)
                cmd.Parameters.AddWithValue("@qte", qteInt);

                cmd.ExecuteNonQuery();
            } 
        }

        private void maskedTextPrix1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("try a number",
               "invalid data type",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }

        private void maskedTextPrix2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("try a number",
               "invalid data type",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
        }

        private void CBentree1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Try a letter",
                    "Invalid data type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void CBentree2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Try a letter",
                    "Invalid data type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void CBplatprincipale1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Try a letter",
                    "Invalid data type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void CBplatprincipale2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Try a letter",
                    "Invalid data type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void textQte1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is NOT a digit AND NOT a control key (like Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block the input

                MessageBox.Show("Please enter a number.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void textQte2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the character is NOT a digit AND NOT a control key (like Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block the input

                MessageBox.Show("Please enter a number.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        
    }
}

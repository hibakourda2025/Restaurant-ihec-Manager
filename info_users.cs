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
    public partial class info_users : UserControl
    {
        //- Personnel
        private BindingSource bsPersonnel = new BindingSource();
        private SqlDataAdapter adapterPersonnel;
        private DataSet dsPersonnel = new DataSet();

        //- Etudiant
        private BindingSource bsEtudiant = new BindingSource();
        private SqlDataAdapter adapterEtudiant;
        private DataSet dsEtudiant = new DataSet();

        public info_users()
        {
            InitializeComponent();
        }
        //  Propriété qui retourne le BindingSource de l'onglet actif
        private BindingSource ActiveBindingSource
        {
            get
            {
                
                if (tabControl1.SelectedTab == tabPageEmployèes)
                    return bsPersonnel;
                else
                    return bsEtudiant;
            }
        }
        private void btnTop_Click(object sender, EventArgs e)
        {
            ActiveBindingSource.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ActiveBindingSource.MovePrevious();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            ActiveBindingSource.MoveNext();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            ActiveBindingSource.MoveLast();
        }

        private void tabPageEmployèes_Enter(object sender, EventArgs e)
        { 
                // Évite de recharger si les données sont déjà là
                if (dsPersonnel.Tables["Personnel"] != null) return;

                try
                {
                    const string sql = "SELECT * FROM Personnel";
                    adapterPersonnel = new SqlDataAdapter(sql,BD.ConnString);
                    adapterPersonnel.Fill(dsPersonnel, "Personnel");
                    bsPersonnel.DataSource = dsPersonnel.Tables["Personnel"];
                    dgvEmployees.DataSource = bsPersonnel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur chargement Personnel : " + ex.Message,
                                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
          
        private void tabPageEtudiant_Enter(object sender, EventArgs e)
        {
            if (dsEtudiant.Tables["Etudiant"] != null) return;

            try
            {
                const string sql = "SELECT * FROM Etudiant";
                adapterEtudiant = new SqlDataAdapter(sql, BD.ConnString);
                adapterEtudiant.Fill(dsEtudiant, "Etudiant");        
                bsEtudiant.DataSource = dsEtudiant.Tables["Etudiant"];
                dgvEtudiant.DataSource = bsEtudiant;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement Etudiant : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerPersonnel();
        }

        private void comboBoxFiliere_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrerEtudiant();
        }

        private void FiltrerPersonnel()
        {
            // 1. Vérifie si des données sont chargées. Si le tableau est vide, on arrête tout pour éviter un crash.
            if (bsPersonnel.DataSource == null) return;

            // 2. On crée une liste de mots (strings) qui contiendra nos conditions (Nom, Prénom, Poste).
            List<string> filtres = new List<string>();

            // 3. Vérification du TextBox NOM et prenom des employés
            if (!string.IsNullOrEmpty(txtNomPersonnel.Text))
            {
                // Ajoute "Nom LIKE '%valeur%'" à la liste. Les '%' permettent de trouver le nom même si on ne tape qu'une partie.
                filtres.Add(string.Format("Nom LIKE '%{0}%'", txtNomPersonnel.Text.Replace("'", "''")));
            }
            if (!string.IsNullOrEmpty(txtPrenomPersonnel.Text))
                filtres.Add(string.Format("Prenom LIKE '%{0}%'", txtPrenomPersonnel.Text.Replace("'", "''")));
            // 4. Vérification du ComboBox OCCUPATION
            // On ne filtre que si l'utilisateur a choisi quelque chose ET que ce n'est pas "Tous".
            if (comboBoxOccupation.Text != "Tous" && !string.IsNullOrEmpty(comboBoxOccupation.Text))
            {
                // Ici on utilise '=' car on veut le métier exact (ex: Poste = 'Chef').
                filtres.Add(string.Format("Poste = '{0}'", comboBoxOccupation.Text.Replace("'", "''")));
            }
                // 5. Fusion des conditions
                // On transforme la liste en une seule phrase. 
                // Si la liste contient [FiltreNom, FiltrePoste], cela devient "FiltreNom AND FiltrePoste".
                bsPersonnel.Filter = string.Join(" AND ", filtres);
        }
        private void FiltrerEtudiant()
        {
           
            if (bsEtudiant.DataSource == null) return;
            List<string> filtres = new List<string>();

            if (!string.IsNullOrEmpty(textnomEtudiant.Text))
            {
                // On cherche dans la colonne 'Nom' de la table Etudiant en SQL.
                filtres.Add(string.Format("Nom LIKE '%{0}%'", textnomEtudiant.Text.Replace("'", "''")));
            }
            if (!string.IsNullOrEmpty(txtprenomEtudiant.Text))
                filtres.Add(string.Format("Prenom LIKE '%{0}%'", txtprenomEtudiant.Text.Replace("'", "''")));

            // 4. Vérification du ComboBox FILIERE
            // Si l'étudiant choisit une filière précise (et pas "Tous").
            if (comboBoxFiliere.Text != "Tous" && !string.IsNullOrEmpty(comboBoxFiliere.Text))
            {
                // IMPORTANT : 'Filiere' doit être le nom exact de la colonne dans ta table SQL Etudiant.
                filtres.Add(string.Format("Filiere = '{0}'", comboBoxFiliere.Text.Replace("'", "''")));
            }
                bsEtudiant.Filter = string.Join(" AND ", filtres);
        }

        private void txtPrenomPersonnel_TextChanged(object sender, EventArgs e)
        {
            FiltrerPersonnel();
        }

        private void txtNomPersonnel_TextChanged(object sender, EventArgs e)
        {
            FiltrerPersonnel();
        }

        private void txtprenomEtudiant_TextChanged(object sender, EventArgs e)
        {
            FiltrerEtudiant();
        }

        private void textnomEtudiant_TextChanged(object sender, EventArgs e)
        {
            FiltrerEtudiant();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Sauvegarde uniquement l'onglet actuellement affiché
                if (tabControl1.SelectedTab == tabPageEmployèes)
                {
                    // ── Personnel ──
                    bsPersonnel.EndEdit();
                    if (adapterPersonnel != null)
                    {
                        SqlCommandBuilder cb = new SqlCommandBuilder(adapterPersonnel);
                        adapterPersonnel.Update(dsPersonnel.Tables["Personnel"]);
                    }
                }
                else
                {
                    // ── Etudiant ──
                    bsEtudiant.EndEdit();
                    if (adapterEtudiant != null)
                    {
                        SqlCommandBuilder cb = new SqlCommandBuilder(adapterEtudiant);
                        adapterEtudiant.Update(dsEtudiant.Tables["Etudiant"]);
                    }
                }

                MessageBox.Show("Mise à jour effectuée avec succès !",
                                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur sauvegarde : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrenomPersonnel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNomPersonnel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtprenomEtudiant_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textnomEtudiant_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    }



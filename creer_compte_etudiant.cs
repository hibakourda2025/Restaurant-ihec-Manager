using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Restaurant_IHEC
{
    public partial class creer_compte_etudiant : Form
    {
        public creer_compte_etudiant()
        {
            InitializeComponent();
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                MessageBox.Show("Veuillez saisir uniquement des lettres !", "invalide data type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // ne pas afficher le caractere saisi apres le message
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            // Récupération
            Session.nom = txtNom.Text;
            Session.prenom = txtPrenom.Text;
            Session.cin = txtCIN.Text;
            Session.numEtudiant = txtNumEtudiant.Text;
            Session.dateNaissance = dtpNaissance.Value.ToString();
            Session.dateInscription = dtpInscription.Value.ToString();
            Session.email = txtEmail.Text;
            Session.filiere = txtFiliere.Text;
            Session.password = txtmdp.Text;
            string confirmPassword = txtConfirmermdp.Text;

            // Vérification
            if (string.IsNullOrWhiteSpace(Session.nom) ||
                string.IsNullOrWhiteSpace(Session.prenom) ||
                string.IsNullOrWhiteSpace(Session.cin) ||
                string.IsNullOrWhiteSpace(Session.email) ||
                string.IsNullOrWhiteSpace(Session.password))
            {
                MessageBox.Show("Remplir tous les champs !");
                return;
            }

            if (!txtCIN.MaskFull)
            {
                MessageBox.Show("CIN invalide !");
                return;
            }

            if (Session.password != confirmPassword)
            {
                MessageBox.Show("Mot de passe non confirmé !");
                return;
            }
            // Générer code
            Random rnd = new Random();
            Session.codeVerification = rnd.Next(10000, 99999);
            //send mail
            EmailService.EnvoyerEmailAuthentification();
            this.Close();
            Verif_mail f = new Verif_mail();
            f.Show(); 
        }

        private void txtCIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Veuillez saisir un numéro !", "invalide data type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pattern = @"^[a-zA-Z]+\.[a-zA-Z]+\.(202[0-9])@ihec\.ucar\.tn$";
            if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Email invalide ! Format attendu : nom.prenom.2025@ihec.ucar.tn", "Invalid Data Format",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtEmail.Focus();//Remet le curseur dans le champ
            }
        }

        private void dtpInscription_ValueChanged(object sender, EventArgs e)
        {
            DateTime selected = dtpInscription.Value.Date;
            DateTime today = DateTime.Now.Date;
            if (selected >= today)
                MessageBox.Show("La date d'Inscription doit être STRICTEMENT inferieur à la date actuelle.", "invalide data value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dtpNaissance_ValueChanged(object sender, EventArgs e)
        {
            DateTime selected = dtpNaissance.Value.Date;
            DateTime today = DateTime.Now.Date;
            if (selected >= today)
                MessageBox.Show("La date d'Inscription doit être STRICTEMENT inferieur à la date actuelle.", "invalide data value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtNumEtudiant_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Veuillez saisir un numéro !", "invalide data type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ')
            {
                MessageBox.Show("Veuillez saisir uniquement des lettres !", "invalide data type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // ne pas afficher le caractere saisi apres le message
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            P1_acceuil f = new P1_acceuil();
            f.Show();
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_IHEC
{
    public partial class mdp_oublie : Form
    {
        public mdp_oublie()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            Session.email = txtEmail.Text;
            // Générer code
            Random rnd = new Random();
            Session.codeVerification = rnd.Next(10000, 99999);

            // Envoyer email
            EmailService.EnvoyerEmailAuthentification();
            this.Close();
            Verif_mail f = new Verif_mail();
            f.Show();
           
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z]+\.[a-zA-Z]+\.(202[0-9])@ihec\.ucar\.tn$";

            if (!Regex.IsMatch(txtEmail.Text, pattern))
            {
                MessageBox.Show("Email invalide ! Format attendu : nom.prenom.2025@ihec.ucar.tn",
                    "Invalid data value",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmail.Focus();//sert à remettre le curseur dans le champ Email
            }

        }
    }
}

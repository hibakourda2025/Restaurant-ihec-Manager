using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_IHEC
{
    public partial class Mot_de_passe : Form
    {
        public Mot_de_passe()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string mdp1 = txtMdp.Text;
            string mdp2 = txtConfirmerMdp.Text;

            if (mdp1 == mdp2)
            {
                Session.newpassword = mdp1;
                Session.modeVerification = "resetPassword";
                // Générer code
                Random rnd = new Random();
                Session.codeVerification = rnd.Next(10000, 99999);
                // Envoyer email
                EmailService.EnvoyerEmailAuthentification(); 

                Verif_mail f = new Verif_mail();
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.\nVeuillez vérifier votre saisie et réessayer.","Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

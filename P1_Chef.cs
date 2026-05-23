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
    public partial class P1_Chef : Form
    {
        public P1_Chef()
        {
            InitializeComponent();
            labelChef.Text = Session.user_name;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeerermenus_Click(object sender, EventArgs e)
        {
            Classuserform.LoadUserForm(panelmain, new Menu_semaine ("Chef"));
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?",
                                      "Confirmation",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            // Si l'utilisateur clique sur OUI (Yes)
            if (res == DialogResult.Yes)
            {

                P1_acceuil login = new P1_acceuil();
                login.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classuserform.LoadUserForm(panelmain, new voir_compte_chef());
        }

        private void btnVoirAvis_Click(object sender, EventArgs e)
        {
            Classuserform.LoadUserForm(panelmain,new Voir_Avis_Etudiant());
        }
    }
}

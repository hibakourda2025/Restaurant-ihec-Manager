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
    public partial class Menu_semaine : UserControl
    {
        private string role;
        public Menu_semaine(string role_user)
        {
            InitializeComponent();
            role = role_user;
            
        }

        private void Menu_semaine_Load(object sender, EventArgs e)
        {
            ChargerSemaine();
            SelectionnerOngletDuJour();
        }
        private void ChargerSemaine()
        {
            DateTime aujourdhui = DateTime.Now.Date;
            DateTime lundiCible;// variabke pour sauvgarder le lundi du semaine actuelle

            //si on est dimanche les tab page seront du semaine d'apres le lundi du lendemain
            if (aujourdhui.DayOfWeek == DayOfWeek.Sunday)
            {
                lundiCible = aujourdhui.AddDays(1);
            }
            else
            {
                // Si on est un autre jour (ex: Mardi), on recule jusqu'au lundi de la semaine en cours
                int delta = (int)aujourdhui.DayOfWeek - (int)DayOfWeek.Monday;
                lundiCible = aujourdhui.AddDays(-delta);
            }

            // 2. Tableau de tes TabPages
            TabPage[] pages = { tabPageLundi, tabPageMardi, tabPageMercredi, tabPageJeudi, tabPageVendredi, tabPageSamedi };

            for (int i = 0; i < pages.Length; i++)
            {
                DateTime dateJour = lundiCible.AddDays(i);
                Menu_jour uc = new Menu_jour(dateJour,role);
                uc.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                uc.Location = new Point(0, 0);

                pages[i].Controls.Clear();
                pages[i].Controls.Add(uc);
            }
        }
        private void SelectionnerOngletDuJour()
        {
            int jourIndex = (int)DateTime.Now.DayOfWeek;//recupere n° du jour actuel

            // On ajuste l'index pour notre TabControl (Lundi=0, Mardi=1...)
            // Si on est dimanche (0), on peut rester sur lundi (0) ou samedi (5)
            int indexOnglet = jourIndex - 1;// on retire 1 car tabindex lundi est 0

            if (indexOnglet < 0) indexOnglet = 0; // Si dimanche, on ouvre le lundi
            if (indexOnglet > 5) indexOnglet = 5; // On ne dépasse pas le samedi

            // Sélection automatique de l'onglet dans le TabControl
            TCsemaine.SelectedIndex = indexOnglet;
        }

        private void tabPageLundi_Click(object sender, EventArgs e)
        {

        }
    }
}

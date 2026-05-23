using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_IHEC
{
    internal class Classuserform
    {
        public static void LoadUserForm(Panel panel, UserControl uc)
        {
            //Libère la mémoire des anciens contrôles
            if (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose();
            }
            panel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel.Controls.Add(uc);
        }
    }
}

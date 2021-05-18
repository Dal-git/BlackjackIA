using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackIA
{
    public partial class VueParametres : Form
    {
        public VueParametres()
        {
            InitializeComponent();
        }

        private void VueParametres_Load(object sender, EventArgs e)
        {

        }

        private void tbx_nom_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbx_nom.Text))
            {
                btn_envoyer.Enabled = true;
            }
            else
            {
                btn_envoyer.Enabled = false;
            }
        }

        private void btn_envoyer_Click(object sender, EventArgs e)
        {
            VuePrincipale vuePrincipale = new VuePrincipale(tbx_nom.Text, (int)nud_paquet.Value);
            vuePrincipale.Show();
            this.Close();
        }
    }
}

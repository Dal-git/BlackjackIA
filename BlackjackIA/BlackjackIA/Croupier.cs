using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackIA
{
    class Croupier : Joueur
    {
        public Croupier(GroupBox gbx) : base("Croupier", gbx)
        {

        }

        public void CacherSecondeCarte()
        {            
            Main[1].Image = new Bitmap(Properties.Resources.dos as Image, Main[0].Size);
        }
    }
}

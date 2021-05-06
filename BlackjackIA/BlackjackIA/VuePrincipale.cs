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
    public partial class VuePrincipale : Form
    {
        Joueur joueur;
        Paquet paquet = new Paquet(1);
        static Random _random = new Random();
        Blackjack blackjack;

        public static Random Random { get => _random; set => _random = value; }

        public VuePrincipale()
        {
            InitializeComponent();
            joueur = new Joueur("Moi", gbx_Joueur);
            blackjack = new Blackjack(joueur, paquet, this, Random);
            lbl_NomDuJoueur.Text = joueur.NomDuJoueur;
        }

        private void VuePrincipale_Load(object sender, EventArgs e)
        {
            blackjack.Distribution();
            MiseAJourAffichage();            
            lbl_TotalCroupier.Text = blackjack.Croupier.Main[0].ValeurDansJeu.ToString();
        }

        private void btn_Piocher_Click(object sender, EventArgs e)
        {
            joueur.Piocher(paquet, 1, Random);
            if (joueur.ValeurDeLaMain >= 21)
            {
                btn_Rester_Click(this, e);
            }
            MiseAJourAffichage();
        }

        public void MiseAJourAffichage()
        {
            int carteJouees = (joueur.Main.Count + blackjack.Croupier.Main.Count);
            lbl_TotalJoueur.Text = joueur.ValeurDeLaMain.ToString();            
            lbl_CartesJouees.Text = carteJouees.ToString();
            lbl_CartesRestantes.Text = (52 - carteJouees).ToString();
            label13.Text = blackjack.EtatPartie;
        }

        private void btn_Rester_Click(object sender, EventArgs e)
        {
            blackjack.CroupierPiocheJusqua17();
            blackjack.Croupier.AfficherMain(gbx_Croupier);
            lbl_TotalCroupier.Text = blackjack.Croupier.ValeurDeLaMain.ToString();
            blackjack.Comparaison();
            MiseAJourAffichage();
        }
    }
}

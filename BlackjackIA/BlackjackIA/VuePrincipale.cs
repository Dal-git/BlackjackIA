/*
* Auteur : Dallas CATILLAZ
*
* Professeur : M.Pascal BONVIN
*
* Experts : M.Robin BOUILLE et M.Daniel VANINI
*
* Date : 04 mai 2021
*
* Mandant : CFPT-Informatique, Genève, Petit-Lancy
*
* Projet : BlackjackIA - Jeu de Blackjack avec un adversaire et une aide controlé par une IA
*
* Version : 1.0
*
* Description : Jeu de blackjack développé dans le cadre d'un TPI de fin de CFC à l'école d'informatique de Genève.
* L'application permet au joueur de jouer contre un ordinateur et d'être conseillé sur la pioche des cartes.
*
* Fichier : VuePrincipale.cs
*
* Description : 
*/
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
        Paquet paquet = new Paquet(3);
        static Random _random = new Random();
        Blackjack blackjack;
        Statistiques statistiques = new Statistiques();

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
            ChangementCouleurBoutton();
            lbl_TotalCroupier.Text = blackjack.Croupier.Main[0].ValeurDansJeu.ToString();
        }

        private void btn_Piocher_Click(object sender, EventArgs e)
        {
            joueur.Piocher(paquet, 1, Random);
            if (joueur.ValeurDeLaMain >= 21)
            {
                btn_Rester_Click(this, e);
            }
            else
            {
                ChangementCouleurBoutton();
            }
            MiseAJourAffichage();
        }

        public void MiseAJourAffichage()
        {
            int carteJouees = (joueur.Main.Count + blackjack.Croupier.Main.Count);
            lbl_TotalJoueur.Text = joueur.ValeurDeLaMain.ToString();
            lbl_CartesJouees.Text = carteJouees.ToString();
            lbl_CartesRestantes.Text = blackjack.Paquet.PaquetDuJeu.Count.ToString();
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

        public void ChangementCouleurBoutton()
        {
            if (joueur.ValeurDeLaMain != 0 && blackjack.Croupier.ValeurDeLaMain != 0)
            {
                bool ilFautPioche = blackjack.Strategie[blackjack.Strategie.Keys.Where(x => x.ValeurMainCroupier == blackjack.Croupier.Main[0].ValeurDansJeu && x.ValeurMainJoueur == blackjack.Joueur.ValeurDeLaMain).ToArray()[0]];

                if (ilFautPioche)
                {
                    btn_Piocher.BackColor = Color.Green;
                    btn_Rester.BackColor = Color.Red;
                }
                else
                {
                    btn_Rester.BackColor = Color.Green;
                    btn_Piocher.BackColor = Color.Red;
                }
            }
        }
    }
}
/*
* Auteur : Dallas CATILLAZ
*
* Professeur : M.Pascal BONVIN
*
* Experts : M.Robin BOUILLE et M.Daniel VANINI
*
* Date de la dernière modification : 12 mai 2021
*
* Mandant : CFPT-Informatique, Genève, Petit-Lancy
*
* Projet : BlackjackIA - Jeu de Blackjack avec un adversaire et une aide controlé par une IA
*
* Version : 1.0
*
* Description : Jeu de blackjack développé dans le cadre d'un TPI de fin de CFC à l'école d'informatique de Genève.
* L'application permet au joueur de jouer au Blackjack contre un ordinateur et d'être conseillé sur la pioche des cartes.
*
* Fichier : VuePrincipale.cs
*
* Description : Est l'affichage principale du jeu
*/
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BlackjackIA
{
    public partial class VuePrincipale : Form
    {
        #region Variables
        Joueur _joueur;
        Paquet _paquet;
        static Random _random = new Random();
        Blackjack _blackjack;

        public static Random Random { get => Random1; set => Random1 = value; }
        internal Joueur Joueur { get => _joueur; set => _joueur = value; }
        internal Paquet Paquet { get => _paquet; set => _paquet = value; }
        public static Random Random1 { get => _random; set => _random = value; }
        internal Blackjack Blackjack { get => _blackjack; set => _blackjack = value; }
        #endregion

        /// <summary>
        /// Nous construit notre form principale et y initialise le joueur, le blackjack et change le label du nom du joueur
        /// </summary>
        public VuePrincipale(string nomJoueur, int nombreDePaquet)
        {
            InitializeComponent();
            _paquet = new Paquet(nombreDePaquet);
            Joueur = new Joueur(nomJoueur, gbx_Joueur);
            Blackjack = new Blackjack(Joueur, Paquet, this, Random);
            lbl_NomDuJoueur.Text = Joueur.NomDuJoueur;
        }

        /// <summary>
        /// Quand notre form charge les cartes sont distibué, les éléments d'affichage rafraichi, les boutons change de coleur par rapport au conseil recu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VuePrincipale_Load(object sender, EventArgs e)
        {
            Blackjack.Distribution();
            MiseAJourAffichage();
            ChangementCouleurBoutton();
            lbl_TotalCroupier.Text = Blackjack.Croupier.Main[0].ValeurDansJeu.ToString();
        }

        /// <summary>
        /// Quand on appui sur le bouton de pioche on prend une carte du paquet
        /// Si notre main plus grande ou égal a 21 le bouton rester est appuyé automatiquement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Piocher_Click(object sender, EventArgs e)
        {
            Joueur.Piocher(Paquet, 1);
            if (Joueur.ValeurDeLaMain >= 21)
            {
                btn_Rester_Click(this, e);
            }
            else
            {
                ChangementCouleurBoutton();
            }
            MiseAJourAffichage();
        }

        /// <summary>
        /// Rafraichi tous les éléments d'affichage de notre form
        /// </summary>
        public void MiseAJourAffichage()
        {
            int carteJouees = (Joueur.Main.Count + Blackjack.Croupier.Main.Count);
            double proba10 = 0;
            lbl_TotalJoueur.Text = Joueur.ValeurDeLaMain.ToString();
            lbl_CartesJouees.Text = carteJouees.ToString();
            lbl_CartesRestantes.Text = Blackjack.Paquet.PaquetDuJeu.Count.ToString();
            Blackjack.CompterProbaTirageCarte();
            lbl_Probabilites.Text = "";
            lbl_statsDetails.Text = "";
            //Nous fais l'affichage des stats
            foreach (Carte.Valeur valeur in (Carte.Valeur[])Enum.GetValues(typeof(Carte.Valeur)))
            {
                lbl_statsDetails.Text += valeur.ToString() + " : " + Blackjack.ProbaTirageCarte[valeur].ToString() + "%\r";
                if (Joueur.ValeurDeLaMain + new Carte(valeur).ValeurDansJeu <= 21)
                {
                    if (valeur == Carte.Valeur.Dix || valeur == Carte.Valeur.Valet || valeur == Carte.Valeur.Dame || valeur == Carte.Valeur.Roi)
                    {
                        proba10 += Blackjack.ProbaTirageCarte[valeur];
                        if (valeur == Carte.Valeur.Roi)
                        {
                            lbl_Probabilites.Text += (Joueur.ValeurDeLaMain + new Carte(valeur).ValeurDansJeu) + " : " + proba10.ToString() + "%\r";
                        }
                    }
                    else
                    {
                        lbl_Probabilites.Text += (Joueur.ValeurDeLaMain + new Carte(valeur).ValeurDansJeu) + " : " + Blackjack.ProbaTirageCarte[valeur].ToString() + "%\r";
                    }
                }
                else if (valeur == Carte.Valeur.As && Joueur.ValeurDeLaMain == 20)
                {
                    lbl_Probabilites.Text += (Joueur.ValeurDeLaMain + 1) + " : " + Blackjack.ProbaTirageCarte[valeur].ToString() + "%\r";
                }
            }
            lbl_etatPartie.Text = Blackjack.EtatPartie;
        }

        /// <summary>
        /// Quand on appui sur le bouton pour rester le croupier joue puis lorsqu'il a pioché toutes ses cartes le jeu lance la comparaison de mains et décide du vainqueur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rester_Click(object sender, EventArgs e)
        {
            Blackjack.CroupierPiocheJusqua17();
            Blackjack.Croupier.AfficherMain(gbx_Croupier);
            lbl_TotalCroupier.Text = Blackjack.Croupier.ValeurDeLaMain.ToString();
            Blackjack.Comparaison();
            MiseAJourAffichage();
            button1.Visible = true;
        }

        /// <summary>
        /// Par rapport au conseil recu les boutons change de couleur pour nous indiquer ce qu'il faut faire
        /// </summary>
        public void ChangementCouleurBoutton()
        {
            if (Joueur.ValeurDeLaMain != 0 && Blackjack.Croupier.ValeurDeLaMain != 0)
            {
                bool ilFautPioche = Blackjack.Strategie[Blackjack.Strategie.Keys.Where(x => x.ValeurMainCroupier == Blackjack.Croupier.Main[0].ValeurDansJeu && x.ValeurMainJoueur == Blackjack.Joueur.ValeurDeLaMain).ToArray()[0]];

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

        private void VuePrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void VuePrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Blackjack.Distribution();
            MiseAJourAffichage();
            Blackjack.EtatPartie = null;
            lbl_etatPartie.Text = "";
            ChangementCouleurBoutton();
            lbl_TotalCroupier.Text = Blackjack.Croupier.Main[0].ValeurDansJeu.ToString();
            button1.Hide();
        }

        private void gbx_Joueur_Enter(object sender, EventArgs e)
        {

        }
    }
}
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
* 
* L'application permet au joueur de jouer au Blackjack contre un ordinateur et d'être conseillé sur la pioche des cartes.
*
* Fichier : Joueur.cs
*
* Description : Créé un joueur qui dispose d'une main et peut piocher des cartes
*/

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BlackjackIA
{
    class Joueur
    {
        #region Variables
        private List<Carte> main = new List<Carte>();
        private string nomDuJoueur;
        private int valeurDeLaMain;
        private GroupBox _gbxMainJoueur;

        internal List<Carte> Main { get => main; set => main = value; }
        public string NomDuJoueur { get => nomDuJoueur; set => nomDuJoueur = value; }
        public int ValeurDeLaMain { get => valeurDeLaMain; set => valeurDeLaMain = value; }
        public GroupBox GbxMainJoueur { get => _gbxMainJoueur; set => _gbxMainJoueur = value; }
        #endregion

        /// <summary>
        /// Construit un joueur avec un nom et un groupBox qui représentera sa main
        /// </summary>
        /// <param name="nom">Le nom du joueur</param>
        /// <param name="gbx">L'endroit ou la main du joueur sera affiché</param>
        public Joueur(string nom, GroupBox gbx)
        {
            NomDuJoueur = nom;
            GbxMainJoueur = gbx;
            ValeurDeLaMain = 0;
        }
        /// <summary>
        /// Vas permettre à notre joueur de pioche des cartes du paquet pour les ajouter dans sa main
        /// </summary>
        /// <param name="paquet">Le paquet ou l'on va pioché les cartes</param>
        /// <param name="nombreDeCarteAPiocher">Le nombre de carte que l'on vas pioché</param>        
        public void Piocher(Paquet paquet, int nombreDeCarteAPiocher)
        {
            if (ValeurDeLaMain < 21)
            {
                for (int i = 0; i < nombreDeCarteAPiocher; i++)
                {                    
                    Carte cartePioche = paquet.PaquetDuJeu[0];
                    Main.Add(cartePioche);
                    paquet.PaquetDuJeu.RemoveAt(0);
                    ValeurDeLaMain += cartePioche.ValeurDansJeu;
                }
                TestChangementValeurAs();
                AfficherMain(GbxMainJoueur);
            }
        }

        /// <summary>
        /// Affiche toute les cartes de la main dans le groupbox
        /// </summary>
        /// <param name="gbx"></param>
        public void AfficherMain(GroupBox gbx)
        {
            foreach (Carte carte in Main)
            {
                if (carte.Retourne)
                {
                    carte.Retourner();
                }
                carte.Location = new Point(6 + main.IndexOf(carte) * 210, 15);
                gbx.Controls.Add(carte);
            }
        }

        /// <summary>
        /// Regarde si notre main contient un As et que la valeur totale de notre main dépasse 21
        /// Si oui alors la valeur de du premier As dans la main dont la valeur est 11 devient 1.
        /// </summary>
        public void TestChangementValeurAs()
        {            
            if (valeurDeLaMain > 21 && Main.Where(x => x.CarteValeur == Carte.Valeur.As && x.ValeurDansJeu == 11).ToArray().Count() != 0)
            {
                Main.Where(x => x.CarteValeur == Carte.Valeur.As && x.ValeurDansJeu == 11).ToArray()[0].ValeurDansJeu = 1;
                CalculerValeurDeLaMain();
            }
        }

        /// <summary>
        /// Calcule la valeur totale de notre main
        /// </summary>
        public void CalculerValeurDeLaMain()
        {
            valeurDeLaMain = 0;
            foreach (Carte carte in Main)
            {
                ValeurDeLaMain += carte.ValeurDansJeu;
            }
        }
    }
}

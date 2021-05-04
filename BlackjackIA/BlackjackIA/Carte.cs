/*
* Auteur : Dallas CATILLAZ
*
* Professeur : M.Pascal BONVIN
*
* Experts : M.Robin BOUILLE et M.Daniel VANINI
*
* Date : 03 mai 2021
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
* Fichier : Carte.cs
*
* Description : Cette classe permet de créer les cartes pour le jeu. Elle hérite de la classe PictureBox pour rendre leur création plus simple et cohérente.
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackIA
{
    class Carte : PictureBox
    {
        public enum Couleur { Trefle, Carreau, Coeur, Pique }
        public enum Valeur { Deux, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Valet, Dame, Roi, As }

        private Couleur _carteCouleur;
        private Valeur _carteValeur;
        private int _valeurDansJeu;

        internal Couleur CarteCouleur { get => _carteCouleur; set => _carteCouleur = value; }
        internal Valeur CarteValeur { get => _carteValeur; set => _carteValeur = value; }
        public int ValeurDansJeu { get => _valeurDansJeu; set => _valeurDansJeu = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="couleur"></param>
        /// <param name="valeur"></param>
        public Carte(Couleur couleur = Couleur.Coeur, Valeur valeur = Valeur.As)
        {
            CarteCouleur = couleur;
            CarteValeur = valeur;

            switch (valeur)
            {
                case Valeur.Deux:
                case Valeur.Trois:
                case Valeur.Quatre:
                case Valeur.Cinq:
                case Valeur.Six:
                case Valeur.Sept:
                case Valeur.Huit:
                case Valeur.Neuf:
                case Valeur.Dix:
                    ValeurDansJeu = (int)valeur + 2;
                    break;
                case Valeur.Valet:
                case Valeur.Dame:
                case Valeur.Roi:
                    ValeurDansJeu = 10;
                    break;
                case Valeur.As:
                    ValeurDansJeu = 11;
                    break;
            }
            Name = CarteValeur.ToString() + CarteCouleur.ToString();
            Size = new Size(209, 303);
            Image = new Bitmap(Properties.Resources.ResourceManager.GetObject(ToString()) as Image, Size);            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("_{0}{1}", CarteValeur, CarteCouleur);
        }
    }
}

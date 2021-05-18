/*
* Auteur : Dallas CATILLAZ
*
* Professeur : M.Pascal BONVIN
*
* Experts : M.Robin BOUILLE et M.Daniel VANINI
*
* Date de la dernière modification  : 03 mai 2021
*
* Mandant : CFPT-Informatique, Genève, Petit-Lancy
*
* Projet : BlackjackIA - Jeu de Blackjack avec un adversaire et une aide controlé par une IA
*
* Version : 1.0
*
* Description : Jeu de blackjack développé dans le cadre d'un TPI de fin de CFC à l'école d'informatique de Genève.
* 
* L'application permet au joueur de jouer contre un ordinateur et d'être conseillé sur la pioche des cartes.
*
* Fichier : Carte.cs
*
* Description : Cette classe permet de créer les cartes pour le jeu. Elle hérite de la classe PictureBox pour rendre leur affichage plus simple et cohérente.
*/

using System.Drawing;
using System.Windows.Forms;

namespace BlackjackIA
{
    class Carte : PictureBox
    {
        #region Variables
        public enum Couleur { Trefle, Carreau, Coeur, Pique }
        public enum Valeur { Deux, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Valet, Dame, Roi, As }

        private Couleur _carteCouleur;
        private Valeur _carteValeur;
        private int _valeurDansJeu;
        private bool _retourne;

        internal Couleur CarteCouleur { get => _carteCouleur; set => _carteCouleur = value; }
        internal Valeur CarteValeur { get => _carteValeur; set => _carteValeur = value; }
        public int ValeurDansJeu { get => _valeurDansJeu; set => _valeurDansJeu = value; }
        public bool Retourne { get => _retourne; set => _retourne = value; }
        #endregion
        /// <summary>
        /// Créé une carte avec une couleur (Coeur, Pique etc.) , une valeur (As, Deux etc.) ainsi qu'une valeur dans le jeu (1, 2 etc.)
        /// Comme une carte est considéré comme un PictureBox je lui initialise aussi un Name, une Size et une Image qui
        /// a le même nom que la carte.ToString()
        /// </summary>
        /// <param name="couleur"></param>
        /// <param name="valeur"></param>
        public Carte(Valeur valeur = Valeur.As, Couleur couleur = Couleur.Coeur)
        {
            CarteCouleur = couleur;
            CarteValeur = valeur;
            Retourne = false;

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
            Name = this.ToString();
            Size = new Size(209, 303);
            Image = new Bitmap(Properties.Resources.ResourceManager.GetObject(ToString()) as Image, Size);
        }
        /// <summary>
        /// Nous permet de changer l'état Retourner d'une carte ainsi que son image
        /// </summary>
        public void Retourner()
        {
            Retourne = !Retourne;
            if (Retourne)
            {
                Image = new Bitmap(Properties.Resources.dos as Image, Size);
            }
            else
            {
                Image = new Bitmap(Properties.Resources.ResourceManager.GetObject(ToString()) as Image, Size);
            }
        }
        /// <summary>
        /// Nous retourne le nom d'une carte sous le format: _AsPique, _DeuxPique etc.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("_{0}{1}", CarteValeur, CarteCouleur);
        }
    }
}

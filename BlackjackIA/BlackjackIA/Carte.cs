using System;
using System.Collections.Generic;
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
    }
}

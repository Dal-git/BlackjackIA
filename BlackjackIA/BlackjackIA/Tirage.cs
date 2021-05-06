using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackIA
{
    class Tirage
    {
        int _valeurMainJoueur;
        int _valeurMainCroupier;

        public Tirage(int valeurMainJoueur, int valeurMainCroupier)
        {
            ValeurMainCroupier = valeurMainCroupier;
            ValeurMainJoueur = valeurMainJoueur;
        }

        public int ValeurMainJoueur { get => _valeurMainJoueur; set => _valeurMainJoueur = value; }
        public int ValeurMainCroupier { get => _valeurMainCroupier; set => _valeurMainCroupier = value; }
    }
}

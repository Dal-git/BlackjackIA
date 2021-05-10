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
* Fichier : Tirage.cs
*
* Description : 
*/
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

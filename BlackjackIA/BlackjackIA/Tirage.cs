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
* Fichier : Tirage.cs
*
* Description : Nous créé un objet contenant la valeur des mains des 2 joueurs pour pouvoir les utiliser comme clé de notre tableau concernant la pioche des cartes
*/

namespace BlackjackIA
{
    class Tirage
    {
        #region Variables
        int _valeurMainJoueur;
        int _valeurMainCroupier;
        public int ValeurMainJoueur { get => _valeurMainJoueur; set => _valeurMainJoueur = value; }
        public int ValeurMainCroupier { get => _valeurMainCroupier; set => _valeurMainCroupier = value; }
        #endregion

        /// <summary>
        /// Récupère la valeur des mains des 2 joueurs et nous en fait un objet
        /// </summary>
        /// <param name="valeurMainJoueur"></param>
        /// <param name="valeurMainCroupier"></param>
        public Tirage(int valeurMainJoueur, int valeurMainCroupier)
        {
            ValeurMainCroupier = valeurMainCroupier;
            ValeurMainJoueur = valeurMainJoueur;
        }
    }
}

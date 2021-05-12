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
* Description : Jeu de blackjack développé dans le cadre du TPI de fin de CFC à l'école d'informatique de Genève.
* 
* L'application permet au joueur de jouer au Blackjack contre un ordinateur et d'être conseillé sur la pioche des cartes.
*
* Fichier : Croupier.cs
*
* Description : Créé le croupier de la partie qui serra controller par l'ordinateur
*/

using System.Windows.Forms;

namespace BlackjackIA
{
    class Croupier : Joueur
    {
        /// <summary>
        /// Créé un Croupier avec le constucteur de Jouer dont il hérite
        /// </summary>
        /// <param name="gbx"></param>
        public Croupier(GroupBox gbx) : base("Croupier", gbx)
        {

        }
        /// <summary>
        /// Dans les règles du Blackjack le croupier cache toujours la deuxieme carte qu'il pioche
        /// C'est ce que fait cette methode
        /// </summary>
        public void CacherSecondeCarte()
        {
            Main[1].Retourner();
        }
    }
}

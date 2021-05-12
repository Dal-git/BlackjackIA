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
* Fichier : Paquet.cs
*
* Description : Créé un paquet de 52 cartes qui pourra être mélanger
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackIA
{
    class Paquet
    {
        #region Variables
        private List<Carte> _paquet = new List<Carte>();
        internal List<Carte> PaquetDuJeu { get => _paquet; set => _paquet = value; }
        #endregion

        /// <summary>
        /// Créé un paquet de carte avec le nombre de paquet qu'il contiendra (combien de fois 52 cartes le paquet contient)
        /// </summary>
        /// <param name="nombreDePaquet">Le nombre de fois 52 cartes l'on veut</param>
        public Paquet(int nombreDePaquet)
        {
            for (int i = 0; i < nombreDePaquet; i++)
            {
                foreach (Carte.Couleur couleur in (Carte.Couleur[])Enum.GetValues(typeof(Carte.Couleur)))
                {
                    foreach (Carte.Valeur valeur in (Carte.Valeur[])Enum.GetValues(typeof(Carte.Valeur)))
                    {
                        Carte carte = new Carte(valeur, couleur);
                        PaquetDuJeu.Add(carte);
                    }
                }
            }
        }

        /// <summary>
        /// Mélange notre paquet en les ordonant dans un ordre aléatoire
        /// </summary>
        /// <param name="random">Notre variable d'aléatoire</param>
        public void Melanger(Random random)
        {
            PaquetDuJeu = PaquetDuJeu.OrderBy(x => random.Next()).ToList();
        }
    }
}

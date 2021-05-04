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
* Fichier : Carte.cs
*
* Description : Cette classe permet de créer les cartes pour le jeu. Elle hérite de la classe PictureBox pour rendre leur création plus simple et cohérente.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackIA
{
    class Paquet
    {
        private List<Carte> _paquet = new List<Carte>();

        internal List<Carte> PaquetDuJeu { get => _paquet; set => _paquet = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreDePaquet"></param>
        public Paquet(int nombreDePaquet)
        {
            for (int i = 0; i < nombreDePaquet; i++)
            {
                foreach (Carte.Couleur couleur in (Carte.Couleur[])Enum.GetValues(typeof(Carte.Couleur)))
                {
                    foreach (Carte.Valeur valeur in (Carte.Valeur[])Enum.GetValues(typeof(Carte.Valeur)))
                    {
                        Carte carte = new Carte(couleur, valeur);
                        PaquetDuJeu.Add(carte);
                    }
                }
            }
        }        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="random"></param>
        public void Melanger(Random random)
        {
            PaquetDuJeu = PaquetDuJeu.OrderBy(x => random.Next()).ToList();
        }
    }
}

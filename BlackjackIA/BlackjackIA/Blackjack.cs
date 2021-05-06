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
* Fichier : Blackjack.cs
*
* Description : 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackIA
{
    class Blackjack
    {
        private Joueur joueur;
        private Croupier _croupier;
        private Paquet _paquet;
        private Form form;
        private Random random;
        private string _etatPartie;

        internal Paquet Paquet { get => _paquet; set => _paquet = value; }
        internal Joueur Joueur { get => joueur; set => joueur = value; }
        public Form Form { get => form; set => form = value; }
        public Random Random { get => random; set => random = value; }
        internal Croupier Croupier { get => _croupier; set => _croupier = value; }
        public string EtatPartie { get => _etatPartie; set => _etatPartie = value; }

        public Blackjack(Joueur joueur, Paquet paquetUtilise, Form form, Random random)
        {
            Joueur = joueur;
            Paquet = paquetUtilise;
            Form = form;
            Random = random;

            Croupier = new Croupier(form.Controls.Find("gbx_Croupier", false)[0] as GroupBox);
        }

        public void Distribution()
        {
            joueur.Piocher(Paquet, 2, Random);
            Croupier.Piocher(Paquet, 2, Random);
            Croupier.CacherSecondeCarte();
            Joueur.AfficherMain(form.Controls.Find("gbx_Joueur", false)[0] as GroupBox);
        }

        public void Comparaison()
        {
            if (EtatPartie == null)
            {
                if (joueur.ValeurDeLaMain <= 21)
                {
                    if (Croupier.ValeurDeLaMain <= 21)
                    {
                        if (joueur.ValeurDeLaMain > Croupier.ValeurDeLaMain)
                        {
                            EtatPartie = "Joueur gagne";
                        }
                        else if (joueur.ValeurDeLaMain < Croupier.ValeurDeLaMain)
                        {
                            EtatPartie = "Croupier gagne";
                        }
                        else
                        {
                            EtatPartie = "Egalite";
                        }
                    }
                    else
                    {
                        EtatPartie = "Croupier dépasse 21";
                    }
                }
                else
                {
                    EtatPartie = "Joueur dépasse 21";
                }
            }            
        }

        public void CroupierPiocheJusqua17()
        {
            while (Croupier.ValeurDeLaMain < 17)
            {
                Croupier.Piocher(Paquet, 1, random);
            }
        }
    }
}

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
* Fichier : Joueur.cs
*
* Description : 
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BlackjackIA
{
    class Joueur
    {
        private List<Carte> main = new List<Carte>();
        private string nomDuJoueur;
        private int valeurDeLaMain;
        private GroupBox _gbxMainJoueur;

        internal List<Carte> Main { get => main; set => main = value; }
        public string NomDuJoueur { get => nomDuJoueur; set => nomDuJoueur = value; }
        public int ValeurDeLaMain { get => valeurDeLaMain; set => valeurDeLaMain = value; }
        public GroupBox GbxMainJoueur { get => _gbxMainJoueur; set => _gbxMainJoueur = value; }

        public Joueur(string nom, GroupBox gbx)
        {
            NomDuJoueur = nom;
            GbxMainJoueur = gbx;
            ValeurDeLaMain = 0;
        }
        public void Piocher(Paquet paquet, int nombreDeCarteAPiocher, Random random)
        {
            if (ValeurDeLaMain < 21)
            {
                for (int i = 0; i < nombreDeCarteAPiocher; i++)
                {
                    int indexCarteATirer = random.Next(0, paquet.PaquetDuJeu.Count);
                    Carte cartePioche = paquet.PaquetDuJeu[indexCarteATirer];
                    Main.Add(cartePioche);
                    paquet.PaquetDuJeu.RemoveAt(indexCarteATirer);
                    ValeurDeLaMain += cartePioche.ValeurDansJeu;
                }
                TestChangementValeurAs();
                AfficherMain(GbxMainJoueur);
            }
        }

        public void AfficherMain(GroupBox gbx)
        {
            foreach (Carte carte in Main)
            {
                if (carte.Retourne)
                {
                    carte.Retourner();
                }
                carte.Location = new Point(6 + main.IndexOf(carte) * 210, 15);
                gbx.Controls.Add(carte);
            }
        }

        public void TestChangementValeurAs()
        {
            if (valeurDeLaMain > 21 && Main.Where(x => x.CarteValeur == Carte.Valeur.As && x.ValeurDansJeu == 11).ToArray().Count() != 0)
            {
                Main.Where(x => x.CarteValeur == Carte.Valeur.As && x.ValeurDansJeu == 11).ToArray()[0].ValeurDansJeu = 1;
                valeurDeLaMain = 0;
                foreach (Carte carte in Main)
                {
                    valeurDeLaMain += carte.ValeurDansJeu;
                }
            }
        }

        public void CalculerValeurDeLaMain()
        {
            valeurDeLaMain = 0;
            foreach (Carte carte in Main)
            {
                ValeurDeLaMain += carte.ValeurDansJeu;
            }
        }
    }
}

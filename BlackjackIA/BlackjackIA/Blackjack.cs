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
* Fichier : Blackjack.cs
*
* Description : Est la classe qui implémente le déroulement et les règles du jeu
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BlackjackIA
{
    class Blackjack
    {
        #region Variables
        private Joueur _joueur;
        private Croupier _croupier;
        private Paquet _paquet;
        private Form _form;       
        private string _etatPartie;
        Dictionary<Tirage, bool> _strategie = new Dictionary<Tirage, bool>();       
        Dictionary<Carte.Valeur, double> _probaTirageCarte = new Dictionary<Carte.Valeur, double>();

        internal Paquet Paquet { get => _paquet; set => _paquet = value; }
        internal Joueur Joueur { get => _joueur; set => _joueur = value; }
        public Form Form { get => _form; set => _form = value; }        
        internal Croupier Croupier { get => _croupier; set => _croupier = value; }
        public string EtatPartie { get => _etatPartie; set => _etatPartie = value; }
        internal Dictionary<Tirage, bool> Strategie { get => _strategie; set => _strategie = value; }        
        public Dictionary<Carte.Valeur, double> ProbaTirageCarte { get => _probaTirageCarte; set => _probaTirageCarte = value; }
        #endregion

        /// <summary>
        /// Construit notre jeu avec le joueur, le paquet, la form où tous serra affiché, et une variables aléatoire pour mélanger le paquet
        /// Le constructeur nous construit aussi le tableau pour savoir si l'on doit pioché
        /// </summary>
        /// <param name="joueur">Récupère les informations du joueur</param>
        /// <param name="paquetUtilise">Récupère le paquet que l'on utilisera</param>
        /// <param name="form">Récupère l'affichage où tous serra montrer</param>
        /// <param name="random">Nous sert a mélanger le paquet</param>
        public Blackjack(Joueur joueur, Paquet paquetUtilise, Form form, Random random)
        {
            Joueur = joueur;
            Paquet = paquetUtilise;
            Form = form;            

            Paquet.Melanger(random);

            //Créer un croupier avec un groupBox qui lui est associé
            Croupier = new Croupier(form.Controls.Find("gbx_Croupier", false)[0] as GroupBox);

            //Initialise le tableau de valeur pour savoir si on pioche
            for (int i = 2; i < 12; i++)
            {
                for (int j = 5; j < 22; j++)
                {
                    Tirage tirage = new Tirage(j, i);

                    if (j >= 17 || (j >= 13 && i <= 6) || (i >= 4 && i <= 6 && j == 12))
                    {
                        Strategie.Add(tirage, false);
                    }
                    else
                    {
                        Strategie.Add(tirage, true);
                    }
                }
            }
        }

        /// <summary>
        /// Gère le début d'une partie en distribuant a les mains
        /// </summary>
        public void Distribution()
        {
            Joueur.ValeurDeLaMain = 0;
            Croupier.ValeurDeLaMain = 0;
            Joueur.Main.Clear();
            Croupier.Main.Clear();
            Joueur.GbxMainJoueur.Controls.Clear();
            Croupier.GbxMainJoueur.Controls.Clear();
            Joueur.Piocher(Paquet, 2);
            Croupier.Piocher(Paquet, 2);            
            Croupier.CacherSecondeCarte();
        }

        /// <summary>
        /// Regard qui est le vainqueur de la partie
        /// </summary>
        public void Comparaison()
        {
            if (EtatPartie == null)
            {
                if (Joueur.ValeurDeLaMain <= 21)
                {
                    if (Croupier.ValeurDeLaMain <= 21)
                    {
                        if (Joueur.ValeurDeLaMain > Croupier.ValeurDeLaMain)
                        {
                            EtatPartie = "Joueur gagne";
                        }
                        else if (Joueur.ValeurDeLaMain < Croupier.ValeurDeLaMain)
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

        /// <summary>
        /// Fait en sorte que le croupier pioche jusqu'a que sa main atteigne au moin 17
        /// </summary>
        public void CroupierPiocheJusqua17()
        {
            while (Croupier.ValeurDeLaMain < 17)
            {
                Croupier.Piocher(Paquet, 1);
            }
        }

        /// <summary>
        /// Compte le pourcentage de chance l'on a de pioché une certaine carte
        /// </summary>
        public void CompterProbaTirageCarte()
        {
            _probaTirageCarte.Clear();
            foreach (Carte.Valeur valeur in (Carte.Valeur[])Enum.GetValues(typeof(Carte.Valeur)))
            {
                double nbrCarte = 0;
                foreach (var carte in Paquet.PaquetDuJeu)
                {
                    if (carte.CarteValeur == valeur)
                    {
                        nbrCarte++;
                    }
                }
                double proba = Math.Round(nbrCarte / Paquet.PaquetDuJeu.Count(), 3) * 100;
                ProbaTirageCarte.Add(valeur, proba);
            }
        }
    }
}

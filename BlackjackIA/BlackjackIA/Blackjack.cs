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
        private Label _labelCarteRestantes;

        internal Paquet Paquet { get => _paquet; set => _paquet = value; }
        internal Joueur Joueur { get => joueur; set => joueur = value; }
        public Form Form { get => form; set => form = value; }
        public Random Random { get => random; set => random = value; }
        public Label LabelCarteRestantes { get => _labelCarteRestantes; set => _labelCarteRestantes = value; }
        internal Croupier Croupier { get => _croupier; set => _croupier = value; }

        public Blackjack(Joueur joueur, Paquet paquetUtilise, Form form, Random random)
        {
            Joueur = joueur;
            Paquet = paquetUtilise;
            Form = form;
            Random = random;

            LabelCarteRestantes = form.Controls.Find("lbl_CartesRestantes", false)[0] as Label;
            Croupier = new Croupier(form.Controls.Find("gbx_Croupier", false)[0] as GroupBox);
        }

        public void Jouer()
        {
            joueur.Piocher(Paquet, 2, Random);
            Croupier.Piocher(Paquet, 2, Random);
            Croupier.CacherSecondeCarte();
            LabelCarteRestantes.Text = Paquet.PaquetDuJeu.Count.ToString();
            Joueur.AfficherMain(form.Controls.Find("gbx_Joueur", false)[0] as GroupBox);
        }
    }
}

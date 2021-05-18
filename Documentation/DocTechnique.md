[TOC]



# <span style='color:blue'>1. Introduction</span>

Ce projet a été réalisé dans le cadre de mon TPI (Travail pratique individuel) de fin de scolarité au CFPT-Informatique en 2021. Il a pour but de confirmer les compétences que j'y aie acquis lors de ces trois années.

Ce document est le manuel technique de l'application. Il y contient une analyse fonctionnelle et organique ainsi qu'un plan, un rapport de tests et le planning effectif.

# <span style='color:blue'>2. Méthodologie</span>

J’ai choisi pour ce travail d’utiliser la méthodologie de type « WaterFall ». Celle-ci consiste à diviser le
projet en plusieurs étapes afin de pouvoir facilité la planification et le développement. Cette
méthode consiste en 6 étapes qu’il faut effectuer à la suite les unes des autres, la dernière n’étant
pas utilisée dans le cadre de ce projet :

- Exigences (analyse du cahier des charges)
- Conception
- Planning échéancier
- Mise en œuvre, développement
- Vérification
- (Maintenance)

# <span style='color:blue'>3. Résumé du cahier des charges</span>

## 3.1 But de l'application

Permettre a un utilisateur de jouer au Blackjack avec les règles de base (21 et As) et sans mise.
Pour aider le joueur a savoir si il doit piocher ou pas, un conseillé sera là pour l'aiguillé. Le conseillé lui affichera aussi les statistiques d'avoir un tirer gagnant.

## 3.2 But du jeu

"*Après avoir reçu deux cartes, le joueur tire des cartes pour s’approcher de la valeur 21 sans la dépasser. Le but du joueur est de battre le croupier en obtenant un total de points supérieur à celui-ci ou en voyant ce dernier dépasser 21. Chaque joueur joue contre le croupier, qui représente la banque, ou le casino, et non contre les autres joueurs.*"

Règles par [guide blackjack](https://www.guide-blackjack.com/regles-du-black-jack.html)

## 3.3 Fonctionnalités à réaliser

En plus de pouvoir joué au Blackjack contre un croupier, l'application nous permet d'être conseillé sur la pioche des cartes ainsi que de voir les probabilités que l'on a de pioché une certaine carte ou d'avoir une certaine valeur totale dans la main après la pioche. Elle nous permet aussi de choisir le nombre de paquet avec lequel on vas jouer.

## 3.4 Matériel et logiciels nécessaires

- Ordinateur
- Une IDE prenant en charge le C# en l'occurrence VisualStudio 2019
- GitHub Desktop

## 3.5 Livrables

- Planning réel (déjà fourni par les experts)
- Rapport de projet
- Résumé du rapport du TPI
- Journal de travail
- Un lien github pour accéder aux sources du TPI

# <span style='color:blue'>4. Analyse fonctionnelle</span>

Cette section de la documentation traite de la partie visible de l’application, vue par l’utilisateur final.
Tout d’abord, sont énumérées les fonctionnalités disponibles dans l’application. Ensuite viennent les
présentations des fenêtres de l’interface utilisateur.

## 4.1 Liste des fonctionnalités

Voici la liste des actions possibles par l'utilisateur :

- Choisir son nom

- Choisir le nombre de paquet avec lesquels on vas jouer
- Piocher une carte
- Rester

## 4.2 Présentation de l'interface

L'interface utilisateur comprend au total 2 formulaires WindowsForms. La première sert a choisir le nom du joueur ainsi que le nombre de paquet que l'on vas utiliser pour la partie. La seconde est celle ou la partie ce déroulera avec l'affichage des mains du croupier et du joueur, des boutons pour piocher ou rester ainsi que les statistiques de pioche.

### 4.2.1 Les images

![C65apture](C:\Users\dallas.ctllz\Desktop\C65apture.PNG)

Les cartes ainsi que l'icone de l'application ont été récupéré sur [commons.wikimedia](https://commons.wikimedia.org/wiki/Category:Playing_cards_set_by_Byron_Knoll).
Pour le dos des cartes l'images à été trouvé sur Google Images et peut être retrouver a [cette adresse](https://www.pinterest.com/pin/105130972527979556/).

A la base toutes les images de carte étaient des SVG (Scalable Vector Graphics), mais ne savant pas comment les utiliser en C# et après quelques recherche, l'implémentation me paraissait complexe et être une perte de temps. Je les ai donc toutes converti en png.

### 4.2.2 La vue paramètre

La vue paramètre est un formulaire ou l'on choisit notre nom ainsi que le nombre de paquet avec lesquels on vas joué. 

C'est infos seront utilisé pour créer la vue principale.

![49489484454Capture](C:\Users\dallas.ctllz\Desktop\49489484454Capture.PNG)

Si le nom est vide ou uniquement composé d'espace on ne pourra pas appuyé sur ok

### 4.2.3 La vue principale

![9654pture](C:\Users\dallas.ctllz\Desktop\9654pture.PNG)

C'est sur cette vue que le jeu se déroule. On peut y retrouver la main du joueur et du croupier ainsi que les boutons pour jouer qui changeront de couleur en fonction des conseils donné. Conseils basé sur le tableau suivant que l'on peut retrouver a [cette adresse](https://www.guide-blackjack.com/strategie-de-base-six-jeux-de.html).

![asdbasidbaidbiias](C:\Users\dallas.ctllz\Desktop\asdbasidbaidbiias.PNG)

Comme l'application ne permet pas de miser des sommes les conditions ou il faut doubler sont remplacer par des simples tirage

Le joueur a juste besoin de choisir ce qu'il veut faire, le reste est géré automatiquement par l'application. Le résultat de la partie serra affiché dans un label au dessus des boutons.

ex:![666Capture](C:\Users\dallas.ctllz\Desktop\666Capture.PNG)

A chaque fois qu'une carte est pioché les statistiques sont mise a jours.

# <span style='color:blue'>5. Analyse organique</span>

Cette partie de la documentation décrit le fonctionnement interne de l'application. Il y serra listé les actions effectuées par l'application en background. Les actions du programme sont listé dans l'ordre d'exécution dans le cas d'une partie standard. Chaque classe de l'application y serra aussi détaillé.

## 5.1 Actions du programme

- Passer les paramètre de la vue paramètre au programme
- Créer un joueur avec le nom entré en paramètre
- Créer un paquet de carte avec le paramètre reçu 
   - Créer 52 cartes * le nombre de paquet voulu
- Création du jeu avec le joueur, le paquet, la vue et une variable aléatoire
- Distribution des cartes
- Mise a jour de l'affichage
- Changement de couleurs des boutons
- Le joueur clique sur le bouton "Piocher"/"Rester"
- Le croupier pioche jusqu'à 17
- Comparaison des mains



## 5.2 Description des classes et méthodes

Cette section traitera du fonctionnement de toute les fonctions utilisé dans le programme.

## 5.2.1 Classe Joueur

### Constructeur

Le joueur est créé avec comme paramètres un nom et un groupBox qui représentera sa main.

### Méthode Piocher

Le joueur peut piocher un nombre de carte voulu d'un paquet passé en paramètre. Pour ce faire il choisi la première carte du paquet l'ajoute a sa main et la retire du paquet. Puis il ajoute la valeur de la carte a la valeur totale de sa main.

Elle fera appelle a la méthode TestChangementValeurAs pour savoir si il peut passer la valeur d'un As a 1 pour ne pas dépasser 21.

Pour finir elle fera appelle a la méthode AfficherMain pour ajouter la nouvelle carte au groupBox.

### Méthode AfficherMain

Elle récupère toutes les cartes de la main, test si elles doivent être retourné si oui elle les retourne puis elle les ajoute au groupBox avec une position déterminer par leur index.

### Méthode TestChangementValeurAs

Test si la valeur de notre main est >21 et qu'il y a bien un As avec comme valeur 11 dans la main. Si c'est le cas alors elle change la valeur du premier As dans notre main pour 1 puis elle recompte la valeur totale de notre main avec la méthode CalculerValeurDeLaMain.

### Méthode CalculerValeurDeLaMain

Récupère toutes les valeurs des cartes dans la mains et les additionnes. 

## 5.2.2 Classe Croupier : Joueur

### Constructeur

Prend un groupbox comme paramètre qui sera la main du croupier et utilise le constructeur de joueur en donnant comme nom "Croupier" et comme groupbox celui actuellement en paramètres.

### Méthode CacherSecondeCarte

récupère la deuxième carte de la main du croupier et utilise la méthode Retourner dessus

## 5.2.3 Classe Carte : Picturebox

### Constructeur

Il prend comme paramètre une valeur de l'Enum Valeur (As, 2, 3 ...) ainsi qu'une couleur de l'Enum Couleur (Coeur, Carreau ...). Puis il lui attribue sa valeur dans le jeu par rapport a son nom.

```c#
witch (valeur)
            {
                case Valeur.Deux:
                case Valeur.Trois:
                case Valeur.Quatre:
                case Valeur.Cinq:
                case Valeur.Six:
                case Valeur.Sept:
                case Valeur.Huit:
                case Valeur.Neuf:
                case Valeur.Dix:
                    ValeurDansJeu = (int)valeur + 2;
                    break;
                case Valeur.Valet:
                case Valeur.Dame:
                case Valeur.Roi:
                    ValeurDansJeu = 10;
                    break;
                case Valeur.As:
                    ValeurDansJeu = 11;
                    break;
            }
```

Comme l'objet est hérité de la classe Picturebox je lui donne aussi un name composé du toString de l'objet ainsi qu'une taille et une image dont le nom correspond au toString.

### Méthode Retourner

Inverse la valeur du bool Retourne et test sa valeur et change l'image par rapport au résultat obtenu.

### Méthode ToString

Nous retourne l'objet sous la forme suivante : 

```c#
return string.Format("_{0}{1}", CarteValeur, CarteCouleur);
```

## 5.2.4 Classe Paquet

###  Constructeur

Il prend en paramètre le nombre de paquet avec lesquels on veut jouer puis il nous répète la création de paquet ce nombre de fois. 

Pour créer un paquet on parcours les enum de couleur et de valeur et pour chaque combinaison on créé une carte correspondante puis on l'ajoute a une liste.

### Méthode Mélanger 

```c#
 PaquetDuJeu = PaquetDuJeu.OrderBy(x => random.Next()).ToList();
```

On tri la liste de manière aléatoire.

  ## 5.2.5 Classe Tirage

### Constructeur

Prend comme paramètre la valeur de la main du joueur et la valeur de la main du croupier.

Cette classe sert a stocker des données pour pouvoir par la suite les utilisés comme key d'un dictionnaire. 

## 5.2.6 Classe BlackjackIA

### Constructeur

Prend comme paramètres un joueur, un paquet, une Form, et un Random.

Le constructeur mélangera le paquet directement le deck. Il créera le croupier et initialisera le tableau de probabilités sur lequel le conseiller se basera.

 ![asdbasidbaidbiias](C:\Users\dallas.ctllz\Desktop\asdbasidbaidbiias.PNG)

Pour créer ce tableau il parcours une boucle de 2 a 11 et une autre de 5 a 21.

Pour chacune des combinaisons il créer un objet Tirage et si la valeur du joueur est supérieur a 17, ou que la valeur du joueur est supérieur ou égal a 13 et que c'elle du croupier est inférieur ou égal a 6, ou que la valeur du croupier est compris entre 4 et 6  et que la valeur du joueur est égal a 12 alors la valeur dans notre dictionnaire pour la clé Tirage serra égal a false, sinon elle sera true.

### Méthode Distribution

Distribue au joueur et au croupier 2 cartes.

Puis il affiche la main du joueur et cache la seconde carte du croupier.

### Méthode Comparaison

Effectue une série de test pour savoir si le joueur ou le croupier on une main trop grosse et si aucun des deux n'est au dessus de 21 alors on détermine qui a la main la plus grande.

### Méthode CroupierPiocheJusqua17

Parcours une boucle while qui tant que la main du joueur ne dépasse pas 17 fera pioche une carte au croupier.

### Méthode CompterProbaTirageCarte

```c#
			probaTirageCarte.Clear();
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
```

Vide la liste des probabilités d'avoir une certaine carte puis la re-rempli.

# <span style='color:blue'>6. Fonctionnalités restantes a implémenter et améliorations possibles</span>

Concernant les possibles améliorations de l'application plusieurs point peuvent être aborder :

- Ajouter le système de mise
- Ajouter la règle du Blackjack (As + Face a la distribution)
- Possibilité de splitter/ partager sa main
- Possibilité de doubler sa mise
- Intégrer le système d'assurance
- Intégrer le système d'abandon

# <span style='color:blue'>7. Réalisation</span>

## 7.1 Arborescence du projet

Le programme se trouve dans une solution qui continent un seul projet. Ce projet contient en tout 2 vues et 7 classes.

Voici un aperçu de l’arborescence du projet : 

![5Capture](C:\Users\dallas.ctllz\Desktop\5Capture.PNG)

## 7.2 Diagramme de classe



![68979](C:\Users\dallas.ctllz\Desktop\68979.PNG)

## 7.3 Plan de test

| N°   | Description du test                                          | Résultat attendu                                             | OK/NOT |
| ---- | ------------------------------------------------------------ | ------------------------------------------------------------ | ------ |
| 1    | Lancer l'application                                         | La vue paramètres est affiché                                | OK     |
| 2    | Entrer un nom dans la tbx de la vue paramètres               | Le bouton ok est activé                                      | OK     |
| 3    | Appui sur le bouton OK de la vue paramètres                  | Les données du formulaire sont transmise a la vue principale | OK     |
| 4    | La vue principale affiche le nom du joueur choisi au préalable | Le nom affiché correspond a celui entré                      | OK     |
| 5    | Le nombre de paquet choisi est utilisé pour créer le paquet avec lequel nous allons joué | Le nombre de paquet correspond a celui entré et le nombre de cartes restantes correspond bien au nombre de paquet*52-4 | OK     |
| 6    | Les boutons nous conseil ce qu'il faut faire par rapport a la situation | Par rapport aux valeurs des mains le conseil correspond a ce qui est conseillé dans le tableau | OK     |
| 7    |                                                              |                                                              |        |
| 8    |                                                              |                                                              |        |
| 9    |                                                              |                                                              |        |


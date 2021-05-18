# <span style='color:blue'>Introduction</span>

Ce projet a été réalisé dans le cadre de mon TPI (Travail pratique individuel) de fin de scolarité au CFPT-Informatique en 2021. Il a pour but de confirmer les compétences que j'y aie acquis lors de ces trois années.

Ce document est le manuel technique de l'application. Il y contient une analyse fonctionnelle et organique ainsi qu'un plan, un rapport de tests et le planning effectif.

# <span style='color:blue'>Méthodologie</span>

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

# <span style='color:blue'>Résumé du cahier des charges</span>

## But de l'application

Permettre a un utilisateur de jouer au Blackjack avec les règles de base (21 et As) et sans mise.
Pour aider le joueur a savoir si il doit piocher ou pas, un conseillé sera là pour l'aiguillé. Le conseillé lui affichera aussi les statistiques d'avoir un tirer gagnant.

## But du jeu

"*Après avoir reçu deux cartes, le joueur tire des cartes pour s’approcher de la valeur 21 sans la dépasser. Le but du joueur est de battre le croupier en obtenant un total de points supérieur à celui-ci ou en voyant ce dernier dépasser 21. Chaque joueur joue contre le croupier, qui représente la banque, ou le casino, et non contre les autres joueurs.*"

Règles par [guide blackjack](https://www.guide-blackjack.com/regles-du-black-jack.html)

## Fonctionnalités à réaliser

En plus de pouvoir joué au Blackjack contre un croupier, l'application nous permet d'être conseillé sur la pioche des cartes ainsi que de voir les probabilités que l'on a de pioché une certaine carte ou d'avoir une certaine valeur totale dans la main après la pioche. Elle nous permet aussi de choisir le nombre de paquet avec lequel on vas jouer.

## Matériel et logiciels nécessaires

- Ordinateur
- Une IDE prenant en charge le C# en l'occurrence VisualStudio 2019
- GitHub Desktop

## Livrables

- Planning réel (déjà fourni par les experts)
- Rapport de projet
- Résumé du rapport du TPI
- Journal de travail
- Un lien github pour accéder aux sources du TPI

## Liste des fonctionnalités

Voici la liste des actions possibles par l'utilisateur :

- Choisir son nom

- Choisir le nombre de paquet avec lesquels on vas jouer
- Piocher une carte
- Rester

## Présentation de l'interface

L'interface utilisateur comprend au total 2 formulaires WindowsForms. La première sert a choisir le nom du joueur ainsi que le nombre de paquet que l'on vas utiliser pour la partie. La seconde est celle ou la partie ce déroulera avec l'affichage des mains du croupier et du joueur, des boutons pour piocher ou rester ainsi que les statistiques de pioche.

### Les images

![C65apture](C:\Users\dallas.ctllz\Desktop\C65apture.PNG)

Les cartes ainsi que l'icone de l'application ont été récupéré sur [commons.wikimedia](https://commons.wikimedia.org/wiki/Category:Playing_cards_set_by_Byron_Knoll).
Pour le dos des cartes l'images à été trouvé sur Google Images et peut être retrouver a [cette adresse](https://www.pinterest.com/pin/105130972527979556/).

A la base toutes les images de carte étaient des SVG (Scalable Vector Graphics), mais ne savant pas comment les utiliser en C# et après quelques recherche, l'implémentation me paraissait complexe et être une perte de temps. Je les ai donc toutes converti en png.

### La vue paramètre

La vue paramètre est un formulaire ou l'on choisit notre nom ainsi que le nombre de paquet avec lesquels on vas joué.

[A FAIRE]

### La vue principale

![9654pture](C:\Users\dallas.ctllz\Desktop\9654pture.PNG)

C'est sur cette vue que le jeu se déroule. On peut y retrouver la main du joueur et du croupier ainsi que les boutons pour jouer qui changeront de couleur en fonction des conseils donné. Conseils basé sur le tableau suivant que l'on peut retrouver a [cette adresse](https://www.guide-blackjack.com/strategie-de-base-six-jeux-de.html).

![asdbasidbaidbiias](C:\Users\dallas.ctllz\Desktop\asdbasidbaidbiias.PNG)

A part choisir ce qu'il veut faire le joueur n'a rien d'autre a faire, le reste est géré par l'application. Le résultat de la partie serra affiché dans un label au dessus des boutons.

A chaque fois qu'une carte est pioché les statistiques sont mise a jours.

# <span style='color:blue'>Analyse Organique</span>

Cette partie de la documentation décrit le fonctionnement interne de l'application. Il y serra listé les actions effectuées par l'application en background. Les actions du programme sont listé dans l'ordre d'exécution dans le cas d'une partie standard. Chaque classe de l'application y serra aussi détaillé.

## Actions du programme

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

## Classe Joueur

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

## Classe Carte : Picturebox

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

## Classe Paquet


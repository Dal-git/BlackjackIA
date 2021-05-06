# Journal de bord
## Lundi 03.05
### Matin

J'ai pris connaissance de mon énoncé de TPI et vais effectuer un découpage en sous-tâche de mon projet. 
J'ai créé le [github](https://github.com/Dal-git/BlackjackIA) de mon projet.

(résolu)[Une seule chose dans l'énoncé me semble confuse : "L’IA devant s’ajuster automatiquement.".] 
-> j'ai demandé a M. Bonvin et cela voudrait dire que l'IA prend en compte le nombre de paquet choisi.

J'ai avancé dans la doc. tech. une partie du Product Backlog.
Je fais un premier jet de ce que pourrait être mon modèle de classe. Je n'ai pas encore fais le modèle pour le conseiller, je le ferai quand j'aurai déjà programmé la carte, le paquet et le joueur.

![permierDiagrame](C:\Users\dallas.ctllz\Desktop\permierDiagrame.png)

Je vais déjà téléchargé les ressource nécessaire au projet , les 52 cartes.
Je vais aussi effectué une maquette de l'application.

![maquette](C:\Users\dallas.ctllz\Desktop\maquette.PNG)

### Aprèm

Je vais commencer le projet par la classe carte et paquet. Je ferai en même temps la partie graphique du programme.

Les images imposés pour les cartes sont des SVG, ne sachant pas comment les utiliser en WF je vais les convertir en png.

J'ai terminé la partie graphique du programme.

## Mardi 04.05

###  Matin

J'ai renommé toutes mes cartes pour pouvoir les utiliser avec des Enum.

J'ai terminé la classe carte ainsi que la classe paquet et joueur.

Je commence la classe Blackjack.

### Aprèm

 Je continue la class Blackjack.

Création de la classe hérité de Joueur, Croupier,

## Mercredi 05.05

### Matin

A la journée d'information militaire

### Aprèm

Pour l'instant le jeu nous indique combien de carte ont été joué, combien il en reste, la valeur des mains, piocher une carte et cacher la seconde carte du croupier.

Le jeu nous empêche aussi de pioche si notre main dépasse ou est égal a 21.

Mais il ne permet pas encore de changer les As de valeur, donc je vais le faire maintenant.

Je pense tout simplement dire que si la valeur de la main est >21 alors le premier As dans la main changera sa valeur pour 1.

J'ai réussi a changer la valeur pour les As si la main est >21 en utilisant principalement la méthode Where. J'ai simplement demandé que si la main est >21 et qu'il y a une carte As avec comme valeur 11 dans la main de changer sa valeur a 1 et de recompter la main.

Maintenant je vais vérifier l'état de la partie avec des test simples pour savoir qui gagne.

## Jeudi 06.05

### Matin

Je continue de programmer la fin de la partie.

J'ai pu terminer les conditions de victoire pour le joueur et le croupier, je vais débuter la programmation de l'assistant. J'ai aussi ajuster le calcule de l'affichage des cartes restantes, avant il devait compter toutes les cartes dans le deck mais maintenant il se contente de faire 52 - le nombre de carte jouées.

Je pense que l'assistant devra être implémenter sous forme de Controller attaché au Joueur.


# Journal de bord
## Lundi 03.05
### Matin

J'ai pris connaissance de mon énoncé de TPI et vais effectuer un découpage en sous-tâche de mon projet. 
J'ai créé le [github](https://github.com/Dal-git/BlackjackIA) de mon projet.

(résolu)[Une seule chose dans l'énoncé me semble confuse : "L’IA devant s’ajuster automatiquement.".] 
-> j'ai demandé a M. Bonvin et cela voudrait dire que l'IA prend en compte le nombre de paquet choisi.

J'ai avancé dans la doc. tech.
Je fais un premier jet de ce que pourrait être mon modèle de classe. Je n'ai pas encore fais le modèle pour le conseiller, je le ferai quand j'aurai déjà programmé la carte, le paquet et le joueur.

![ztuzg](C:\Users\dallas.ctllz\Desktop\ztuzg.png)

Je vais déjà téléchargé les ressource nécessaire au projet , les 52 cartes.
Je vais aussi effectué une maquette de l'application.

![maquette](C:\Users\dallas.ctllz\Desktop\maquette.PNG)

### Aprèm

Je vais commencer le projet par la classe carte et paquet. Je ferai en même temps la partie graphique du programme.

Les images imposés pour les cartes sont des SVG, ne sachant pas comment les utiliser en WF je vais les convertir en png.

J'ai terminé la partie graphique de la première form du programme.

## Mardi 04.05

###  Matin

J'ai renommé toutes mes cartes pour pouvoir les utiliser avec des Enum.

J'ai terminé la classe Carte ainsi que la classe Paquet et Joueur.

Je commence la classe Blackjack.

### Aprèm

 Je continue la class Blackjack.

Création de la classe hérité de Joueur: Croupier.

## Mercredi 05.05

### Matin

A la journée d'information militaire

### Aprèm

Pour l'instant le jeu nous indique combien de carte ont été joué, combien il en reste, la valeur des mains. Il nous permet aussi de piocher une carte et cacher la seconde carte du croupier.

Le jeu nous empêche aussi de pioche si notre main dépasse ou est égal a 21.

Mais il ne permet pas encore de changer les As de valeur, donc je vais le faire maintenant.

Je pense tout simplement dire que si la valeur de la main est >21 alors le premier As dans la main changera sa valeur pour 1.

J'ai réussi a changer la valeur pour les As si la main est >21 en utilisant principalement la méthode Where. 

J'ai simplement demandé que si la main est >21 et qu'il y a une carte As avec comme valeur 11 dans la main de changer sa valeur a 1 et de recompter la main.

Maintenant je vais vérifier l'état de la partie avec des test simples pour savoir qui gagne.

## Jeudi 06.05

### Matin

La fin d'une partie est terminé, pour l'instant nous avons juste un text pour nous dire qui gagne et il n'y a pas encore de manière de pouvoir rejouer sans relancer l'application.

Je continue de programmer la fin de la partie.

J'ai pu terminer les conditions de victoire pour le joueur et le croupier, je vais débuter la programmation de l'assistant. 

J'ai aussi ajuster le calcule de l'affichage des cartes restantes. Avant il devait compter toutes les cartes dans le deck mais maintenant il se contente de faire 52 - le nombre de carte jouées.

Je pense que l'assistant devra être implémenter sous forme de Controller attaché au Joueur.

### Aprèm

Finalement je n'ai pas besoin de faire de l'assistant un Controller je l'ai juste directement intégrer a ma classe Blackjack qui représente les règles et déroulement du jeu.

J'ai crée un Dictionnaire pour savoir quel conseil le conseiller doit nous donner avec comme clé un objet avec comme paramètre les valeurs des mains du jeu.

Malheureusement il semblerait que la valeur récupérer ne soit pas toujours la bonne.

## Lundi 10.05

### Matin

Je vais continuer ce que je faisais jeudi aprèm c'est a dire tester le conseillé et voir si son conseil est celui désiré.

Toute les valeur de notre tableau pour le conseillé semble être identique a celle de la première cellule de la même ligne.

On dirait que le test ne se fie qu'au première argument de notre test.

J'ai réussi a résoudre mon problème.

Il semblerait que mon ancien test ne testait que la première condition pour récupérer la valeur dans le dico.

##### Ancien test

```c#
blackjack.Strategie[blackjack.Strategie.Keys.Where(
x => x.ValeurMainCroupier == blackjack.Croupier.Main[0].ValeurDansJeu
).ToArray()[0]] 
&& 
blackjack.Strategie[blackjack.Strategie.Keys.Where(
x => x.ValeurMainJoueur == joueur.ValeurDeLaMain
).ToArray()[0]]
```

##### Nouveau test

```c#
blackjack.Strategie[blackjack.Strategie.Keys.Where(
x => x.ValeurMainCroupier == blackjack.Croupier.Main[0].ValeurDansJeu 
&&
x.ValeurMainJoueur == blackjack.Joueur.ValeurDeLaMain
).ToArray()[0]];
```



### Aprèm

Pour cette après midi je vais commencé a m'intéresser aux statistiques du jeu ce qui est mon dernier point a faire pour le code.

Je pense faire une deuxième form consacré aux détails des statistiques.

## Mardi 11.05

#### Matin

Ce matin je vais continué l'implémentation des statistiques.

J'ai réussi a afficher le pourcentage de chance que l'on avait de pioche une certaine carte.

#### Aprèm

Cette après midi je vais faire en sorte que les détails des statistiques s'affiche dans une autre form et qu'il n'y ait que les stats des valeurs possibles lors de la prochaine pioche dans la form principale.

Je me suis aussi rendu compte que mon ancien choix concernant le compte des cartes restants n'était pas bon car il ne fonctionnait que pour un paquet. Je suis donc retourner sur l'ancienne version avec le compte des cartes total du paquet.

## Mercredi 12.05

### Matin

Je vais commenté mon code et terminé les statistiques.

En commentant mon code je me suis rendu compte que pour pioché une carte je devais prendre un index aléatoire dans le paquet. Mais puisque le paquet se mélange avant et qu'une liste réincrémente ses index si un élément est enlevé, je n'avais qu'a dire que je prenais a chaque fois la première carte, ce qui semble plus logique.  

Je viens de terminé de commenté mon code, je vérifierais encore une fois avant la fin du projet si rien ne manque.

Je vais maintenant consacré le temps restant de cette journée a finaliser les stats.

Avant je dois régler un problème avec la deuxième form.

J'ai du régler le fait que la form secondaire était effacer après être fermer.

### Aprèm

Je vais avancer sur la documentation.

## Lundi 17.05

### Matin

J'avais oublié d'ajouter la vueParamètre ce que j'ai fait.

Cependant un problème avec la fermeture de la première form qui fermait l'application est apparu.

Heureusement grâce a [ce lien](https://stackoverflow.com/questions/10769193/how-do-i-prevent-the-app-from-terminating-when-i-close-the-startup-form) j'ai pu réglé mon problème.
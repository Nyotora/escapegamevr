# Escape game : VR

## Présentation
Nous avons décidé de nous lancer vers l’inconnu en choisissant l’option de découvrir la Réalité Virtuelle et d’essayer de faire une application fonctionnelle et pertinente pour la prochaine JPO (samedi 04 mars 2023).

De base nous devions adapter notre premier jeu afin de pouvoir y jouer avec un casque VR, mais nous nous sommes rendus compte que notre énigme sur les Bases de Données n’était pas du tout pertinente en VR : 

* Le jeu doit être court, pour ne pas que les gens se sentent mal, et pouvoir faire tester le jeu à un plus grand nombre de personnes, or, cette énigme est très longue.
* Nos précédentes énigmes demandaient de faire des actions qui seraient pénibles sans un clavier (taper un mot de passe, faire une requête SQL…).
* Le système d’IDE n’aurait pas été pratique à adapter en VR, nous avions pas assez de temps (délai de 20 jours).
* Le but est de faire passer un  bon petit moment aux testeurs, donc il faut que le jeu soit amusant et assez simple.

Nous avons donc décidé de créer un projet de zéro, et d’implémenter l’énigme la plus simple que nous avions imaginé auparavant dans notre scénario, celle sur la qualité de code !

## Contexte du jeu : 
Le joueur se retrouve enfermé dans la Salle R47 du département informatique et peut se déplacer librement dans celle-ci. Sur le tableau blanc est écrit le contexte et le but du jeu afin de guider le joueur :

![image](https://github.com/Nyotora/escapegamevr/assets/101416486/d5dea7a9-f921-46e9-9eea-be158a365195)
Extrait du jeu : tableau blanc censé guider le joueur.

Le joueur va donc devoir éliminer les code smells pour sortir de la salle. Celui-ci doit d’abord trouver le spray anti code smells placé dans la salle, puis ensuite s’en servir sur les code smells pour les faire disparaître.

## Liste des code smells

### Duplication de code
Nous nous sommes inspirés du meme populaire montrant 2 spidermans se pointant à tour de rôle du doigt, souvent utilisé pour parler de personnes qui s’accusent mutuellement. L’image du meme culte provient de l’épisode 19b du dessin animé de 1967, “Double Identity”. Les jeunes intéressés par l’informatique connaissent généralement ce meme, donc nous avons jugé cela pertinent de l’utiliser pour la duplication de code.

<div style="display: flex; justify-content: space-between;">
    <img src="https://github.com/Nyotora/escapegamevr/assets/101416486/32a891a6-8c29-4f60-a640-ad0c21e4a0b6" width="400">
    <img src="https://github.com/Nyotora/escapegamevr/assets/101416486/8e3aa454-0f6a-43e8-8212-809998b09d61" width="400">
</div>

### Magic number
Nous avons décidé de déguiser un nombre en magicien pour que ce soit parlant, et nous avons choisi une version simplifiée du nombre PI, c’est-à-dire 3,14.

![image](https://github.com/Nyotora/escapegamevr/assets/101416486/9b2a7bd7-9463-445d-ad83-ef3e29b91df4)

### Franglais
Quoi de mieux qu’un drapeau qui mixe un pays francophone et un pays anglophone pour représenter le franglais ? Nous n’avons pas trouvé mieux, et nous trouvons cette idée assez explicite :

![image](https://github.com/Nyotora/escapegamevr/assets/101416486/05aaef93-5318-4b74-a356-c6cf546f986a)

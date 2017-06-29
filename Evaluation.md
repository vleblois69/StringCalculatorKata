Evaluation finale du cours .NET à l'IUT Lyon 1
==============================================

Critères d'évaluation
---------------------

* Solution apportée aux problèmes posés dans le fichier Readme.md + réponses aux questions (à mettre dans le fichier ci-dessous)
* La qualité des commits : granularité fine et commentaires explicites du pourquoi (et non du quoi, i.e ne pas dire quels fichiers ont été modifiés, c'est inutile, Git le dit déjà)
* La qualité du code : utiliser un nommage correct + R# donne des règles à respecter, il suffit de les corriger
* Les tests unitaires : expressivité (le nommage tout particulièrement), granularité (i.e on teste une chose à la fois), rapidité (i.e instantané), couverture de code et indépendance (un test ne dépend pas des autres)
* Le design du code : utiliser les pratiques vues en cours pour éviter de faire du code difficilement maintenable et évolutif (SOLID...)

ATTENTION: ne pas changer le nommage des projets, des classes et méthodes donnés (sauf sur les tests si vous voulez).

A LA FIN DU TP: pensez à pousser vos commits sur votre compte GitHub et envoyer votre dépôt à mon adresse mail.

Réponses aux questions posées
-----------------------------

Q1) Pour éviter de faire des if / else on peut créer un dictionnaire dont les clés seraient les opérateurs (+,-,..) et les valeurs les fonctions à éxecuter. Il faut donc aussi créer une fonction par opération.

Q2) Le concept coeur de la programmation orienté objets utilisé ici est l'utilisation de classes contenant des données et des méthodes, plutot que de tout avoir dans une seule classe.

Q3) Le principe appliqué est celui de Responsabilité unique.

Q4) Le problème avec cette classe est que les opérations sont écrites en dures, il n'y a donc pas de souplesse, on voudrait pouvoir tester n'importe quelle opération.

Q5) Le principe appliqué ici est celui de Responsabilité unique.

Q6) Le principe appliqué est celui d'inversion de dépendances.
 

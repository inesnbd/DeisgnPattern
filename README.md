# DeisgnPattern
cours de design pattern dotnet 6 &amp; c#
# Les différents patterns : 

# Les patterns de conception

# 1. Abstract Factory :
Modèle de conception de création, qui résout le problème de la création de familles de produits entières sans spécifier leurs classes concrètes. Abstract Factory définit une interface pour créer tous les produits distincts, mais laisse la création du produit réel à des classes d'usine concrètes.

![uml_catalogue](https://user-images.githubusercontent.com/32362054/177935654-c5f33a9e-8c77-47ca-b4c2-b04a0034a5bc.png)

![uml2](https://user-images.githubusercontent.com/32362054/177935669-a842ea6e-856f-42d4-bb2e-94a9491876cc.png)

# 2. Builder
Le modèle de générateur est utilisé lorsqu'il y a une configuration complexe impliquée dans la création d'un objet. Il sépare la construction d'un objet de l'utilisation de l'objet. L'idée est que le constructeur vous permet de faire des configurations plus complexes pour lesquelles un constructeur ne serait pas adéquat.

![builder](https://user-images.githubusercontent.com/32362054/177939238-a2e5d8c8-d96c-44b9-ba17-f8473976afd3.png)

# 3. Method Factory
La méthode Factory est un modèle de conception créationnel qui résout le problème de la création d'objets produit sans spécifier leurs classes concrètes. Factory Method définit une méthode qui doit être utilisée pour créer des objets au lieu d'un appel direct au constructeur (nouvel opérateur).

![4](https://user-images.githubusercontent.com/32362054/177935867-ff982fb7-170c-4a31-a6cd-b9ab7c67b883.png)

![unknown](https://user-images.githubusercontent.com/32362054/177935999-b0ad4bc4-2a13-4b6f-a343-e72cdd7492bc.png)

# 4. Singleton 
Le pattern singleton est utilisé pour créer une instance unique d’une classe, le pattern abstract est susceptible d’utiliser ce type d’instance unique.

![singleton](https://user-images.githubusercontent.com/32362054/177936350-c12aa4a8-6487-404d-a7af-45428f7dad72.png)

![LiasseVierge](https://user-images.githubusercontent.com/32362054/177936252-01910167-f3fe-413c-b8eb-5e1bc3f0718f.png)

Notre application va utiliser la classe liasse vierge LiassVierge qui ne possedera qu’une seule instance.
Chaque classe qui utilise la classe LiasseVierge doit avoir accès à la même instance.

# 5. Prototype
Le pattern prototype permet la création d’objets à partir d’autres objets appelés « prototypes » disposant d’une méthode Clone() qui retourne un objet identique 

![proto](https://user-images.githubusercontent.com/32362054/177937166-9a4b1e15-04f9-4b90-b587-4dea5ae34afe.png)

# Les patterns de structuration 
Ils permettent de faciliter l’indépendance de l’interface d’un objet et de son implémentation. 

En fournissant les interfaces ce pattern permet d’encapsuler la composition des objets

Cela augmente le niveau d’abstraction d’un système donné un peu à la manière des patterns de création qui encapsulent la création d’objets. 

Ces patterns mettent en avant les interfaces.

# 6. Composite
Composite est un modèle de conception structurelle qui permet de composer des objets dans une structure arborescente et de travailler avec comme s'il s'agissait d'un objet singulier. Ce terme est utilisé lorsque vous voulez décrire un objet contenant un autre. Cela se produit très souvent dans la discussion sur la composition plutôt que sur l'héritage. L'approche de composition fournit une encapsulation plus forte que l'héritage, car une modification apportée à une classe principale ne casse pas nécessairement le code qui s'appuie sur la classe frontale. Les principaux avantages de la composition sont qu'avec des interfaces soigneusement conçues, nous pouvons modifier les références des classes principales au moment de l'exécution.

# 7. Adapter
Le pattern adapter est de convertir l’interface d’une classe donnée en une interface attendue par des clients afin qu’ils puissent travailler ensemble. En résumé, il permet de donner à une classe existante une nouvelle interface pour répondre aux besoins d’un client.

![adapter_2](https://user-images.githubusercontent.com/32362054/177937571-e236678e-87cb-4015-8fc3-299867c1768e.png)

![adapter](https://user-images.githubusercontent.com/32362054/177937340-f83e3c0f-bc0e-451b-9e1a-15271d684cc5.png)

# 8. Bridge 
Le pattern Bridge est utilisé pour séparer le comportement de l’implémentation de l’interface et de l’implémentation de l’objet. 

![bridge_2](https://user-images.githubusercontent.com/32362054/177938304-8a69489a-5861-4fab-96f1-ab455b6c2ce7.png)

![bridge](https://user-images.githubusercontent.com/32362054/177938312-decd33de-5c18-4070-b040-a170f8d1f318.png)

On s’intéresse aux demandes d’immatriculation des véhicules. 
Le formulaire de demande d’immatriculation possède deux implémentations différentes.

Classe abstraite mère: FormulaireImmat
Classes filles :

- FormulaireImmatHTML
- FormulaireImmatAPP

Au départ le système a été conçu pour la France uniquement.
Ensuite on a du créé en sous-classe FormulaireImmatCH elle aussi abstraite pour avoir également deux sous-classes concrètes (qui sont FormulaireImmatHTML et FormulaireImmatAPP dédiées à la Suisse

# 9. Composite
Ce pattern offre un cadre de conception d’une composition d’objet dont on ne connait pas la profondeur. (On peut utiliser un arbre en tant qu’analogie). Les « clients » interagissent avec les objets sans connaitre la structure de l’arbre.

![command_1](https://user-images.githubusercontent.com/32362054/177940218-c9831d7d-2059-43a6-8f52-c88c2a5337e7.png)

![composite](https://user-images.githubusercontent.com/32362054/177940226-0fd0bc7c-0f18-412b-beba-01c025829407.png)


# 10. Decorator
Ce pattern permet d’ajouter dynamiquement des fonctionnalités supplémentaires à un objet sans modifier l’interface del’objet (« les clients de l’objet ne sont pas au courant de la modification »). 

Il s’agit d’une alternative à la création d’une sous-classe qui permettrait d’enrichir l’objet.

![decorateur_1](https://user-images.githubusercontent.com/32362054/177938424-28f95bad-1eaa-4182-b7b6-52924f7a04b9.png)

![decorateur](https://user-images.githubusercontent.com/32362054/177938430-1023fe58-c55e-4dbe-af64-0f06a1247b74.png)

# Les patterns de Comportement 
Les patterns de comportement distribuent les algorithmes/traitement entre les objets. 

Ils organisent les interactions en renseignant le « flux de contrôle » et de traitement au sein d’un système d’objet. 

La distribution se fait soit par héritage soit par délégation.

# 12. Chain of responsability
Le but est de construire une chaine d’objets de manière à ce que si un objet de la chaîne ne peut repondre à une requête, il puisse la passer a un « successeur » et ainsi de suite jusqu'à ce que l’un des objets puissent y répondre.

![cor](https://user-images.githubusercontent.com/32362054/177938727-1e58716d-905e-46c8-98e7-9e21305cf7e8.png)

![cor-3](https://user-images.githubusercontent.com/32362054/177938773-4ae07ff2-bf12-4f39-92b2-6f6a18b0d933.png)

![cor-1](https://user-images.githubusercontent.com/32362054/177938846-fc3b3ebf-134b-46aa-bfb0-3190c553e42e.png)


# 13. Command 
Ce pattern transforme une requête en objet ceci facilite les opérations relatives à la requête ex : annulation, queue, suivi etc…

![command_1](https://user-images.githubusercontent.com/32362054/177938976-d7512cf4-3d86-4729-9e60-055bc122f330.png)

![command](https://user-images.githubusercontent.com/32362054/177938949-1e0b10a5-2774-4eba-9daa-6e24ca113f1f.png)


# 14. Iterator
Itérateur est un patron de conception comportemental qui permet de parcourir les éléments d’une collection sans révéler sa représentation interne (liste, pile, arbre, etc.).

![iterator](https://user-images.githubusercontent.com/32362054/177939136-9c24d8f2-a051-4d2a-ab28-16574495ddcd.png)

![iteratorr](https://user-images.githubusercontent.com/32362054/177939150-e15e4567-71e1-4636-b941-94dd87b58000.png)

# 15. Mediator
Son but c'est de construire un objet.
Le rôle de l'objet c'est de grérer/contrôler les interactions entre les autres objets. 

Les objets ne sont pas censés se connaître entre eux. 
Il s'occupe de la gestion.

![mediator](https://user-images.githubusercontent.com/32362054/177939609-cc1ec274-481f-4561-9ef8-899c4785badd.png)

![mediatorr](https://user-images.githubusercontent.com/32362054/177939621-67d758f5-da27-45bc-b18c-a71b8fd5552e.png)



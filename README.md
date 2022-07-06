# DeisgnPattern
cours de design pattern dotnet 6 &amp; c#
# Les différents patterns : 

# 1. Abstract Factory :
Modèle de conception de création, qui résout le problème de la création de familles de produits entières sans spécifier leurs classes concrètes. Abstract Factory définit une interface pour créer tous les produits distincts, mais laisse la création du produit réel à des classes d'usine concrètes.

# 2. Builder
Le modèle de générateur est utilisé lorsqu'il y a une configuration complexe impliquée dans la création d'un objet. Il sépare la construction d'un objet de l'utilisation de l'objet. L'idée est que le constructeur vous permet de faire des configurations plus complexes pour lesquelles un constructeur ne serait pas adéquat.

# 3. Method Factory
La méthode Factory est un modèle de conception créationnel qui résout le problème de la création d'objets produit sans spécifier leurs classes concrètes. Factory Method définit une méthode qui doit être utilisée pour créer des objets au lieu d'un appel direct au constructeur (nouvel opérateur).

# 4. Singleton 
Le pattern singleton est utilisé pour créer une instance unique d’une classe, le pattern abstract est susceptible d’utiliser ce type d’instance unique.

# 5. Prototype
Le pattern prototype permet la création d’objets à partir d’autres objets appelés « prototypes » disposant d’une méthode Clone() qui retourne un objet identique 

# 6. Composite
Composite est un modèle de conception structurelle qui permet de composer des objets dans une structure arborescente et de travailler avec comme s'il s'agissait d'un objet singulier. Ce terme est utilisé lorsque vous voulez décrire un objet contenant un autre. Cela se produit très souvent dans la discussion sur la composition plutôt que sur l'héritage. L'approche de composition fournit une encapsulation plus forte que l'héritage, car une modification apportée à une classe principale ne casse pas nécessairement le code qui s'appuie sur la classe frontale. Les principaux avantages de la composition sont qu'avec des interfaces soigneusement conçues, nous pouvons modifier les références des classes principales au moment de l'exécution.

# 7. Adapter
Le pattern adapter est de convertir l’interface d’une classe donnée en une interface attendue par des clients afin qu’ils puissent travailler ensemble. En résumé, il permet de donner à une classe existante une nouvelle interface pour répondre aux besoins d’un client.

# 8. Bridge 
Le pattern Bridge est utilisé pour séparer le comportement de l’implémentation de l’interface et de l’implémentation de l’objet. On s’intéresse aux demandes d’immatriculation des véhicules. Le formulaire de demande d’immatriculation possède deux implémentations différentes.

# 9. Composite
Ce pattern offre un cadre de conception d’une composition d’objet dont on ne connait pas la profondeur. (On peut utiliser un arbre en tant qu’analogie). Les « clients » interagissent avec les objets sans connaitre la structure de l’arbre.

# 10. Decorator
Ce pattern permet d’ajouter dynamiquement des fonctionnalités supplémentaires à un objet sans modifier l’interface del’objet (« les clients de l’objet ne sont pas au courant de la modification »). Il s’agit d’une alternative à la création d’une sous-classe qui permettrait d’enrichir l’objet.

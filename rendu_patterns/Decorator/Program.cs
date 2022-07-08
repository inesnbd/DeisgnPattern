using Decorator;
using Common;

string description = @"
       We want to define the encapsulation of several elements. In our case we have a restaurant with different dishes.
       For this we use the structural design pattern Decorator which allows to dynamically add additional functionalities to an object without modifying the interface of the object. 
       ";

UI.printCopyright("Decorator", description);

RestaurantView restaurantView = new RestaurantView();
DishesDecorator dishesDecorator = new DishesDecorator(restaurantView);
PizzaDecorator pizzaDecorator = new PizzaDecorator(restaurantView);
RestaurantDecorator restaurantDecorator = new RestaurantDecorator(pizzaDecorator);
restaurantDecorator.printInformations();

Console.ReadKey();
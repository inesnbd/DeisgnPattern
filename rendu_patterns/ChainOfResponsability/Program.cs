using ChainOfResponsibility;
using Common;

string description = @"
        We have a company of car with 3 models : Sport| Familial | Regular
        This company needs to validate orders and the validator depends on the price.
        The goal is to build a chain of objects in such a way that if an object in the chain cannot answer a query, 
        it can pass it to a successor and so on until one of the objects can answer it.
        ";

        string price = @"
        If the price < 1000, it's for a regular model
        If the price >= 1000 and price < 3500, minimum it's for a familial model 
        If the price >= 5000, it's for a sport model 
        ";

        string intro = ("Chain of Responsability "+ description + "" + price);

        Voiture regular = new Regular();
        Voiture familial = new Familial();
        Voiture sport = new Sport();

        regular.Next = familial;
        familial.Next = sport;

        int[] orderPrices = { 700, 2100, 5000 };

        Console.WriteLine(tableSeparator);
        Console.WriteLine("| Min price allowed \t | Order price \t | Max price allowed \t | Details \t \t \t \t |");
        Console.WriteLine(tableSeparator);

        foreach (int price in orderPrices)
        {
            regular.GiveResponse(price);
        }

    Console.WriteLine(tableSeparator);

    Console.WriteLine("\nIt can be seen that if the price of the order is higher than the maximum allowed price, permission is requested from the familial.");

    Console.ReadKey();
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DesignPatterns.rendu_patterns.AbstractFactory
{
    class Program
    {
        string description = @"
        We are a fashion boutique who sell different shoes.
        The objective of the abstract factory is to group car objects without knowing their characteristics.
        ";

        // UI.printCopyright("Abstract Factory", description);

        IBoutique basket = new Basket();
        Basket Shoes = basket.addBasket("Baskets_bleu");
        Shoes.printModel();


        IBoutique sandales = new Sandales();
        Sandales Shoes = sandales.addSandales("Sandales_rouge");
        Shoes.printModel();

        IBoutique bottes = new Bottes();
        Bottes Shoes = bottes.addBottes("Bottes_noir");
        Shoes.printModel();

        Console.ReadKey();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.Decorator
{
    public class PizzaDecorator : Decorator
    {
        public PizzaDecorator(IRestaurant composant) : base(composant) { }

        protected void printPizza()
        {
            Console.WriteLine("Informations about the menu with pizza");
        }

        public override void printInformations()
        {
            base.printInformations();
            this.printPizza();
        }
    }
}

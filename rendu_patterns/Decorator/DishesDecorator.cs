using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.Decorator
{
    public class DishesDecorator : Decorator
    {
        public DishesDecorator(IRestaurant composant) : base(composant) { }

        protected void printDishesInformations()
        {
            Console.WriteLine("Informations about the dishes of the menu");
        }

        public override void printInformations()
        {
            base.printInformations();
            this.printDishesInformations();
        }
    }
}

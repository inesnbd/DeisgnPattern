using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.Decorator
{
    public class RestaurantDecorator : Decorator
    {
        public RestaurantDecorator(IRestaurant composant) : base(composant) { }

        protected void printRestaurantInformations()
        {
            Console.WriteLine("Informations about the restaurant");
        }

        public override void printInformations()
        {
            base.printInformations();
            this.printRestaurantInformations();
        }
    }
}

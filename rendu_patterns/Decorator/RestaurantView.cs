using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.Decorator
{
    public class RestaurantView : IRestaurant
    {
        public void printInformations()
        {
            Console.WriteLine("Informations about the restaurant");
        }
    }
}

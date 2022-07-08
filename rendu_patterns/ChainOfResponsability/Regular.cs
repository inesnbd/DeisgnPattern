using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.ChainOfResponsability
{
    public class Regular : Voiture
    {
        public Regular()
        {
            this.MinimumPrice = 0;
            this.MaximumPrice = 1000;
        }
        public override void GiveResponse(float price)
        {
            if (price >= MinimumPrice && price < MaximumPrice)
                Console.WriteLine($"| {MinimumPrice} \t \t \t | {price} \t \t | {MaximumPrice} \t \t | for a regular model");
            else if (Next != null)
                Next.GiveResponse(price);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.ChainOfResponsability
{
    public class Familial : Voiture
    {
        public Familial()
        {
            this.MinimumPrice = 1000;
            this.MaximumPrice = 3500;
        }
        public override void GiveResponse(float price)
        {
            if (price >= MinimumPrice && price < MaximumPrice)
                Console.WriteLine($"| {MinimumPrice} \t \t \t | {price} \t | {MaximumPrice} \t \t | Minimum for a familial model");
            else if (Next != null)
                Next.GiveResponse(price);
        }
    }
}

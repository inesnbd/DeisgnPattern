using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.ChainOfResponsability
{
    public class Sport : Voiture
    {
        public Sport()
        {
            this.MinimumPrice = 5000;
            this.MaximumPrice = float.PositiveInfinity;
        }
        public override void GiveResponse(float price)
        {
            if (price >= MinimumPrice && price < MaximumPrice)
                Console.WriteLine($"| {MinimumPrice} \t \t \t | {price} \t | Infinity \t \t | Minimum for a sport model");
            else if (Next != null)
                Next.GiveResponse(price);
        }
    }
}
}

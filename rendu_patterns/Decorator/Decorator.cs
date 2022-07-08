using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.Decorator
{

    public abstract class Decorator : IRestaurant
    {
        protected IRestaurant composant;

        public Decorator(IRestaurant composant)
        {
            this.composant = composant;
        }

        public virtual void printInformations()
        {
            composant.printInformations();
        }
    }
}

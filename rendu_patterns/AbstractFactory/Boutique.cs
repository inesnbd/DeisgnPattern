using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.AbstractFactory
{
    public class Boutique : IBoutique
    {

        public Basket addBasket(string name)
        {
            return new Basket(name);
        }

        public Bottes addBottes(string name)
        {
            throw new NotImplementedException();
        }

        public Sandales addSandales(string name)
        {
            return new Sandales(name);
        }

    }
}

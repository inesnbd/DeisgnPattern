using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.AbstractFactory
{
    public interface IBoutique
    {
        Basket addBasket(string name);

        Sandales addSandales(string name);

        Bottes addBottes(string name);
    }
}

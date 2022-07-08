using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.AbstractFactory
{
    public class Sandales : Shoes
    {
        public Sandales(string name) : base(name) { }

        public override void printModel()
        {
            Console.WriteLine($"Mon modèle est {Name}");
        }
    }
}
}

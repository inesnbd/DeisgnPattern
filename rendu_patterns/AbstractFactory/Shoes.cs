using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.AbstractFactory
{
 
    public abstract class Shoes
    {
        public string Name { get; set; }
        public Shoes(string name)
        {
            this.Name = name;
        }

        public abstract void printModel();
    }
}

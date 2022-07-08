using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.Singleton
{
    class Objet
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Objet(string name, DateTime date)
        {
            this.Name = name;
            this.Date = date;
        }
    }
}

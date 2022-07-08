using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.Singleton
{
    class Calendar
    {
        public List<Objet> Objets;
        private static Calendar _instance = null;

        private Calendar()
        {
            Objets = new List<Objet>();
        }

        public static Calendar Instance()
        {
            if (_instance == null)
                _instance = new Calendar();
            return _instance;
        }

        public bool AddObjet(Objet e)
        {
            if (Objets.Contains(e))
            {
                Console.WriteLine($"The Objet '{e.Name}' cannot be added because it already exists in calendar");
                return false;
            }

            Objets.Add(e);
            Console.WriteLine($"The Objet '{e.Name}' has been added to calendar");
            return true;
        }

        public bool RemoveObjet(Objet e)
        {
            if (!Objets.Contains(e))
            {
                Console.WriteLine($"The Objet '{e.Name}' can't be removed because it doesn't exists in Calendar");
                return false;
            }

            Objets.Remove(e);
            Console.WriteLine($"The Objet '{e.Name}' has been removed from Calendar");
            return true;
        }

        public void SeeCalendar()
        {

            Console.WriteLine(" Date \t\t | \t\t Name \t\t ");
            foreach (Objet e in Objets)
            {
                Console.WriteLine($"{e.Date.ToString("dd/MM/yyyy")} \t | \t {e.Name} ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.rendu_patterns.Singleton
{
    class User
    {
        public string Name { get; set; }
        private Calendar Calendar { get; set; }

        public User(string name)
        {
            this.Name = name;
            this.Calendar = Calendar.Instance();
            Console.WriteLine($"The user {Name} has been created");
        }

        public void AddToCalendar(Objet e)
        {
            Calendar.AddObjet(e);
        }

        public void SeeCalendar()
        {
            Console.WriteLine($"\n{Name} displays the Calendar:");
            Calendar.SeeCalendar();
        }

    }
}
}

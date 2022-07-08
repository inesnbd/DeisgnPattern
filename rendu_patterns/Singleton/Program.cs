using Singleton;
using Common;

string description = @"
       I'm making a Calendar. An user can add an objet in the Calendar and we can see it. 
       To do this, I used a Singleton is used to create a single instance of a class.
       ";

    string intro = ("Singleton " + description);

    User user = new User("Inès");
    User.AddToCalendar(new Objet($"objet created by {user.name}",  new DateTime(2022, 08, 07)));
    User.SeeCalendar();


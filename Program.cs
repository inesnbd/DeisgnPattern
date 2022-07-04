using System;
using static DesignPatterns.Program;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Classe scooter qui a deux classes filles : une nommée « ScooterElectricité » et l’autre « ScooterEssence »
        abstract class Scooter
        {

        }

        class ScooterElectrique : Scooter
        {

        }

        class ScooterEssence : Scooter
        {

        }

        public abstract class Automobile
        {
            protected string modele;
            protected string couleur;
            protected int puissance;
            protected double espace;


            public Automobile(string modele, string couleur, int puissance, double espace)
            {
                this.modele = modele;
                this.couleur = couleur;
                this.puissance = puissance;
                this.espace = espace;
            }

            public abstract void AfficherCarac();

      

        public class AutomobileElectrique : Automobile
        {
            public AutomobileElectrique(string modele, string couleur, int puissance, double espace) : base(modele, couleur, puissance, espace)
            {

            }

            public override void AfficherCarac()
            {
                Console.WriteLine("Automobile électrique : ");
                Console.WriteLine("Modele : " + modele);
                Console.WriteLine("Couleur : " + couleur);
                Console.WriteLine("Puissance : " + puissance);
                Console.WriteLine("Espace : " + espace);
            }

            }
        }
    }

    public interface FabriqueVehicule
    {
        Automobile CreerAutomobile(string modele, string couleur, int puissance, double espace);
    }

    public class FabriqueVehiculeElectrique : FabriqueVehicule
    {
        public Automobile CreerAutomobile(string modele, string couleur, int puissance, double espace)
        {
            return new AutomobileElectrique(modele, couleur, puissance, espace);
        }
    }


    public class Catalogue
    {
        public static int vehiculeNumber = 3;
        static void Main(string[] args)
        {
            FabriqueVehicule fabrique = new FabriqueVehiculeElectrique();
            Automobile auto = fabrique.CreerAutomobile("Tesla", "bleu", 250, 2.5);
            auto.AfficherCarac();
        }
    }
}

using Konsoline.Models;
using System;



namespace ManoPrograma
{
    public class PagrindineKlase
    {
        public static void Main()
        {
            Automobilis auto1 = new Automobilis("BMW", "330i", DateOnly.Parse("2012-04-12"), 400000);
            Automobilis auto2 = new Automobilis("Audi", "RS6", DateOnly.Parse("2008-08-19"), 500000, "Raudona");

            Automobilis[] automobiliai = new Automobilis[2];

            automobiliai[0] = auto1;
            automobiliai[1] = auto2;

            automobiliai[0].Perdazyti("Melyna");
           
            for(int i = 0; i< automobiliai.Length; i++)
            {
                Console.WriteLine(automobiliai[i]);
            }
        }

    }
}


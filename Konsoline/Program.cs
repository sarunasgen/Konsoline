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

            AutomobiliuParkas automobiliuParkas = new AutomobiliuParkas();
            automobiliuParkas.PridetiAutomobili(auto1);
            automobiliuParkas.PridetiAutomobili(auto2);

          //  Console.WriteLine(automobiliuParkas.GautiAutoPagalIndex(1));

            Automobilis[] visi = automobiliuParkas.GautiVisusAuto();

            foreach(Automobilis sarasoElementas in visi)
            {
                Console.WriteLine(sarasoElementas);
                if(sarasoElementas == null)
                {
                    break;
                }
            }
            
        }

    }
}


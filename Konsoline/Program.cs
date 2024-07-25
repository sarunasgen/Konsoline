using Konsoline.Models;
using Konsoline.Service;
using System;
using System.Collections.Generic;



namespace ManoPrograma
{
    public class PagrindineKlase
    {
        public static void Main()
        {
            AutomobiliaiService automobiliaiService = new AutomobiliaiService();
            ConsoleUserInterfaceService ui = new ConsoleUserInterfaceService(automobiliaiService);
            ui.PridetiTestiniusDuomenis();
            ui.PaleistiMeniu();
            Console.WriteLine("Visi Automobiliai pries uzdarant programa: ");
            foreach(Automobilis a in automobiliaiService.GautiVisusAuto())
            {
                Console.WriteLine(a);
            }
        }
    }
}

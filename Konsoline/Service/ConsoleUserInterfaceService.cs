using Konsoline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsoline.Service
{
    public class ConsoleUserInterfaceService
    {
        private AutomobiliaiService _automobiliaiService;
        public ConsoleUserInterfaceService(AutomobiliaiService automobiliaiService)
        {
            _automobiliaiService = automobiliaiService;
        }
        public void PaleistiMeniu()
        {
            while (true)
            {
                Console.WriteLine("1. Pridėti automobili");
                Console.WriteLine("2. Rodyti visus");
                Console.WriteLine("3. Rasti automobili");
                
                Console.WriteLine("0. Išeiti");
                Console.Write("Pasirinkite veiksmą: ");
                string pasirinkimas = Console.ReadLine();

                try
                {
                    switch (pasirinkimas)
                    {
                        case "1":
                            Console.WriteLine("Iveskite marke: ");
                            string marke = Console.ReadLine();
                            Console.WriteLine("Iveskite modeli: ");
                            string modelis = Console.ReadLine();
                            Console.WriteLine("Iveskite pagaminimo data: ");
                            DateOnly data = DateOnly.Parse(Console.ReadLine());
                            Console.WriteLine("Iveskite rida: ");
                            int rida = int.Parse(Console.ReadLine());

                            _automobiliaiService.PridetiAuto(new Automobilis(marke, modelis, data, rida));
                            Console.WriteLine("Automobilis pridetas sekmingai");
                            break;
                        case "2":
                            foreach (Automobilis a in _automobiliaiService.GautiVisusAuto())
                            {
                                Console.WriteLine(a);
                            }
                            break;
                        case "3":
                            string ieskomaMarke = Console.ReadLine();
                            Console.WriteLine(_automobiliaiService.GautiAutomobiliPagalMarke(ieskomaMarke));
                            break;
                        case "4":

                            break;
                        case "5":

                            break;
                        case "6":

                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Neteisingas pasirinkimas.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Klaida: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
        public void PridetiTestiniusDuomenis()
        {
            Automobilis auto1 = new Automobilis("BMW", "330i", DateOnly.Parse("2012-04-12"), 400000);
            Automobilis auto2 = new Automobilis("Audi", "RS6", DateOnly.Parse("2008-08-19"), 500000, "Raudona");
            Automobilis auto3 = new Automobilis("Audi", "S8", DateOnly.Parse("2003-08-19"), 500000, "Pilka");

            _automobiliaiService.PridetiAuto(auto1);
            _automobiliaiService.PridetiAuto(auto2);
            _automobiliaiService.PridetiAuto(auto3);

        }
    }
}

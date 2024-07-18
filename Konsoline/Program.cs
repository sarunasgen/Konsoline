using System;
using ManoPrograma.Models;
using MatematiniaiVeiksmai;

namespace ManoPrograma
{
    public class PagrindineKlase
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Iveskite skaiciu: ");
            if (ArLyginis(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Lyginis");
            }
            else
            {
                Console.WriteLine("Nelyginis");
            }
            Console.WriteLine("Iveskite Kaina: ");
            double kainaBePvm = double.Parse(Console.ReadLine());
            Console.WriteLine("Kaina su PVM bus: " + SkaiciuotiKainaSuPVM(kainaBePvm));
            
            SpausdinkZvaigzdutes();
            SpausdinkZvaigzdutes();
            SpausdinkZvaigzdutes();
            SpausdinkZvaigzdutes();
            SpausdinkZvaigzdutes();
            
            Console.WriteLine("Iveskite ka norite atspausdinti 10 kartu: "); 
            SpausdinkDesimtSimboliu(Console.ReadLine());
            
            Matematika matFunkcijos = new Matematika();
            Console.WriteLine(matFunkcijos.Sudek(10, 12));*/
            Zmogus.StatineVerte = 94;
            Zmogus x = SugeneruokZmogausParametrus("Jonas", "Jonaitis");
            Zmogus y = SugeneruokZmogausParametrus("Petras", "Petraitis");
            Zmogus z = SugeneruokZmogausParametrus("Vaidas", "Vaidaitis");
            y.PadidinkUgi(35);
            Zmogus.StatineVerte = 85;
            Console.WriteLine(z.GimimoMetus);
        }

        public static bool ArLyginis(int skaicius)
        {
            if (skaicius % 2 == 0)
                return true;
            return false;
        }

        public static double SkaiciuotiKainaSuPVM(double grossPrice)
        {
            return grossPrice * 1.21;
        }

        public static void SpausdinkZvaigzdutes()
        {
            Console.WriteLine("************************************");
        }
        public static void SpausdinkDesimtSimboliu(string s)
        {
            Console.WriteLine($"{s}{s}{s}{s}{s}{s}{s}{s}{s}");
        }

        public static Zmogus SugeneruokZmogausParametrus(string vardas, string pavarde)
        {
            Random r = new Random();
            
            Zmogus zmogus = new Zmogus();
            zmogus.Vardas = vardas;
            zmogus.Pavarde = pavarde;
            zmogus.GimimoMetus = r.Next(1950, 2020);
            zmogus.Ugis = r.Next(100, 220);

            return zmogus;
        }
    }
}


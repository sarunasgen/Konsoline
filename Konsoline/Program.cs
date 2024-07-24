using Konsoline.Models;
using System;
using System.Collections.Generic;



namespace ManoPrograma
{
    public class PagrindineKlase
    {
        public static void Main()
        {
            Automobilis auto1 = new Automobilis("BMW", "330i", DateOnly.Parse("2012-04-12"), 400000);
            Automobilis auto2 = new Automobilis("Audi", "RS6", DateOnly.Parse("2008-08-19"), 500000, "Raudona");
            Automobilis auto3 = new Automobilis("Audi", "S8", DateOnly.Parse("2003-08-19"), 500000, "Pilka");
            Automobilis auto3kopija = new Automobilis("Audi", "S8", DateOnly.Parse("2003-08-19"), 500000, "Pilka");

            List<Automobilis> automobiliuParkas = new List<Automobilis>();

            automobiliuParkas.Add(auto1);
            automobiliuParkas.Add(auto2);
            automobiliuParkas.Add(auto3);
            Console.WriteLine("Spaudinam su foreach");
            foreach (Automobilis auto in automobiliuParkas)
            {
                Console.WriteLine(auto);
            }

            Console.WriteLine("Spaudinam su for");
            for (int i = 0; i < automobiliuParkas.Count; i++)
            {
                Console.WriteLine(automobiliuParkas[i]);
            }

            int autoIndex = automobiliuParkas.IndexOf(auto2);

            List<Automobilis> audiAuto = automobiliuParkas.FindAll(x => x.Marke == "Audi").ToList();

            List<Automobilis> audiAuto2 = new List<Automobilis>();
            foreach (Automobilis a in automobiliuParkas)
            {
                if (a.Marke == "Audi")
                    audiAuto2.Add(a);

            }

            Console.WriteLine("Visos Audi");
            foreach (Automobilis auto in audiAuto)
            {
                Console.WriteLine(auto);
            }

            int[] masyvas = new int[] { 43, 12, 16, 17 };
            for (int i = masyvas.Length; i > 0; i--)
            {
                Console.WriteLine(masyvas[i - 1]);
            }

            List<int[]> list = new List<int[]>();
            list.Add(new int[] { 64, 69 });
            list.Add(new int[] { 54, 1 });
            list.Add(new int[] { 1, 2 });
            list.Add(new int[] { 3, 6 });

            foreach (int[] item in list)
            {
                foreach (int elementInArray in item)
                {
                    Console.Write(elementInArray + " ");
                }
                Console.WriteLine();
            }
            string[] sakiniuMasyvas = new string[] { "pirmas sakinys", "antras sakinys" };
            List<string> sakiniuSarasas = sakiniuMasyvas.ToList();
            sakiniuSarasas.Add("trecias sakinys");

            if (sakiniuSarasas.Contains("pirmas sakinys"))
            {
                Console.WriteLine("pirmas sakinys yra sarase");
            }
            else
            {
                Console.WriteLine("Nera");
            }

            foreach (string element in sakiniuSarasas)
            {
                Console.WriteLine(element);
            }
            sakiniuMasyvas = sakiniuSarasas.ToArray();
            foreach (string element in sakiniuMasyvas)
            {
                Console.WriteLine(element);
            }





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            List<string> colors = new List<string> { "raudona", "mėlyna", "žalia" };
            colors.Add("geltona");
            colors.Remove("raudona");
            colors.Sort();
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

        }
    }
}

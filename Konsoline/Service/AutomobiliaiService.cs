using Konsoline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsoline.Service
{
    public class AutomobiliaiService
    {
        private List<Automobilis> AutoParkas { get; set; }
        public AutomobiliaiService()
        {
            AutoParkas = new List<Automobilis>();
        }
        public void PridetiAuto(Automobilis automobilis)
        {
            AutoParkas.Add(automobilis);
        }
        public List<Automobilis> GautiVisusAuto()
        {
            return AutoParkas;
        }
        public Automobilis GautiAutomobiliPagalMarke(string marke)
        {
            foreach(Automobilis a in AutoParkas)
            {
                if (a.Marke == marke)
                    return a;
            }
            return new Automobilis();
        }
    }
}

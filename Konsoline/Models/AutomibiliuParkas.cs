using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsoline.Models
{
    public class AutomobiliuParkas
    {
        private Automobilis[] Automobiliai { get; set; }
        int paskutinisPridetas = 0;
        int autoKiekis = 0;
        public AutomobiliuParkas()
        {
            Automobiliai = new Automobilis[1000];
        }
        public void PridetiAutomobili(Automobilis automobilis)
        {
            Automobiliai[paskutinisPridetas] = automobilis;
            paskutinisPridetas++;
            autoKiekis++;
        }
        public Automobilis GautiAutoPagalIndex(int index)
        {
            if (index > paskutinisPridetas)
                return new Automobilis();
            return Automobiliai[index];
        }
        public Automobilis[] GautiVisusAuto()
        {
            return Automobiliai;
        }

    }
}

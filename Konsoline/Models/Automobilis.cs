using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsoline.Models
{
    public class Automobilis
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public DateOnly PagaminimoMetai { get; set; }
        public int Rida { get; set; }
        private string Spalva { get; set; } = "Juoda";
        public Automobilis()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="marke">Automobilio Marke</param>
        /// <param name="modelis">Automobilio Modelis</param>
        /// <param name="pagaminimoMetai">Pagaminimo metai (tik data, DateOnly)</param>
        /// <param name="rida">Rida (sveikasis skaicius)</param>
        public Automobilis(string marke, string modelis, DateOnly pagaminimoMetai, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            PagaminimoMetai = pagaminimoMetai;
            Rida = rida;
            AtsuktiRida();
        }
        public Automobilis(string marke, string modelis, DateOnly pagaminimoMetai, int rida, string spalva)
        {
            Marke = marke;
            Modelis = modelis;
            PagaminimoMetai = pagaminimoMetai;
            Rida = rida;
            Spalva = spalva;
            AtsuktiRida();
        }
        private void AtsuktiRida()
        {
            Random r = new Random();
            Rida -= r.Next(100000, 200000);
        }
        public void Perdazyti(string naujaSpalva)
        {
            Spalva = naujaSpalva;
        }
        public string GautiSpalva()
        {
            return Spalva;
        }
        public override string ToString()
        {
            return $"{Marke} {Modelis} {PagaminimoMetai} Automobilio rida: {Rida}km Automobilio Spalva: {Spalva}";
        }
    }
}

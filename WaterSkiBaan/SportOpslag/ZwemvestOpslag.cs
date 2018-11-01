using System.Collections.Generic;
using System.Text;
using WaterSkiBaan.SportOpslag;
using WaterSkiBaan.SportUitrusting;

namespace WaterSkiBaan.SportOpslag
{
    public class ZwemvestOpslag : IOpslag
    {
        private Stack<Zwemvest> Opslag { get; set; } = new Stack<Zwemvest>();

        public void Opslaan(SportArtikel sportartikel)
        {
            var zwemvest = (Zwemvest)sportartikel;
            Opslag.Push(zwemvest);
        }

        public Zwemvest PakZwemvest()
        {
            return Opslag.Pop();
        }

        public override string ToString()
        {
            var opslagArray =Opslag.ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < opslagArray.Length; i++)
            {
                sb.Append("* ");
            }
            return $"({opslagArray.Length.ToString()}) {sb.ToString()}";
        }
    }
}
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSkiBaan.Sporters;

namespace WaterSkiBaan.Kabelbaan
{
    public class Lijn
    {
        public Lijn(int positie)
        {
            PositieOpDeKabel = positie;
        }

        public Lijn(){
            PositieOpDeKabel = null;
        }

        public int? PositieOpDeKabel { get; set; }
        public Sporter Sporter { get; set; }
    }
}

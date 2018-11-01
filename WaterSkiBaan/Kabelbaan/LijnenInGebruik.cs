using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSkiBaan.Kabelbaan {
    class LijnenInGebruik {
        //Opdracht 3 <DONE>
        public LinkedList<Lijn> Lijnen;

        public void NeemLijnInGebruik(Lijn l) {
            Lijnen.AddFirst(l);
            l.PositieOpDeKabel = 0;
        }

        public void StelLijnBuitenGebruik(Lijn l) {
            Lijnen.Remove(l);
        }
    }
}

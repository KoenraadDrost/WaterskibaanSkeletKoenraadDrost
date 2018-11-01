using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSkiBaan.Sporters;

namespace WaterSkiBaan.Wachtrijen {
    class WachtrijStarten {
        //Opdracht1 <DONE>
        public Queue<Sporter> Wachtrij;

        public void VoegSporterToeAanRij(Sporter s) {
            Wachtrij.Enqueue(s);
        }
    }
}

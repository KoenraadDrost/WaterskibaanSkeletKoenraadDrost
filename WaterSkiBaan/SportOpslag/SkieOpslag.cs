using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSkiBaan.SportUitrusting;

namespace WaterSkiBaan.SportOpslag {
    class SkieOpslag : IOpslag {
        //Opdracht2.2 t/m 2.8 <DONE>
        private Stack<Skies> Opslag { get; set; } = new Stack<Skies>();

        public void Opslaan(SportArtikel artikel) {
            if (artikel is Skies) {
                Opslag.Push((Skies)artikel);
            }
            

            //Deze methode van Zwemvest werkt wel, maar vind het niet elegant.
            //Omdat je de "Opslaan" methode van IOpslag moet implementeren kun je niet anders dan "Sportartikel" mee te geven aan de methode.
            //Nu dwing je af dat ieder Sportartikel wat meegegeven wordt automatisch Skies worden.
            //Dit houd er dus geen rekening mee dat het meegegeven Sportartikel niet Skies hoeven te zijn en veranderd zonder te bevestigen of het wel Skies zijn.
            //Zou het geen schoolopdracht zijn dan had ik de "Opslaan" methode van IOpslag aangepast zodat deze geen specifieke parameters afdwingt.

            //if (artikel is Skies)
            //{
            //    var skies = (Skies)artikel;
            //    Opslag.Push(skies);
            //}

        }

        public override string ToString()
        {
            var opslagArray = Opslag.ToArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < opslagArray.Length; i++)
            {
                sb.Append("* ");
            }
            return $"({opslagArray.Length.ToString()}) {sb.ToString()}";
        }


        public Skies PakSkies() {
            if (Opslag.Count < 1) {
                return null;
            } else {
                return Opslag.Pop();
            }
        }
    }
}

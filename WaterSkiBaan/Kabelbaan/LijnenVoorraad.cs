using System.Collections.Generic;

namespace WaterSkiBaan.Kabelbaan
{
    public class LijnenVoorraad
    {
        public Queue<Lijn> Lijnen = new Queue<Lijn>();

        public LijnenVoorraad()
        {
            Lijnen.Enqueue(new Lijn());
            Lijnen.Enqueue(new Lijn());
            Lijnen.Enqueue(new Lijn());
            Lijnen.Enqueue(new Lijn());
            Lijnen.Enqueue(new Lijn());
            Lijnen.Enqueue(new Lijn());
            Lijnen.Enqueue(new Lijn());
            Lijnen.Enqueue(new Lijn());
            Lijnen.Enqueue(new Lijn());
            Lijnen.Enqueue(new Lijn());
        }
    }
}
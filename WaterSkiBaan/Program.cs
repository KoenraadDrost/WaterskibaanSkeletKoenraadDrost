using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WaterSkiBaan.Events;
using WaterSkiBaan.Kabelbaan;
using WaterSkiBaan.Sporters;
using WaterSkiBaan.SportOpslag;
using WaterSkiBaan.SportUitrusting;
using WaterSkiBaan.Wachtrijen;

namespace WaterSkiBaan
{
    class Program
    {
        static WachtrijBeginWaterskibaan wachtrijBeginWaterskibaan = new WachtrijBeginWaterskibaan();
        static WachtrijInstructie wachtrijInstructie = new WachtrijInstructie();

        //Hint: uncomment onderstaande regel zodra je de klasse WachtrijStarten hebt gemaakt.
        static WachtrijStarten wachtrijStarten = new WachtrijStarten();

        static ZwemvestOpslag zwemvestenStapel = new ZwemvestOpslag();
        
        //Hint: uncomment onderstaande regel zodra je de klasse SkiOpslag hebt gemaakt.
        static SkieOpslag skiStapel = new SkieOpslag();

        public static LijnenVoorraad lijnenVoorraad = new LijnenVoorraad();

        static void Main(string[] args)
        {

            //skies en zwemvesten
            VulOpslag();

            int instructieEffectief = 0;
            for (int i = 0; i < 100; i++)
            {
                // Gemiddeld komt er eens per vijf ronden een nieuwe bezoeker
                if (random.Next(1, 5) == 1)
                {
                    wachtrijBeginWaterskibaan.VoegSporterToeAanRij(new Skier());
                }

                // Gemiddeld na 5/4 * 8 een seconde (Thread.Sleep) is er een instructie afgeloepn
                if (random.Next(1, 5) >= 2)
                {
                    instructieEffectief++;
                    if (instructieEffectief == 8)
                    {
                        // Hint: Uncomment onderstaande regel zodra je de klasse WachtrijStarten hebt geïmplementeerd.
                        //wachtrijStarten.GroepSportersNeemtPlaatsInRij(wachtrijInstructie.GetAlleCursisten());
                        wachtrijInstructie.GroepVerlaatRij();
                        int MaxAantalInstructieGroep = 3;
                        for (int j = 0; j < MaxAantalInstructieGroep; j++)
                        {
                            if(wachtrijBeginWaterskibaan.Wachtrij.Count() > 0)
                            {
                                wachtrijInstructie.VoegSporterToeAanRij(wachtrijBeginWaterskibaan.Wachtrij.Dequeue());
                            }
                            
                        }
                        instructieEffectief = 0;
                    }

                }
                LijnenPositieOpschuiven();
                PrintOverzichtWaterSkiBaan();
                Thread.Sleep(1000);
            }

        }


        static void SportersPakkenSkies(List<Sporter> sporters)
        {
            var cursisten = sporters;

            cursisten.ForEach(c =>
            {

                //<DONE>TODO cursist moet skies pakken van stapel. Maar dit is nog niet geïmplementeerd
                c.Uitrusting = skiStapel.PakSkies();             

            });
        }

        static void PrintOverzichtWaterSkiBaan()
        {
            //print overzicht stapels uitrusting
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("STAPELS");
            Console.WriteLine($"ZWEMVESTEN \t {Program.zwemvestenStapel.ToString()}");

            //Hint: uncomment onderstaande regel zodra je de klasse SkiOpslag hebt gemaakt.
            Console.WriteLine($"SKIES \t \t {Program.skiStapel.ToString()}");

            //print overzicht wachtrijen
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("WACHTRIJEN/GROEPEN");
            Console.WriteLine($"ENTREE \t {Program.wachtrijBeginWaterskibaan.ToString()}");
            Console.WriteLine($"INSTRUCTIE \t {Program.wachtrijInstructie.ToString()}");

            //Hint: uncomment onderstaande regel zodra je de klasse WachtrijStarten hebt gemaakt.
            //Console.WriteLine($"STARTEN \t {Program.wachtrijStarten.ToString()}");

            //print overzicht lijnen in gebruik
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("KABELOVERZICHT (lijnen op posities)");
            
            //Hint: Zodra je de klasse LijnenInGebruik hebt geïmplementeerd kun je deze regels uncomment-en.
            //Console.WriteLine(Program.lijnenInGebruik.ToString());
        }

        static void LijnenPositieOpschuiven()
        {
            //Deze methode kun je gebruiken om aan het event LijnenVerplaatsen te koppelen.
            //Deze methode heeft de klasse LijnenInGebruik nodig. Zie opdracht 3.
        }

        static void VulOpslag()
        {
            for (var i = 0; i < 20; i++)
            {
                zwemvestenStapel.Opslaan(new Zwemvest(RandomInteger()));
            }
            for (var i = 0; i < 20; i++)
            {
                skiStapel.Opslaan(new Skies(RandomInteger()));
            }
        }

        static Random random = new Random();

        static int RandomInteger()
        {
            return random.Next();
        }
    }
}

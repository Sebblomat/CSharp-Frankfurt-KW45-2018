using HalloVererbung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloVererbung.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonenZug pz = new PersonenZug()
            {
                Nummer = "ICE 1",
                Klimaanlage = true,
                Baujahr = new DateTime(2012, 1, 29),
                Toiletten = 10,
                Sitzplaetze = 657,
                Antriebsart = Antriebsart.Elektro,
            };

            ZeigeZug(pz);
            GetBaguette(pz);

            GueterZug gz = new GueterZug()
            {
                Nummer = "54387",
                Baujahr = new DateTime(1978, 3, 5),
                MaxZuladung = 1001,
                Antriebsart = Antriebsart.Elektro | Antriebsart.PerHand
            };

            ZeigeZug(gz);
            GetBaguette(gz);
            

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        static void GetBaguette(IFrankreich ding)
        {
            Console.WriteLine(ding.GetBaguette());
        }

        static void ZeigeZug(Schienenfahrzeug zug)
        {
            Console.WriteLine($"{zug.Nummer} aus dem Jahr {zug.Baujahr:yyyy} " +
                              $"mit der Spurbreite {zug.Spurbreite} wir angetrieben per {(int)zug.Antriebsart} {zug.Antriebsart}");

            zug.Hupen();


            if (zug is PersonenZug)
            {
                PersonenZug pZug = (PersonenZug)zug;//casten
                Console.WriteLine($"\tIst ein PersonenZug mit {pZug.Sitzplaetze} Sitzenplätzen");
            }

            PersonenZug pZugBox = zug as PersonenZug; //boxing
            if (pZugBox != null)
            {
                Console.WriteLine($"\tIst ein PersonenZug mit {pZugBox.Sitzplaetze} Sitzenplätzen");
            }

            //ab VS2017 - pattern matchting
            if (zug is PersonenZug pZugg)
            {
                Console.WriteLine($"\tIst ein PersonenZug mit {pZugg.Sitzplaetze} Sitzenplätzen");
            }
        }
    }
}

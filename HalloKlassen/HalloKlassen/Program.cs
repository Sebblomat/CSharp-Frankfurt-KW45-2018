using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Hallo Klassen ****");

            int zahl;
            Zug meinZug = null; //deklaration
            meinZug = new Zug(); //instanzierung
            meinZug.Nummer= "ICE 1";
            meinZug.Wlan = true;
            meinZug.Antriebart = "elektrisch";
            ZeigeZug(meinZug);
            meinZug.Beschleuningen();
            meinZug.Beschleuningen();
            ZeigeZug(meinZug);
            
            Zug deinZug = new Zug();
            deinZug.Nummer = "ICE T";
            meinZug.Antriebart = "diesel";
            ZeigeZug(deinZug);

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        static void ZeigeZug(Zug zug)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"{zug.Nummer} {zug.Geschwindigkeit} km/h");
            Console.WriteLine("------------------------");

        }
    }
}

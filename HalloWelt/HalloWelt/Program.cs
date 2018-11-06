using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {
        /// <summary>
        /// Meine Main Methode 
        /// </summary>
        /// <param name="args">die eingabeparameter</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt");

            int zahl = 86 + 57 / 8 * 9;

            string text = "langer Text 🎃";
            char zeichen = 'b';

            bool einBool = true | false & true ^ true;

            double kommaZahl = zahl;
            kommaZahl = 1.75;
            int zahlJetztOhneKomma = (int)kommaZahl;
            Console.WriteLine(zahlJetztOhneKomma);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(zahl.ToString());

            Console.WriteLine("Gib mir eine Zahl:");
            string eingabe = Console.ReadLine();
            int eingabeAlsInt = int.Parse(eingabe);
            Console.WriteLine("Das doppelte ist:" + eingabeAlsInt * 2);
            string stringFormat = string.Format("Das doppelte von {0} ist {1}",
                eingabeAlsInt, eingabeAlsInt * 2);

            string stringInterpoliation = $"Das doppelte von {eingabeAlsInt} ist {eingabeAlsInt * 2}";

            Console.WriteLine(kommaZahl.ToString("0000.000", new CultureInfo("en-US")));

            Console.OutputEncoding = Encoding.UTF8; //dann wird das € angezeigt
            Console.WriteLine(kommaZahl.ToString("p"));

            DateTime einDatum = new DateTime(2000, 11, 24, 13, 53, 7);
            Console.WriteLine(einDatum);
            Console.WriteLine(DateTime.Now.ToString("yy yyyy - MM MMM MMMM - dd ddd dddd"));

            Console.ReadLine();
        }


    }
}

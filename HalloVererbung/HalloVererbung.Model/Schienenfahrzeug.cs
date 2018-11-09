using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloVererbung.Model
{
    public enum Antriebsart
    {
        Diesel = 1,
        Elektro = 2,
        PerHand = 4,
        Dampf = 8,
        Segel = 16,
        Warp = 32
    }

    public abstract class Schienenfahrzeug : Object
    {
        public abstract void Öffnen();

        public Antriebsart Antriebsart { get; set; }
        public string Nummer { get; set; }
        public DateTime Baujahr { get; set; }
        public int Spurbreite { get; set; } = 1435;

        public virtual void Hupen()
        {
            Console.WriteLine("Das Schienenfahrzeug hupt!");
            Console.Beep();
        }
    }

}

using System;

namespace HalloVererbung.Model
{
    public class PersonenZug : Schienenfahrzeug, IFrankreich, IOesterreich
    {
        public int Sitzplaetze { get; set; }
        public int Toiletten { get; set; }
        public bool Klimaanlage { get; set; }

        public int FRSpurbreite { get => Spurbreite / 2; set => Spurbreite = value * 2; }
        public int ATSpurbereite { get => Spurbreite * 2; set => Spurbreite = value / 2; }

        public void Alpenhorn()
        {
            Hupen();
        }

        public string GetBaguette()
        {
            return "1 Baguette";
        }

        public override void Hupen()
        {
            Console.WriteLine("PersonenZug hupt!");
            Console.Beep(600, 1000);
        }
    }
}

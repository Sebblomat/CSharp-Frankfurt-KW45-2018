using System;

namespace HalloVererbung.Model
{
    public class PersonenZug : Schienenfahrzeug
    {
        public int Sitzplaetze { get; set; }
        public int Toiletten { get; set; }
        public bool Klimaanlage { get; set; }

        public override void Hupen()
        {
            Console.WriteLine("PersonenZug hupt!");
            Console.Beep(600, 1000);
        }
    }
}

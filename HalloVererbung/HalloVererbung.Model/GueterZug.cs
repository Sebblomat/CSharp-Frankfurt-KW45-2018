using System;

namespace HalloVererbung.Model
{
    public class GueterZug : Schienenfahrzeug,IFrankreich
    {
        private int zuladung;

        public int Zuladung
        {
            get => zuladung;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Die Zuladung kann nicht negativ sein");

                if (MaxZuladung > 0 && value > MaxZuladung)
                    throw new ZulandungsFehlerException()
                    {
                        MaxZuläßigeZuladung = MaxZuladung,
                        ÜberschrittenUm = value - MaxZuladung
                    };


                zuladung = value;
            }
        }

        //public int ZuladungOLD
        //{
        //    get { return zuladung; }
        //    set
        //    {
        //        if (value <= MaxZuladung)
        //            zuladung = value;
        //    }
        //}

        public int MaxZuladung { get; set; }
        public int FRSpurbreite { get => Spurbreite / 2; set => Spurbreite = value * 2; }


        public string GetBaguette()
        {
            return "Leer";
        }

        public override void Hupen()
        {
            base.Hupen();
            Console.Beep(800, 400);
            Console.Beep(1100, 300);

        }

        public override void Öffnen()
        {
            Console.WriteLine("Tor öffnen");
        }
    }
}

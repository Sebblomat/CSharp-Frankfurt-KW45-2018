﻿using System;

namespace HalloVererbung.Model
{
    public class GueterZug : Schienenfahrzeug
    {
        private int zuladung;

        public int Zuladung
        {
            get => zuladung;
            set
            {
                if (value <= MaxZuladung)
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


        public override void Hupen()
        {
            base.Hupen();
            Console.Beep(800, 400);
            Console.Beep(1100, 300);

        }
    }
}
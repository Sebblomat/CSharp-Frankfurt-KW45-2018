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
    }
}

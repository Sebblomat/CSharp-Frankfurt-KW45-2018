using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloKlassen
{
    public class Zug
    {
        public Zug() //default ctor
        {
            AnzahlWagen = 3;
        }

        public Zug(string nummer)
        {
            Nummer = nummer;
        }

        public string Antriebart { get; set; }
        public double Laenge { get; set; }
        public int AnzahlWagen { get; set; }
        public int Hoechstgeschwindingkeit { get; set; }
        public DateTime Baujahr { get; set; }
        public string Name { get; set; }
        public string Nummer { get; set; }

        //backing field
        private bool wlan;

        //(full) Property
        public bool Wlan
        {
            get { return wlan; }
            set { wlan = value; }
        }


        //feld
        private int geschwindigkeit = 0;
        //(full)property
        public int Geschwindigkeit
        {
            get { return geschwindigkeit; }
            private set
            {
                if (value <= Hoechstgeschwindingkeit)
                    geschwindigkeit = value;
            }
        }
        //Getter Funktion
        //public int GetGeschwindigkeit()
        //{
        //    return geschwindingkeit;
        //}

        ////Setter Methode
        //public void SetGeschwindigkeit(int gesch)
        //{
        //    if (gesch < hoechstgeschwindingkeit)
        //        geschwindingkeit = gesch;
        //}

        public void Beschleuningen()
        {
            Geschwindigkeit += 50;
        }
        public void Bremsen()
        {
            geschwindigkeit -= 50;
        }
        public void Putzen()
        { }
        public void Reparieren()
        { }
    }
}

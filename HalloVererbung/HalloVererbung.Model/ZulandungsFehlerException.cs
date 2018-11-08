using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloVererbung.Model
{
    public class ZulandungsFehlerException : Exception
    {
        public int MaxZuläßigeZuladung { get; set; }
        public int ÜberschrittenUm { get; set; }
    }
}

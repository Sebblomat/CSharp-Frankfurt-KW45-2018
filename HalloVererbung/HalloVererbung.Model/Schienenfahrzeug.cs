using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloVererbung.Model
{
    public class Schienenfahrzeug
    {
        public string Nummer { get; set; }
        public DateTime Baujahr { get; set; }
        public int Spurbreite { get; set; } = 1435;
    }
}

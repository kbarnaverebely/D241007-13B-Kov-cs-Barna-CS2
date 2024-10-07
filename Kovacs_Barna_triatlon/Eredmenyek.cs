using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kovacs_Barna_triatlon
{
    internal class Eredmenyek
    {
        public string Nev { get; set; }
        public int Szulev { get; set; }
        public string Rajtszam { get; set; }
        public string Nem { get; set; }
        public string Kategoria { get; set; }
        public TimeOnly Uszasido { get; set; }
        public TimeOnly Elsoido { get; set; }
        public TimeOnly Kerekparido { get; set; }
        public TimeOnly Masodikido { get; set; }
        public TimeOnly Futasido { get; set; }
    }
   /* public override string ToString()
    {
        return $"{Nev} ({Szulev} Rajtszám: {Rajtszam}. {Kategoria})";
    }*/
}

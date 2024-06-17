using System;
using System.Text.Json;
using System.IO;

namespace Kopakabana
{
    public class Gra
    {
        public List<Druzyna> Druzyny { get; set; }
        public List<AbstractSedzia> Sedziowie { get; set; }
        public Druzyna Wygrany { get; set; }
        public string Wynik { get; set; }

        public Gra (Druzyna d1, Druzyna d2)
        {
            this.Druzyny = new List<Druzyna> ();
            this.Druzyny.Add(d1); 
            this.Druzyny.Add(d2);
        }
    }
}

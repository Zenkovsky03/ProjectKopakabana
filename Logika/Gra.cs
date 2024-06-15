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
    }
}

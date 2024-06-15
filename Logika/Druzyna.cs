using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Kopakabana
{
    public class Druzyna
    {
        public string Nazwa { get; set; }
        public int ZagraneMecze { get; set; }
        public int Wygrane { get; set; }
        public int Przegrane { get; set; }
        public int Remisy { get; set; }
        public int Punkty { get; set; }
        public List<Zawodnik> Zawodnicy { get; set; }

        public void ZaplanujGre()
        {
            // TODO:
        }

        public void DodajZawodnika(Zawodnik zawodnik)
        {
            this.Zawodnicy.Add(zawodnik);
        }

        public void UsunZawodnika(Zawodnik zawodnik) 
        {
            this.Zawodnicy.Remove(zawodnik);
        }
    }
}

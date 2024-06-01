using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Kopakabana
{
    class Druzyna
    {
        private int Id { get; set; }
        private string Nazwa { get; set; }
        private List<Zawodnik> Zawodnicy { get; set; }
        private int Zwyciestwa { get; set; } 

        public void ZaplanujGre()
        {
            // TODO:
        }

        public void ZapiszWynik()
        {
            var druzyna = new
            {
                Id,
                Nazwa,
                Zawodnicy,
                Zwyciestwa
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(druzyna, options);
            string fileName = $"Druzyna-{Id}-{Nazwa}.json";

            File.WriteAllText(fileName, json);
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

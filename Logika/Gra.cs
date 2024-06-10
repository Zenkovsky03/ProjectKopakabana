using System;

namespace Kopakabana
{
    class Gra
    {
        private int Id { get; set; }
        private DateTime Data { get; set; }
        private List<Druzyna> Druzyny { get; set; }
        private List<Sedzia> Sedziowie { get; set; }
        private string Wynik { get; set; }

        public void ZaplanujGre()
        {
            // TODO: 
        }
        
        public void ZapiszWynik()
        {
            var druzyna = new
            {
                Id,
                Data,
                Druzyny,
                Sedziowie,
                Wynik
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(druzyna, options);
            string fileName = $"Gra-{Id}-{Data}.json";

            File.WriteAllText(fileName, json);
        }
    }
}

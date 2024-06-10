using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Kopakabana
{
    class Turniej
    {
        private AbstractDyscyplina Dyscyplina { get; set; }
        private List<Druzyna> Druzyny { get; set; }
        private List<Sedzia> Sedziowie { get; set; }
        private List<Gra> Gry { get; set; }

        public void DodajDruzyne(Druzyna druzyna)
        {
            this.Druzyny.Add(druzyna);
        }

        public void UsunDruzyne(Druzyna druzyna)
        {
            this.Druzyny.Remove(druzyna);
        }

        public void ZglosDruzyne(Druzyna druzyna)
        {
            // TODO:
        }

        public void WycofajDruzyne(Druzyna druzyna)
        {
            // TODO:
        }

        public void PrzegladajDruzyne()
        {
            // TODO:
        }

        public void WycofajDruzyne(Gra gra)
        {
            // TODO:
        }

        public void WygenerujPolfinaly()
        {
            // TODO:
        }

        public void WygenerujFinaly()
        {
            // TODO:
        }

        public void WyswietlTabeleWynikow()
        {
            // TODO:
        }

        public void ZapiszStan(string plik)
        {
            var druzyna = new
            {
                Dyscyplina,
                Druzyny,
                Sedziowie,
                Gry
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(druzyna, options);
            string fileName = $"Turniej-{Dyscyplina.nazwa}.json";

            File.WriteAllText(fileName, json);
        }

        public void OdczytajStan(string plik)
        {
            string json = File.ReadAllText(plik);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var turniej = JsonSerializer.Deserialize<Turniej>(json, options);

            if (turniej != null)
            {
                Dyscyplina = turniej.Dyscyplina;
                Druzyny = turniej.Druzyny;
                Sedziowie = turniej.Sedziowie;
                Gry = turniej.Gry;
            }
        }
    }
}

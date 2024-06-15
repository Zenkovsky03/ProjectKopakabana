using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Kopakabana
{
    public class Turniej
    {
        public AbstractDyscyplina Dyscyplina { get; set; }
        public List<Druzyna> Druzyny { get; set; }
        public List<AbstractSedzia> Sedziowie { get; set; }
        public List<Gra> Gry { get; set; }

        public Turniej() { 
            this.Druzyny = new List<Druzyna>();
            this.Sedziowie = new List<AbstractSedzia>();
        }
        public void DodajDruzyne(Druzyna druzyna)
        {
            this.Druzyny.Add(druzyna);
        }

        public void UsunDruzyne(Druzyna druzyna)
        {
            this.Druzyny.Remove(druzyna);
        }

        public void DodajSedziego(AbstractSedzia Sedzia)
        {
            this.Sedziowie.Add(Sedzia);
        }

        public void UsunSedziego(AbstractSedzia Sedzia)
        {
            this.Sedziowie.Remove(Sedzia);
        }

        public void WygenerujGry()
        {
            // tutaj robisz cala magie tego generowania gier i ich wynikow z listy druzyn i sedziow
        }

        public void PrzegladajDruzyne()
        {
            // TODO:
        }

        public void WygenerujPolfinaly()
        {
            // TODO:
        }

        public void WyswietlTabeleWynikow()
        {
            // TODO:
        }

        public void ZapiszStan()
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
            string fileName = $"Turniej-{Dyscyplina}.json";

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

        public void wybierzDyscyplina(AbstractDyscyplina Dyscyplina)
        {
            this.Dyscyplina = Dyscyplina;
        }
    }
}

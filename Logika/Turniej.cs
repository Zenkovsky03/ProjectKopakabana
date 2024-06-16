using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;

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
            this.Gry = new List<Gra>();
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
            for(int i = 0; i < this.Druzyny.Count; i++)
            {
                for (int j = i + 1; j < this.Druzyny.Count; j++)
                {
                    this.Gry.Add(new Gra(this.Druzyny[i], this.Druzyny[j]));
                }
            }

            this.Gry = this.Gry.OrderBy(x => Random.Shared.Next()).ToList();
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
            var turniej = new
            {
                this.Druzyny,
                this.Sedziowie
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            DateTime localDateTime = DateTime.Now;
            string localTimestamp = localDateTime.ToString("yyyy-MM-dd--HH-mm");
            string json = JsonSerializer.Serialize(turniej, options);
            string fileName = $"Turniej-{this.Dyscyplina.Nazwa}-{localTimestamp}.json";

            File.WriteAllText(fileName, json);
        }

        public void OdczytajStan(string plik)
        {
            string json = File.ReadAllText(plik);

            var turniej = JsonSerializer.Deserialize<Turniej>(json);

            if (turniej != null)
            {
                this.Druzyny = turniej.Druzyny;
                this.Sedziowie = turniej.Sedziowie;
            }

        }

        public void wybierzDyscyplina(AbstractDyscyplina Dyscyplina)
        {
            this.Dyscyplina = Dyscyplina;
        }
    }
}

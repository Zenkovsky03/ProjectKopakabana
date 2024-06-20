using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Windows;

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

        public void ZapiszStan(string sciezka)
        {
            try
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

                DateTime dateTime = DateTime.Now;
                string aktualnyTimestamp = dateTime.ToString("yyyy-MM-dd--HH-mm");
                string json = JsonSerializer.Serialize(turniej, options);
                string pelnaSciezka = $"{sciezka}/Turniej-{this.Dyscyplina.Nazwa}-{aktualnyTimestamp}.json";

                File.WriteAllText(pelnaSciezka, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie uda³o siê zapisaæ danych do pliku. Spróbuj ponownie.");
            }
        }

        public void OdczytajStan(string plik)
        {
            try
            {
                string json = File.ReadAllText(plik);

                var turniej = JsonSerializer.Deserialize<Turniej>(json);

                if (turniej != null)
                {
                    this.Druzyny = turniej.Druzyny;
                    this.Sedziowie = turniej.Sedziowie;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void wybierzDyscyplina(AbstractDyscyplina Dyscyplina)
        {
            this.Dyscyplina = Dyscyplina;
        }
    }
}

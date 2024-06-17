using System;

namespace Kopakabana
{
    public class Zawodnik
    {
        Random random = new Random();
        public int Numer { get; set; }
        public string Imie { get; set; }

        public Zawodnik(string imie) { 
            this.Imie = imie;
            this.Numer = random.Next(1, 100);
        }
    }
}

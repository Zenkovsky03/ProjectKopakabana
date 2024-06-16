using System;

namespace Kopakabana
{
    public class AbstractSedzia
    {
        public string Imie { get; set; }
        public bool CzyGlowny { get; set; }

        public void setImie(string Imie)
        {
            this.Imie = Imie;
        }

        public void setCzyGlowny(bool Flaga)
        {
            this.CzyGlowny = Flaga;
        }
    }
}

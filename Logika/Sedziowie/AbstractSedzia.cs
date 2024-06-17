using System;

namespace Kopakabana
{
    public class AbstractSedzia
    {
        public string Imie { get; set; }
        public bool CzyGlowny { get; set; }

        public virtual void setImie(string Imie)
        {
            this.Imie = Imie;
        }

        public virtual void setCzyGlowny(bool Flaga)
        {
            this.CzyGlowny = Flaga;
        }
    }
}

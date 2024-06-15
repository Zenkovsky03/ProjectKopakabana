using System;

namespace Kopakabana
{
    public abstract class AbstractSedzia
    {
        public string Imie { get; set; }

        public void setImie(string Imie)
        {
            this.Imie = Imie;
        }
    }
}

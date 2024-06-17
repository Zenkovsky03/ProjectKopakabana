using Kopakabana;

namespace KopakabanaTests
{
    public class TurniejTest
    {
        [Fact]
        public void GenerowanieGierTest()
        {
            Turniej turniej = new Turniej();

            Druzyna druzyna1 = new Druzyna();
            Druzyna druzyna2 = new Druzyna();
            Druzyna druzyna3 = new Druzyna();
            turniej.DodajDruzyne(druzyna1);
            turniej.DodajDruzyne(druzyna2);
            turniej.DodajDruzyne(druzyna3);

            SedziaDwaOgnie sedzia = new SedziaDwaOgnie();
            turniej.DodajSedziego(sedzia);

            turniej.WygenerujGry();

            Assert.True(turniej.Gry.Count == 3);
        }
    }
}
using Kopakabana;

namespace KopakabanaTests
{
    public class GraTest
    {
        [Fact]
        public void StworzenieGryTest()
        {
            Druzyna druzyna1 = new Druzyna();
            Druzyna druzyna2 = new Druzyna();
            Gra gra = new Gra(druzyna1, druzyna2);

            Assert.True(gra.Druzyny.Count == 2);
        }
    }
}
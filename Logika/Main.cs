namespace Kopakabana 
{
    public class Program
    {
        public static void Main()
        {

            // 
            // TO DO WYDUPCENIA ALE NA CHWILE ZEBY MOZNA BYLO ODPALIC BEZ WPF
            // TODO:
            //


            var zawodnicy = new List<Zawodnik>
            {
                new Zawodnik { Id = 1, Imie = "Jan", Nazwisko = "Kowalski" },
                new Zawodnik { Id = 2, Imie = "Adam", Nazwisko = "Nowak" }
            };

            var druzyna = new Druzyna(1, "Orły", zawodnicy, 10);

            druzyna.ZapiszWynik();
            Console.WriteLine("Dane zapisane do pliku JSON.");
        }
    }
}

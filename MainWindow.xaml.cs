using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Kopakabana;


namespace Kopakabana
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Turniej Turniej { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            this.Turniej = new Turniej();
        }

        private void wybierzTurniejClick(object sender, RoutedEventArgs e)
        {
            WybierzTurniej wybierzTurniej = new WybierzTurniej();
            wybierzTurniej.Show();
            this.Close();
        }
        private void jakGracClick(object sender, RoutedEventArgs e)
        {
            ZasadyGryWindow zasadyGryWindow = new ZasadyGryWindow();
            zasadyGryWindow.Show();
            this.Close();
        }
        private void wyjdzClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /**
         * nie uzyte jeszcze, jak dodacie przyciski i rozne te widoki to dostosujcie to, w sensie w xamlu nadajcie Click= na te metody
         */
        private void wybierzDwaOgnieClick(object sender, RoutedEventArgs e)
        {
            this.Turniej.wybierzDyscyplina(new DwaOgnie());
        }

        /**
         * nie uzyte jeszcze, jak dodacie przycisk to dostosujcie to
         */
        private void wybierzPrzeciaganieLinyClick(object sender, RoutedEventArgs e)
        {
            this.Turniej.wybierzDyscyplina(new PrzeciaganieLiny());
        }

        /**
         * nie uzyte jeszcze, jak dodacie przycisk to dostosujcie to
         */
        private void wybierzWybierzSiatkowkePlazowaClick(object sender, RoutedEventArgs e)
        {
            this.Turniej.wybierzDyscyplina(new SiatkowkaPlazowa());
        }

        /**
         * wszystko nizej nie uzyte to zebym sie nie potwarzal TODO::::::
         */

        private void importDruzynyClick(object sender, RoutedEventArgs e)
        {
            // this.Turniej.importDruzyny.....
        }

        private void dodajDruzyneClick(object sender, RoutedEventArgs e)
        {
            // this.Turniej.DodajDruzyne....
        }

        private void importSedziegoClick(object sender, RoutedEventArgs e)
        {
            // this.Turniej
        }

        private void dodajSedziegoClick(object sender, RoutedEventArgs e)
        {
            // this.Turniej
        }

        private void wyjdzMenuDyscyplinyClick(object sender, RoutedEventArgs e)
        {
            // powrot do pierwotnego okna? nwm, tylko glosno mysle, albo wyjscie z calej apki idk
        }

        private void dodajZawodnikaClick(object sender, RoutedEventArgs e)
        {
            // dodanie zawodnika do listy zawodnikkow druzyny
        }

        private void zatwierdzDodawanieZawodnikowDoDruzynyClick(object sender, RoutedEventArgs e)
        {
            // czyli tam na diagramach jakby zatwierdz, bo wyzej metoda dodaje zawodnikow i jak sie skonczy dodawanie zawodnikow to teraz zatwierdzamy to
        }

        private void cofnijDodawanieDruzynyClick(object sender, RoutedEventArgs e)
        {
            // pewnie powrot do poprzedniego stanu widokow czyli do 4
        }

        /**
         * a tu jakby eventy dla widoku ktorego nie ma diagramu ale jest analogiczne do dodawania druzyny
         * generalnie moze jakichs eventow brakowac i w praniu wyjdzie ze wiecej ich trzeba bedzie bo dosyc ciezko robic tako bez namacalnego ustawiania ich od razu xd
         */
        private void zatwierdzDodawanieSedziowClick(object sender, RoutedEventArgs e)
        {
            // 
        }

        private void cofnijDodawanieSedziegoClick(object sender, RoutedEventArgs e)
        {
            // pewnie powrot do poprzedniego stanu widokow czyli do 4
        }

        private void dalejDoMenuSymulacjiClick(object sender, RoutedEventArgs e)
        {
            // do 7
        }

        private void symulujMeczClick(object sender, RoutedEventArgs e)
        {
            // SYMULACJA!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        private void symulujTabeleClick(object sender, RoutedEventArgs e)
        {
            // SYMULACJA!!!!!!!!!!!!!!!!!!!!!!!!!!
        }


    }
}
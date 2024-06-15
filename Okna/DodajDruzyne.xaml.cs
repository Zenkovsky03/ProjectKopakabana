using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kopakabana
{
    /// <summary>
    /// Logika interakcji dla klasy DodajDruzyne.xaml
    /// </summary>
    public partial class DodajDruzyne : Window
    {
        Turniej Turniej { get; set; }
        Druzyna Druzyna { get; set; }

        public DodajDruzyne(Turniej Turniej)
        {
            InitializeComponent();
            this.Turniej = Turniej;
            this.Druzyna = new Druzyna();

            if (zawodnik1 != null && zawodnik2 != null && zawodnik3 != null && zawodnik4 != null)
            {
                dodaj.IsEnabled = true;
            }
        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
            zarzadzaj.Show();
            this.Close();
        }

        private void DodajClick(object sender, RoutedEventArgs e)
        {
            this.Druzyna.DodajZawodnika(new Zawodnik(zawodnik1.Text));
            this.Druzyna.DodajZawodnika(new Zawodnik(zawodnik2.Text));
            this.Druzyna.DodajZawodnika(new Zawodnik(zawodnik3.Text));
            this.Druzyna.DodajZawodnika(new Zawodnik(zawodnik4.Text));
        }
    }
}

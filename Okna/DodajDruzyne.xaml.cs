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
        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
            zarzadzaj.Show();
            this.Close();
        }

        private void DodajClick(object sender, RoutedEventArgs e)
        {
            if (zawodnik1.Text == "" || zawodnik2.Text == "" || zawodnik3.Text == "" || zawodnik4.Text == "" || nazwaDruzyny.Text == "")
            {
                MessageBox.Show("Wszystkie pola musza byc uzupelnione");
            }else if (this.Turniej.Druzyny.Any(d => d.Nazwa == nazwaDruzyny.Text))
            {
                MessageBox.Show("Ta nazwa druzyny juz istnieje, wymysl cos innego");
            }
            else
            {
                this.Druzyna.Nazwa = nazwaDruzyny.Text;
                this.Druzyna.DodajZawodnika(new Zawodnik(zawodnik1.Text));
                this.Druzyna.DodajZawodnika(new Zawodnik(zawodnik2.Text));
                this.Druzyna.DodajZawodnika(new Zawodnik(zawodnik3.Text));
                this.Druzyna.DodajZawodnika(new Zawodnik(zawodnik4.Text));
                this.Turniej.DodajDruzyne(this.Druzyna);
                Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
                zarzadzaj.Show();
                this.Close();
            }

        }
    }
}

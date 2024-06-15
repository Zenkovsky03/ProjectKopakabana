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
    /// Logika interakcji dla klasy Zarzadzaj.xaml
    /// </summary>
    public partial class Zarzadzaj : Window
    {
        Turniej Turniej { get; set; }
        public Zarzadzaj(Turniej Turniej)
        {
            InitializeComponent();
            this.Turniej = Turniej;
            LoadData();
        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            WybierzTurniej wybierzTurniej = new WybierzTurniej();
            wybierzTurniej.Show();
            this.Close();
        }

        private void ImportClick(object sender, RoutedEventArgs e)
        {
            //importowanie danych
        }

        private void LoadData()
        {
            // TODO: w zaleznosci od dyscypliny inny sedzia
            var judges = new List<AbstractSedzia>
            {
                new SedziaGlownySiatkowka{ Imie = "Judge A" },
                new SedziaPomocnicznySiatkowka { Imie = "Judge B" },
                new SedziaPomocnicznySiatkowka { Imie = "Judge C" }
            };

            var teams = new List<Zawodnik>
            {
                new Zawodnik { Imie = "Team A" },
                new Zawodnik { Imie = "Team B" },
                new Zawodnik { Imie = "Team B" },
                new Zawodnik { Imie = "Team B" },
                new Zawodnik { Imie = "Team B" },
                new Zawodnik { Imie = "Team B" },
                new Zawodnik { Imie = "Team B" },
                new Zawodnik { Imie = "Team B" }
            };

            listaSedziow.ItemsSource = judges;
            ListaDruzyn.ItemsSource = teams;
        }

        private void EdytujSedziegoClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                EdytujSedziego edytuj = new EdytujSedziego();
                edytuj.Show();
                this.Close();
            }
        }

        private void UsunSedziegoClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string judgeName = button.Tag.ToString();
                MessageBox.Show($"Usun {judgeName}");
                // Implement your delete logic here
            }
        }

        private void EdytujDruzyneClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                EdytujDruzyne edytuj = new EdytujDruzyne();
                edytuj.Show();
                this.Close();
            }
        }

        private void UsunDruzyneClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string teamName = button.Tag.ToString();
                MessageBox.Show($"Usun {teamName}");
                // Implement your delete logic here
            }
        }

        private void DodajDruzyneClick(object sender, RoutedEventArgs e)
        {
            DodajDruzyne dodaj = new DodajDruzyne();
            dodaj.Show();
            this.Close();
        }

        private void DodajSedziegoClick(object sender, RoutedEventArgs e)
        {
            DodajSedziego dodaj = new DodajSedziego();
            this.Close();
            dodaj.Show();
        }

        private void RozpocznijTurniejClick(object sender, RoutedEventArgs e)
        {
            TurniejGlowny turniejGlowny = new TurniejGlowny(this.Turniej);
            turniejGlowny.Show();
            this.Close();
        }
    }
}

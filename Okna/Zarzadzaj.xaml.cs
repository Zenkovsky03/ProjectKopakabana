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
            if (this.Turniej.Druzyny != null && this.Turniej.Druzyny.Count == 6)
            {
                rozpocznij.IsEnabled = true;
                dodajDruzyne.IsEnabled = false;
            }
            if (this.Turniej.Sedziowie != null && this.Turniej.Sedziowie.Count == 6)
            {
                rozpocznij.IsEnabled = true;
                dodajSedziego.IsEnabled = false;
            }


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
            DodajDruzyne dodaj = new DodajDruzyne(this.Turniej);
            dodaj.Show();
            this.Close();
        }

        private void DodajSedziegoClick(object sender, RoutedEventArgs e)
        {
            DodajSedziego dodaj = new DodajSedziego();
            dodaj.Show();
            this.Close();
        }

        private void RozpocznijTurniejClick(object sender, RoutedEventArgs e)
        {
            TurniejGlowny turniejGlowny = new TurniejGlowny(this.Turniej);
            turniejGlowny.Show();
            this.Close();
        }
    }
}

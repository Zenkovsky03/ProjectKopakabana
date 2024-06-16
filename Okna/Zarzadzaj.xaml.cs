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
            SprawdzStan();
            ZaladujDane();

        }
        private void SprawdzStan()
        {
            if (this.Turniej.Druzyny != null && this.Turniej.Druzyny.Count == 6)
            {
                rozpocznij.IsEnabled = true;
                dodajDruzyne.IsEnabled = false;
            }
            else
            {
                rozpocznij.IsEnabled = false;
                dodajDruzyne.IsEnabled = true;
            }
            if (this.Turniej.Sedziowie != null && this.Turniej.Sedziowie.Count == 6)
            {
                rozpocznij.IsEnabled = true;
                dodajSedziego.IsEnabled = false;
            }
            else
            {
                rozpocznij.IsEnabled = false;
                dodajSedziego.IsEnabled = true;
            }
        }
        private void ZaladujDane()
        {
            ListaDruzyn.ItemsSource = null;
            ListaDruzyn.ItemsSource = this.Turniej.Druzyny;

            listaSedziow.ItemsSource = null;
            listaSedziow.ItemsSource = this.Turniej.Sedziowie;
        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            WybierzTurniej wybierzTurniej = new WybierzTurniej();
            wybierzTurniej.Show();
            this.Close();
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
                string imieSedziego = button.Tag.ToString();
                for (int i = 0; i < this.Turniej.Sedziowie.Count; i++)
                {
                    if (this.Turniej.Sedziowie[i].Imie == imieSedziego)
                        this.Turniej.UsunSedziego(this.Turniej.Sedziowie[i]);
                }

                MessageBox.Show($"Usunieto {imieSedziego}");
                SprawdzStan();
                ZaladujDane();
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
                string nazwaDruzyny = button.Tag.ToString();
                for(int i = 0; i < this.Turniej.Druzyny.Count; i++)
                {
                    if (this.Turniej.Druzyny[i].Nazwa == nazwaDruzyny)
                        this.Turniej.UsunDruzyne(this.Turniej.Druzyny[i]);
                }

                MessageBox.Show($"Usunieto {nazwaDruzyny}");
                SprawdzStan();
                ZaladujDane();
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
            DodajSedziego dodaj = new DodajSedziego(this.Turniej);
            dodaj.Show();
            this.Close();
        }

        private void RozpocznijTurniejClick(object sender, RoutedEventArgs e)
        {
            TurniejGlowny turniejGlowny = new TurniejGlowny(this.Turniej);
            turniejGlowny.Show();
            this.Close();
        }

        private void ZapiszDaneClick(object sender, RoutedEventArgs e)
        {
            this.Turniej.ZapiszStan();
        }

        private void WgrajDaneClick(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".json";
            dialog.Filter = "Json documents (.json)|*.json";
            bool? rezultat = dialog.ShowDialog();

            if (rezultat == true)
            {
                string plik = dialog.FileName;
                this.Turniej.OdczytajStan(plik);
            }
        }
    }
}

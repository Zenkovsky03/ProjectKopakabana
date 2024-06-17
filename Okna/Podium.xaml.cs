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
    /// Logika interakcji dla klasy Podium.xaml
    /// </summary>
    public partial class Podium : Window
    {
        Turniej Turniej { get; set; }
        Druzyna pierwsza;
        Druzyna druga;
        Druzyna trzecia;
        public Podium(Turniej turniej, Druzyna pierwsza, Druzyna druga, Druzyna trzecia)
        {
            InitializeComponent();
            this.Turniej = turniej;
            this.pierwsza = pierwsza;
            this.druga = druga;
            this.trzecia = trzecia;

            InicjalizujPodium();
        }

        private void InicjalizujPodium()
        {
            druzynaPierwsza.Text = this.pierwsza.Nazwa;
            druzynaDruga.Text = this.druga.Nazwa;
            druzynaTrzecia.Text = this.trzecia.Nazwa;
        }

        private void NowyTurniejClick(object sender, RoutedEventArgs e)
        {
            WybierzTurniej wybierzTurniej = new WybierzTurniej();
            wybierzTurniej.Show();
            this.Close();
        }
    }
}

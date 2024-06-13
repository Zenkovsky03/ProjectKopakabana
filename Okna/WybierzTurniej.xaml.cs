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
    /// Logika interakcji dla klasy WybierzTurniej.xaml
    /// </summary>
    public partial class WybierzTurniej : Window
    {
        Turniej Turniej { get; set; }
        public WybierzTurniej()
        {
            InitializeComponent();
            this.Turniej = new Turniej();
        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void WybierzSiatkowkePlazowaClick(object sender, RoutedEventArgs e)
        {
            this.Turniej.wybierzDyscyplina(new SiatkowkaPlazowa());
            PrzedStartem przedStartem = new PrzedStartem(this.Turniej);
            przedStartem.Show();
            this.Close();
        }

        private void WybierzPrzeciaganieLinyClick(object sender, RoutedEventArgs e)
        {
            this.Turniej.wybierzDyscyplina(new PrzeciaganieLiny());
            PrzedStartem przedStartem = new PrzedStartem(this.Turniej);
            przedStartem.Show();
            this.Close();
        }

        private void WybierzDwaOgnieClick(object sender, RoutedEventArgs e)
        {
            this.Turniej.wybierzDyscyplina(new DwaOgnie());
            PrzedStartem przedStartem = new PrzedStartem(this.Turniej);
            przedStartem.Show();
            this.Close();
        }
    }
}

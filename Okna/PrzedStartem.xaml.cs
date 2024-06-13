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
    /// Logika interakcji dla klasy PrzedStartem.xaml
    /// </summary>
    public partial class PrzedStartem : Window
    {
        Turniej Turniej { get; set; }
        public PrzedStartem(Turniej Turniej)
        {
            InitializeComponent();
            this.Turniej = Turniej;
        }

        private void RozpocznijClick(object sender, RoutedEventArgs e)
        {
            TurniejGlowny turniejGlowny = new TurniejGlowny(this.Turniej);
            turniejGlowny.Show();
            this.Close();
            
        }
        private void ZarzadzajClick(object sender, RoutedEventArgs e)
        {
            Zarzadzaj oknoZarzadzania = new Zarzadzaj(this.Turniej);
            oknoZarzadzania.Show();
            this.Close();
        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            WybierzTurniej wybierzTurniej = new WybierzTurniej();
            wybierzTurniej.Show();
            this.Close();
        }
    }
}

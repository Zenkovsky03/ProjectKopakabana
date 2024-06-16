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
    /// WYBIERZ TUNRIEJ
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
            SiatkowkaPlazowa siatkowka = new SiatkowkaPlazowa();
            siatkowka.Nazwa = "Siatkowka";
            this.Turniej.wybierzDyscyplina(siatkowka);
            Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
            zarzadzaj.Show();
            this.Close();
        }

        private void WybierzPrzeciaganieLinyClick(object sender, RoutedEventArgs e)
        {
            PrzeciaganieLiny przeciaganieLiny = new PrzeciaganieLiny();
            przeciaganieLiny.Nazwa = "Przeciaganie liny";
            this.Turniej.wybierzDyscyplina(przeciaganieLiny);
            Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
            zarzadzaj.Show();
            this.Close();
        }

        private void WybierzDwaOgnieClick(object sender, RoutedEventArgs e)
        {
            DwaOgnie dwaOgnie = new DwaOgnie();
            dwaOgnie.Nazwa = "Dwa ognie";
            this.Turniej.wybierzDyscyplina(dwaOgnie);
            Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
            zarzadzaj.Show();
            this.Close();
        }
    }
}

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
    /// Logika interakcji dla klasy DodajSedziego.xaml
    /// </summary>
    public partial class DodajSedziego : Window
    {
        Turniej Turniej { get; set; }

        public DodajSedziego(Turniej Turniej)
        {
            InitializeComponent();
            this.Turniej = Turniej;
            if (this.Turniej.Dyscyplina is SiatkowkaPlazowa) 
            {
                SedziaGlownySiatkowka glowny = new SedziaGlownySiatkowka();
                SedziaPomocnicznySiatkowka pomocniczy = new SedziaPomocnicznySiatkowka();
            }
            else if (this.Turniej.Dyscyplina is DwaOgnie)
            {
                SedziaDwaOgnie glowny = new SedziaDwaOgnie();
            }
            else if (this.Turniej.Dyscyplina is PrzeciaganieLiny)
            {
                SedziaPrzeciaganieLiny glowny = new SedziaPrzeciaganieLiny();
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
            //logika edycji druzyny
        }
    }
}

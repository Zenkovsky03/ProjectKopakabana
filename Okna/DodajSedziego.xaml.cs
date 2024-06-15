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
                sprawdz.Visibility = Visibility.Visible;
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
            if (imie.Text == "")
                MessageBox.Show("Musisz uzupelnic dane ");
            else
            {
                if (this.Turniej.Dyscyplina is SiatkowkaPlazowa)
                {

                    if (sprawdz.IsChecked == true)
                    {
                        SedziaGlownySiatkowka glowny = new SedziaGlownySiatkowka();
                        glowny.setImie(imie.Text.ToString());
                        this.Turniej.DodajSedziego(glowny);
                        sprawdz.IsChecked = false;
                    }
                    else
                    {
                        SedziaPomocnicznySiatkowka pomocniczy = new SedziaPomocnicznySiatkowka();
                        pomocniczy.setImie(imie.Text.ToString());
                        this.Turniej.DodajSedziego(pomocniczy);
                    }
                }
                if (this.Turniej.Dyscyplina is DwaOgnie)
                {
                    SedziaDwaOgnie dwaOgnieSedzia = new SedziaDwaOgnie();
                    dwaOgnieSedzia.setImie(imie.Text.ToString());
                    this.Turniej.DodajSedziego(dwaOgnieSedzia);
                }
                if (this.Turniej.Dyscyplina is PrzeciaganieLiny)
                {
                    SedziaPrzeciaganieLiny przeciagnieSedzia = new SedziaPrzeciaganieLiny();
                    przeciagnieSedzia.setImie(imie.Text.ToString());
                    this.Turniej.DodajSedziego(przeciagnieSedzia);
                }
                Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
                zarzadzaj.Show();
                this.Close();
            }
            
        }
    }
}

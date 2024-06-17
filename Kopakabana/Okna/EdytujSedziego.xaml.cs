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
    /// Logika interakcji dla klasy EdytujSedziego.xaml
    /// </summary>
    public partial class EdytujSedziego : Window
    {
        Turniej Turniej { get; set; }
        string zapisaneImie { get; set; }

        public EdytujSedziego(Turniej Turniej, AbstractSedzia Sedzia)
        {
            InitializeComponent();
            this.Turniej = Turniej;
            edytujImie.Text = Sedzia.Imie.ToString();
            zapisaneImie = Sedzia.Imie.ToString();
        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
            this.Close();
            zarzadzaj.Show();
        }

        private void EdytujClick(object sender, RoutedEventArgs e)
        {
            if (edytujImie.Text == "")
                MessageBox.Show("Musisz uzupelnic dane ");
            else
            {
                AbstractSedzia edytowanySedzia = Turniej.Sedziowie.FirstOrDefault(s => s.Imie == this.zapisaneImie);

                if (edytowanySedzia != null)
                {
                    edytowanySedzia.Imie = edytujImie.Text;
                }
                Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
                zarzadzaj.Show();
                this.Close();
            }
        }
    }
}

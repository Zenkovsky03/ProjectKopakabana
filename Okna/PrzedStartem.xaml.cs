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
        public PrzedStartem()
        {
            InitializeComponent();
        }

        private void RozpocznijClick(object sender, RoutedEventArgs e)
        {
            TurniejOkno turniejOkno = new TurniejOkno();
            turniejOkno.Show();
            this.Close();
            
        }
        private void ZarzadzajClick(object sender, RoutedEventArgs e)
        {
            Zarzadzaj oknoZarzadzania = new Zarzadzaj();
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

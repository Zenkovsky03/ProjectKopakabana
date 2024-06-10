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
        public WybierzTurniej()
        {
            InitializeComponent();
        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //przycisk siatkowka
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //przycisk przeciagnie liny
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //przycisk dwa ognie
        }
    }
}

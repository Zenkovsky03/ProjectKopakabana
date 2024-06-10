using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kopakabana
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void wybierzTurniejClick(object sender, RoutedEventArgs e)
        {
            Turniej turniej = new Turniej();
            turniej.wybierzDyscyplina(new DwaOgnie());

        }

        private void jakGracClick(object sender, RoutedEventArgs e)
        {

        }
        private void wyjdzClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
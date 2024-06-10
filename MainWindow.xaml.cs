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
using Kopakabana;


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
            WybierzTurniej wybierzTurniej = new WybierzTurniej();
            wybierzTurniej.Show();
            this.Close();
        }

        private void wybierzDwaOgnie(object sender, RoutedEventArgs e)
        {
            Turniej turniej = new Turniej();

            turniej.wybierzDyscyplina(new DwaOgnie());

        }



        private void jakGracClick(object sender, RoutedEventArgs e)
        {
            ZasadyGryWindow zasadyGryWindow = new ZasadyGryWindow();
            zasadyGryWindow.Show();
            this.Close();

        }
        private void wyjdzClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
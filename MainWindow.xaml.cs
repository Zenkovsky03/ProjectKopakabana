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
    /// GLOWNE MENU
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WybierzTurniejClick(object sender, RoutedEventArgs e)
        {
            WybierzTurniej wybierzTurniej = new WybierzTurniej();
            wybierzTurniej.Show();
            this.Close();
        }
        private void JakGracClick(object sender, RoutedEventArgs e)
        {
            ZasadyGry zasadyGry = new ZasadyGry();
            zasadyGry.Show();
            this.Close();
        }
        private void WyjdzClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
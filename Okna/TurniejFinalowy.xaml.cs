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
    /// Logika interakcji dla klasy TurniejFinalowy.xaml
    /// </summary>
    public partial class TurniejFinalowy : Window
    {
        public TurniejFinalowy()
        {
            InitializeComponent();
        }

        private void PodiumClick(object sender, RoutedEventArgs e)
        {
            Podium podium = new Podium();
            podium.Show();
            this.Close();
        }

        
    }
}

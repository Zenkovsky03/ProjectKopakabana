using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Kopakabana
{
    public partial class TurniejGlowny : Window
    {
        Turniej Turniej { get; set; }
        public TurniejGlowny(Turniej Turniej)
        {
            InitializeComponent();
            this.Turniej = Turniej;
            LoadData();
        }

        private void LoadData()
        {
            var Druzyny = new List<Druzyna>
            {
                new Druzyna { Nazwa = "Druzyna A", ZagraneMecze = 10, Wygrane = 6, Przegrane = 2, Remisy = 2, Punkty = 20 },
                new Druzyna { Nazwa = "Druzyna B", ZagraneMecze = 10, Wygrane = 5, Przegrane = 3, Remisy = 2, Punkty = 17 },
                new Druzyna { Nazwa = "Druzyna C", ZagraneMecze = 10, Wygrane = 4, Przegrane = 4, Remisy = 2, Punkty = 14 },
                new Druzyna { Nazwa = "Druzyna D", ZagraneMecze = 10, Wygrane = 3, Przegrane = 5, Remisy = 2, Punkty = 11 },
                new Druzyna { Nazwa = "Druzyna E", ZagraneMecze = 10, Wygrane = 2, Przegrane = 6, Remisy = 2, Punkty = 8 }
            };

            dataGrid.ItemsSource = Druzyny;
        }

        private void TurniejFinalowyClick(object sender, RoutedEventArgs e)
        {
            TurniejFinalowy finaly = new TurniejFinalowy();
            finaly.Show();
            this.Close();
        }
    }
}

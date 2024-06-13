using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Kopakabana
{
    public partial class TurniejGlowny : Window
    {
        public TurniejGlowny()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var teams = new List<Team>
            {
                new Team { TeamName = "Team A", MatchesPlayed = 10, Wins = 6, Losses = 2, Draws = 2, Points = 20 },
                new Team { TeamName = "Team B", MatchesPlayed = 10, Wins = 5, Losses = 3, Draws = 2, Points = 17 },
                new Team { TeamName = "Team C", MatchesPlayed = 10, Wins = 4, Losses = 4, Draws = 2, Points = 14 },
                new Team { TeamName = "Team D", MatchesPlayed = 10, Wins = 3, Losses = 5, Draws = 2, Points = 11 },
                new Team { TeamName = "Team E", MatchesPlayed = 10, Wins = 2, Losses = 6, Draws = 2, Points = 8 }
            };

            dataGrid.ItemsSource = teams;
        }

        private void TurniejFinalowyClick(object sender, RoutedEventArgs e)
        {
            TurniejFinalowy finaly = new TurniejFinalowy();
            finaly.Show();
            this.Close();
        }
    }

    public class Team
    {
        public string TeamName { get; set; }
        public int MatchesPlayed { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int Points { get; set; }
    }
}

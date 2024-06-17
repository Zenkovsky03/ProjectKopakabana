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
using System.Linq;

namespace Kopakabana
{
    /// <summary>
    /// Logika interakcji dla klasy TurniejFinalowy.xaml
    /// </summary>
    public partial class TurniejFinalowy : Window
    {
        Turniej Turniej { get; set; }

        Druzyna finalista1;
        Druzyna finalista2;
        Druzyna drugieMiejsce;
        Druzyna zwyciezcaFinal;

        Druzyna druzynaBraz1;
        Druzyna druzynaBraz2;
        Druzyna zwyciezcaBraz;

        private int numerMeczu;
        private int iloscMeczyRozegranych;
        public TurniejFinalowy(Turniej Turniej)
        {
            InitializeComponent();
            this.Turniej = Turniej;
            this.numerMeczu = this.Turniej.Gry.Count;
            this.iloscMeczyRozegranych = this.Turniej.Gry.Count;
            PosortujDruzyny();
            InicjujDrabinke();
        }

        private void PosortujDruzyny()
        {
            this.Turniej.Druzyny = this.Turniej.Druzyny.OrderByDescending(d => d.Punkty).ToList();
        }

        private void InicjujDrabinke()
        {
            polfinal1.Text = this.Turniej.Druzyny[0].Nazwa;
            polfinal2.Text = this.Turniej.Druzyny[3].Nazwa;
            polfinal3.Text = this.Turniej.Druzyny[1].Nazwa;
            polfinal4.Text = this.Turniej.Druzyny[2].Nazwa;

            this.Turniej.Gry.Add(new Gra(this.Turniej.Druzyny[0], this.Turniej.Druzyny[3]));
            this.Turniej.Gry.Add(new Gra(this.Turniej.Druzyny[1], this.Turniej.Druzyny[2]));


            RozpocznijMecz(this.numerMeczu);
        }

        private void RozpocznijMecz(int numerMeczu)
        {
            symulujMeczBtn.IsEnabled = true;

            Druzyna d1 = this.Turniej.Gry[numerMeczu].Druzyny[0];
            Druzyna d2 = this.Turniej.Gry[numerMeczu].Druzyny[1];

            druzyna1.Text = d1.Nazwa;
            druzyna2.Text = d2.Nazwa;

            wynik1.Text = "0";
            wynik2.Text = "0";

            if (symulujMeczBtn.IsEnabled)
            {
                kolejnyMeczBtn.IsEnabled = false;
            }

        }

        private void LosujWynik(int numerMeczu)
        {
            Druzyna d1 = this.Turniej.Gry[numerMeczu].Druzyny[0];
            Druzyna d2 = this.Turniej.Gry[numerMeczu].Druzyny[1];

            d1.ZagraneMecze += 1;
            d2.ZagraneMecze += 1;

            Druzyna wygrana;
            Druzyna przegrana;

            if (Random.Shared.Next(0, 2) == 0) // 0 - pierwsza druzyna wygrala, 1 - druga druzyna wygrala
            {
                wynik1.Text = "2";
                d1.Wygrane += 1;
                d2.Przegrane += 1;
                int setyDrugiejDruzyny = Random.Shared.Next(0, 2);
                wynik2.Text = setyDrugiejDruzyny.ToString();
                d1.Punkty += (3 - setyDrugiejDruzyny);
                d2.Punkty += setyDrugiejDruzyny;
                wygrana = d1;
                przegrana = d2;
            }
            else
            {
                wynik2.Text = "2";
                d2.Wygrane += 1;
                d1.Przegrane += 1;
                int setyDrugiejDruzyny = Random.Shared.Next(0, 2);
                wynik1.Text = setyDrugiejDruzyny.ToString();
                d2.Punkty += (3 - setyDrugiejDruzyny);
                d1.Punkty += setyDrugiejDruzyny;
                wygrana = d2;
                przegrana = d1;
            }

            symulujMeczBtn.IsEnabled = false;

            int numerMeczuFinalowego = this.numerMeczu - this.iloscMeczyRozegranych;

            switch (numerMeczuFinalowego)
            {
                case 0:
                    {
                        finalista1 = wygrana;
                        druzynaBraz1 = przegrana;

                        final1.Text = finalista1.Nazwa;
                        braz1.Text = druzynaBraz1.Nazwa;
                    }
                    break;
                case 1:
                    {
                        finalista2 = wygrana;
                        druzynaBraz2 = przegrana;

                        final2.Text = finalista2.Nazwa;
                        braz2.Text = druzynaBraz2.Nazwa;

                        this.Turniej.Gry.Add(new Gra(finalista1, finalista2));
                        this.Turniej.Gry.Add(new Gra(druzynaBraz1, druzynaBraz2));
                    }
                    break;
                case 2:
                    {
                        zwyciezca.Text = wygrana.Nazwa;
                        zwyciezcaFinal = wygrana;
                        drugieMiejsce = przegrana;
                    }
                break;
                case 3:
                    {
                        brazZwyciezca.Text = wygrana.Nazwa;
                        zwyciezcaBraz = wygrana;
                    }
                break;
            }

            this.numerMeczu += 1;
        }

        private void LosujWynikiMeczuClick(object sender, RoutedEventArgs e)
        {
            if (this.numerMeczu == this.iloscMeczyRozegranych + 3)
            {
                kolejnyMeczBtn.IsEnabled = false;
                pokazPodiumBtn.IsEnabled = true;
                symulujDrabinkeBtn.IsEnabled = false;
            }
            else kolejnyMeczBtn.IsEnabled = true;

            LosujWynik(this.numerMeczu);
        }

        private void RozegrajNastepnyMeczClick(object sender, RoutedEventArgs e)
        {
            RozpocznijMecz(this.numerMeczu);
        }

        private async void SymulujDrabinkeClick(object sender, RoutedEventArgs e)
        {
            symulujDrabinkeBtn.IsEnabled = false;

            for (int i = this.numerMeczu; i < this.iloscMeczyRozegranych + 4; i++)
            {
                RozpocznijMecz(i);
                LosujWynik(i);

                await Task.Delay(500);
            }

            pokazPodiumBtn.IsEnabled = true;
        }
        private void PodiumClick(object sender, RoutedEventArgs e)
        {
            Podium podium = new Podium(this.Turniej, zwyciezcaFinal, drugieMiejsce, zwyciezcaBraz);
            podium.Show();
            this.Close();
        }

        
    }
}

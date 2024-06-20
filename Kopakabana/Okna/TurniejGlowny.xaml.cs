using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Threading.Tasks;

namespace Kopakabana
{
    public partial class TurniejGlowny : Window
    {
        Turniej Turniej { get; set; }

        private int numerMeczu;
        public TurniejGlowny(Turniej Turniej)
        {
            InitializeComponent();
            this.Turniej = Turniej;
            this.numerMeczu = 0;
            this.Turniej.WygenerujGry();
            ZaladujDane();
            RozpocznijMecz(this.numerMeczu);
            nazwaTurnieju.Text = "Turniej: " + this.Turniej.Dyscyplina.Nazwa;
        }

        private void ZaladujDane()
        {
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = this.Turniej.Druzyny;

            PosortujDane("Punkty", ListSortDirection.Descending);
        }
        private void PosortujDane(string sortBy, ListSortDirection direction)
        {
            var collectionView = CollectionViewSource.GetDefaultView(dataGrid.ItemsSource);
            if (collectionView != null)
            {
                collectionView.SortDescriptions.Clear();
                collectionView.SortDescriptions.Add(new SortDescription(sortBy, direction));
                collectionView.Refresh();
            }
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

            sedziowie.Text = LosujSedziego();
        }

        private string LosujSedziego()
        {
            Random random = new Random();
            string sedzia = "";

            var sedziowieGlowni = this.Turniej.Sedziowie.Where(s => s.CzyGlowny).ToList();
            var sedziowieAsystenci = this.Turniej.Sedziowie.Where(s => !s.CzyGlowny).ToList();

            if (this.Turniej.Dyscyplina is SiatkowkaPlazowa)
            {
                string sedziaGlowny = sedziowieGlowni[random.Next(sedziowieGlowni.Count)].Imie;

                HashSet<int> indeksySedziowAsystentow = new HashSet<int>();
                while (indeksySedziowAsystentow.Count < 2)
                {
                    indeksySedziowAsystentow.Add(random.Next(sedziowieAsystenci.Count));
                }

                sedzia = $"Sedziowie: {sedziaGlowny} (glowny), {sedziowieAsystenci[indeksySedziowAsystentow.ElementAt(0)].Imie}, {sedziowieAsystenci[indeksySedziowAsystentow.ElementAt(1)].Imie}";
            } else
            {
                sedzia = $"Sedzia: {this.Turniej.Sedziowie[random.Next(this.Turniej.Sedziowie.Count)].Imie}";
            }

            return sedzia;
        }

        private void LosujWynik(int numerMeczu)
        {
            Druzyna d1 = this.Turniej.Gry[numerMeczu].Druzyny[0];
            Druzyna d2 = this.Turniej.Gry[numerMeczu].Druzyny[1];

            d1.ZagraneMecze += 1;
            d2.ZagraneMecze += 1;

            if (Random.Shared.Next(0, 2) == 0) // 0 - pierwsza druzyna wygrala, 1 - druga druzyna wygrala
            {
                wynik1.Text = "2";
                d1.Wygrane += 1;
                d2.Przegrane += 1;
                int setyDrugiejDruzyny = Random.Shared.Next(0, 2);
                wynik2.Text = setyDrugiejDruzyny.ToString();
                d1.Punkty += (3 - setyDrugiejDruzyny);
                d2.Punkty += setyDrugiejDruzyny;
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
            }

            symulujMeczBtn.IsEnabled = false;
            ZaladujDane();

            this.numerMeczu += 1;
        }

        private void LosujWynikiMeczuClick(object sender, RoutedEventArgs e)
        {
            if (this.numerMeczu  == this.Turniej.Gry.Count - 1)
            {
                kolejnyMeczBtn.IsEnabled = false;
                przejdzFinalyBtn.IsEnabled = true;
            } else kolejnyMeczBtn.IsEnabled = true;

            LosujWynik(this.numerMeczu);
        }

        private void RozegrajNastepnyMeczClick(object sender, RoutedEventArgs e)
        {
            RozpocznijMecz(this.numerMeczu);
        }

        private async void SymulujTabeleClick(object sender, RoutedEventArgs e)
        {
            symulujTabeleBtn.IsEnabled = false;

            for (int i = this.numerMeczu; i < this.Turniej.Gry.Count; i++)
            {
                RozpocznijMecz(i);
                LosujWynik(i);

                await Task.Delay(500);
            }

            przejdzFinalyBtn.IsEnabled = true;
        }

        private void TurniejFinalowyClick(object sender, RoutedEventArgs e)
        {
            TurniejFinalowy finaly = new TurniejFinalowy(this.Turniej);
            finaly.Show();
            this.Close();
        }
    }
}

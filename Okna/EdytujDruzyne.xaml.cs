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
    /// Logika interakcji dla klasy DodajDruzyne.xaml
    /// </summary>
    public partial class EdytujDruzyne : Window
    {
        Turniej Turniej { get; set; }
        Druzyna Druzyna { get; set; }

        public EdytujDruzyne(Turniej Turniej, Druzyna Druzyna)
        {
            InitializeComponent();
            this.Turniej = Turniej;
            this.Druzyna = Druzyna;
            edytujNazwaDruzyny.Text = this.Druzyna.Nazwa;
            Edytujzawodnik1.Text = this.Druzyna.Zawodnicy[0].Imie.ToString();
            Edytujzawodnik2.Text = this.Druzyna.Zawodnicy[1].Imie.ToString();
            Edytujzawodnik3.Text = this.Druzyna.Zawodnicy[2].Imie.ToString();
            Edytujzawodnik4.Text = this.Druzyna.Zawodnicy[3].Imie.ToString();

        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
            this.Close();
            zarzadzaj.Show();
        }

        private void EdytujClick(object sender, RoutedEventArgs e)
        {
            if (Edytujzawodnik1.Text == "" || Edytujzawodnik2.Text == "" || Edytujzawodnik3.Text == "" || Edytujzawodnik4.Text == "" || edytujNazwaDruzyny.Text == "")
            {
                MessageBox.Show("Wszystkie pola musza byc uzupelnione");
            }
            else if (this.Turniej.Druzyny
                .Where(d => d != this.Druzyna) 
                .Any(d => d.Nazwa == edytujNazwaDruzyny.Text))
            {
                MessageBox.Show("Ta nazwa druzyny juz istnieje, wymysl cos innego");
            }
            else
            {
                this.Druzyna.Nazwa = edytujNazwaDruzyny.Text;
                this.Druzyna.Zawodnicy[0].Imie = Edytujzawodnik1.Text;
                this.Druzyna.Zawodnicy[1].Imie = Edytujzawodnik2.Text;
                this.Druzyna.Zawodnicy[2].Imie = Edytujzawodnik3.Text;
                this.Druzyna.Zawodnicy[3].Imie = Edytujzawodnik4.Text;
                Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
                zarzadzaj.Show();
                this.Close();
            }
        }
    }
}

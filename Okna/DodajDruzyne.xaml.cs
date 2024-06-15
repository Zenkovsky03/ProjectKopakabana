﻿using System;
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
    public partial class DodajDruzyne : Window
    {
        Turniej Turniej { get; set; }

        public DodajDruzyne()
        {
            InitializeComponent();
            this.Turniej = Turniej;
        }

        private void CofnijClick(object sender, RoutedEventArgs e)
        {
            Zarzadzaj zarzadzaj = new Zarzadzaj(this.Turniej);
            this.Close();
            zarzadzaj.Show();
        }

        private void DodajClick(object sender, RoutedEventArgs e)
        {
            //logika dodania druzyny
        }
    }
}

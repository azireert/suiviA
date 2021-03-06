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

namespace AppliFraisGSB
{
    /// <summary>
    /// Logique d'interaction pour HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            
            InitializeComponent();
            profil.Content = AppContextUtility.Nom +" "+ AppContextUtility.Prenom;
            if (AppContextUtility.Role != "secretaire")
            {
                CardCabinet.Visibility = Visibility.Hidden;
                CardDoctor.Visibility = Visibility.Hidden;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoctorWindow main = new DoctorWindow();
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CabinetWindow main = new CabinetWindow();
            App.Current.MainWindow = main;
            this.Close();
            main.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StatistiqueWindow main = new StatistiqueWindow();
            App.Current.MainWindow = main;
            this.Close();
            main.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            VisiteWindow main = new VisiteWindow();
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }

        private void Deconnexion(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
        }
    }
}

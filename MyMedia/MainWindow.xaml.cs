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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TMDbClient;

namespace MyMedia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TmDbClient _tmDbClient;

        public MainWindow()
        {
            InitializeComponent();

            _tmDbClient = new TmDbClient();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            List<TmDbClient.Film> films = await _tmDbClient.GetFilmsByName("Blade");
        }
    }
}

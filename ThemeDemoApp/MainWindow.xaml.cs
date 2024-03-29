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

namespace ThemeDemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }    

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new LoginPage());
            
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new ContactPage());
        }

        private void CustomControls_Click(object sender, RoutedEventArgs e)
        {
            _NavigationFrame.Navigate(new CustomControls());
        }
    }
}

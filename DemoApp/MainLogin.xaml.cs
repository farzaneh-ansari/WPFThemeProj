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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThemeDemo.IpipeCore;

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainLogin : Window
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void Default_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ApplyTheme("Default");
        }
        private void Summer_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.ApplyTheme("Summer");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ThemeDemo.Theme.ColorsGenerator
{
    public static class IpipeColors
    {
        readonly static  ResourceDictionary dictionary = new ResourceDictionary();
       // static string uriString = "pack://application:,,,/ThemeDemo.Theme.Spring;component/ResourceDictionary/ColorResources.xaml";
       static string uriString = "pack://application:,,,/ThemeDemo.Theme.ColorsGenerator;component/ResourceDictionary/DefaultColorTheme.xaml";

        //Change the color as dynamic resource
        private static Color ApplicationBackground => Colors.Peru; //(Color)dictionary[nameof(ApplicationBackground)];
        private static Color ApplicationForeground => (Color)dictionary[nameof(ApplicationForeground)];
        private static Color VortalBaseColor1 => (Color)dictionary[nameof(VortalBaseColor1)];
        private static Color VortalBaseColor3 => (Color)dictionary[nameof(VortalBaseColor3)];
        static IpipeColors()
        {
            dictionary.Source = new Uri(uriString, UriKind.RelativeOrAbsolute);

            dictionary[nameof(ApplicationBackgroundBrush)] = new SolidColorBrush(ApplicationBackground);
            dictionary[nameof(ApplicationForegroundBrush)] = new SolidColorBrush(ApplicationForeground);
            dictionary[nameof(HeaderGradientBrush)] = new LinearGradientBrush(VortalBaseColor1, VortalBaseColor3, new Point(0, 0), new Point(0, 1));
        }      

        public static SolidColorBrush ApplicationForegroundBrush => (SolidColorBrush)dictionary[nameof(ApplicationForegroundBrush)];
        public static SolidColorBrush ApplicationBackgroundBrush => (SolidColorBrush)dictionary[nameof(ApplicationBackgroundBrush)];
        public static GradientBrush HeaderGradientBrush => (GradientBrush)dictionary[nameof(HeaderGradientBrush)];
      
    }
}

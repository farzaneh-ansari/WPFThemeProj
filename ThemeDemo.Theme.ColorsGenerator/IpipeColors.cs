using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ThemeDemo.Theme.ColorsGenerator
{
    public static class IpipeColors
    {
       static readonly ResourceDictionary IpipeDic = new ResourceDictionary();
       // static string uriString = "pack://application:,,,/ThemeDemo.Theme.ColorsGenerator;component/ResourceDictionary/Colors/Green.xaml";
       static string uriString = "pack://application:,,,/ThemeDemo.Theme.ColorsGenerator;component/ResourceDictionary/DefaultColorTheme.xaml";

        //Change the color as dynamic resource
        private static Color ApplicationBackground => (Color)IpipeDic[nameof(ApplicationBackground)];//Colors.Peru;
        private static Color ApplicationForeground => (Color)IpipeDic[nameof(ApplicationForeground)];
        private static Color VortalBaseColor1 => (Color)IpipeDic[nameof(VortalBaseColor1)];
        private static Color VortalBaseColor3 => (Color)IpipeDic[nameof(VortalBaseColor3)];
        public static Color VortalBaseColor4 => (Color)IpipeDic[nameof(VortalBaseColor4)];
        public static Color VortalBaseColor5 => (Color)IpipeDic[nameof(VortalBaseColor5)];
        private static Color VortalBaseColor7 => (Color)IpipeDic[nameof(VortalBaseColor7)];
        private static Color VortalBaseColor705 => (Color)IpipeDic[nameof(VortalBaseColor705)];

        public static string IpipeTheme => "Default";

        //public static string IpipeTheme
        //{
        //    get => _ipipeTheme = "Default" ;
        //    set => _ipipeTheme = value;
        //}      

       // public static ResourceDictionary IpipeDic;
        //public static ResourceDictionary IpipeDic { get; set; }
        static IpipeColors()
        {
             IpipeDic.Source = new Uri(uriString, UriKind.RelativeOrAbsolute);                       
             AddBrush();            
        }      

        public static SolidColorBrush ApplicationForegroundBrush => (SolidColorBrush)IpipeDic[nameof(ApplicationForegroundBrush)];
        public static SolidColorBrush ApplicationBackgroundBrush => (SolidColorBrush)IpipeDic[nameof(ApplicationBackgroundBrush)];
        public static SolidColorBrush TextBoxBackgroundBrush => (SolidColorBrush)IpipeDic[nameof(TextBoxBackgroundBrush)];
        public static SolidColorBrush TextBoxForegroundBrush => (SolidColorBrush)IpipeDic[nameof(TextBoxForegroundBrush)];
        public static SolidColorBrush TextBoxBorderBrush => (SolidColorBrush)IpipeDic[nameof(TextBoxBorderBrush)];
        public static SolidColorBrush TextBoxSelectionBrush => (SolidColorBrush)IpipeDic[nameof(TextBoxSelectionBrush)];

        public static SolidColorBrush ButtonForegroundBrush => (SolidColorBrush)IpipeDic[nameof(ButtonForegroundBrush)];
        public static SolidColorBrush ButtonBackgroundBrush => (SolidColorBrush)IpipeDic[nameof(ButtonBackgroundBrush)];
        public static SolidColorBrush ButtonBorderBrush => (SolidColorBrush)IpipeDic[nameof(ButtonBorderBrush)];
        public static SolidColorBrush ButtonMouseOverBrush => (SolidColorBrush)IpipeDic[nameof(ButtonMouseOverBrush)];        
        public static SolidColorBrush ButtonPressedBrush => (SolidColorBrush)IpipeDic[nameof(ButtonPressedBrush)];

        public static SolidColorBrush ControlDisabledForegroundBrush => (SolidColorBrush)IpipeDic[nameof(ControlDisabledForegroundBrush)];
        public static SolidColorBrush ControlDisabledBackgroundBrush => (SolidColorBrush)IpipeDic[nameof(ControlDisabledBackgroundBrush)];
        public static SolidColorBrush ControlDisabledBorderBrush => (SolidColorBrush)IpipeDic[nameof(ControlDisabledBorderBrush)];

        public static GradientBrush HeaderGradientBrush => (GradientBrush)IpipeDic[nameof(HeaderGradientBrush)];

        public static void AddBrush()
        {
            IpipeDic[nameof(ApplicationBackgroundBrush)] = new SolidColorBrush(ApplicationBackground);
            IpipeDic[nameof(ApplicationForegroundBrush)] = new SolidColorBrush(ApplicationForeground);

            IpipeDic[nameof(HeaderGradientBrush)] = new LinearGradientBrush(VortalBaseColor1, VortalBaseColor3, new Point(0, 0), new Point(0, 1));


            IpipeDic[nameof(TextBoxBackgroundBrush)] = new SolidColorBrush(VortalBaseColor3);
            IpipeDic[nameof(TextBoxBorderBrush)] = new SolidColorBrush(VortalBaseColor4);
            IpipeDic[nameof(TextBoxForegroundBrush)] = new SolidColorBrush(VortalBaseColor7);
            IpipeDic[nameof(TextBoxSelectionBrush)] = new SolidColorBrush(VortalBaseColor705);


            IpipeDic[nameof(ButtonForegroundBrush)] = new SolidColorBrush(VortalBaseColor7);
            IpipeDic[nameof(ButtonBackgroundBrush)] = new SolidColorBrush(VortalBaseColor3);
            IpipeDic[nameof(ButtonBorderBrush)] = new SolidColorBrush(VortalBaseColor4);
            IpipeDic[nameof(ButtonMouseOverBrush)] = new SolidColorBrush(VortalBaseColor4);            
            IpipeDic[nameof(ButtonPressedBrush)] = new SolidColorBrush(VortalBaseColor5);

            IpipeDic[nameof(ControlDisabledForegroundBrush)] = new SolidColorBrush(VortalBaseColor5);
            IpipeDic[nameof(ControlDisabledBackgroundBrush)] = new SolidColorBrush(VortalBaseColor1);            
            IpipeDic[nameof(ControlDisabledBorderBrush)] = new SolidColorBrush(VortalBaseColor1);//#333333 should convert

        }    
    }    
}

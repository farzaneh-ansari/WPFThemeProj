using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ThemeDemo.Theme.ColorsGenerator
{
    public class Aquarium : Control
    {
        public static readonly DependencyProperty HasFishProperty =
            DependencyProperty.Register(
                name: "HasFish",
                propertyType: typeof(bool),
                ownerType: typeof(Aquarium),
                typeMetadata: new FrameworkPropertyMetadata(defaultValue: false));

        public bool HasFish
        {
            get => (bool)GetValue(HasFishProperty);
            set => SetValue(HasFishProperty, value);
        }
    }

    public class ThemeControl
    {
        public static readonly DependencyProperty ThemeNameProperty =
            DependencyProperty.RegisterAttached(
                name: "ThemeName",
                propertyType: typeof(string),
                ownerType: typeof(ThemeControl),
                new FrameworkPropertyMetadata(string.Empty, new PropertyChangedCallback(ValueChangedCallback)));


        public static string GetThemeName(DependencyObject o)
        {
            return (string)o.GetValue(ThemeNameProperty);
        }

        public static void SetThemeName(DependencyObject o, string themeName)
        {
            o.SetValue(ThemeNameProperty, themeName);
        }
        private static void ValueChangedCallback(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            string value = (string)args.NewValue;
            //ThemeManager.ApplyTheme(value);
        }
        public static void PropChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var value = e.NewValue;

        }
        public ThemeControl()
        {
        }

    }
}

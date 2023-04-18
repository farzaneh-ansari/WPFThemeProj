using System;
using System.Reflection;
using System.Windows;

namespace ThemeDemo.IpipeCore
{
    public static class ThemeManager
    {
        public static event EventHandler ThemeChanged;

        public static string CurrentTheme
        {
            get;
            private set;
        }      

        public static ResourceDictionary CurrentDictionary { get; } = new ResourceDictionary();
        public static void ApplyTheme(string themeName)
        {
            CurrentTheme = themeName;
            if (!string.IsNullOrEmpty(themeName))
            {
                CurrentDictionary.Clear();
                CurrentDictionary.MergedDictionaries.Add(GetThemeDictionary(themeName));

                ThemeChanged?.Invoke(null, EventArgs.Empty);
            }
        }
        private static ResourceDictionary GetThemeDictionary(string themeName)
        {
            var libName = Assembly.GetExecutingAssembly().GetName().Name;
            string packUri = $@"/ThemeDemo.Theme.{themeName};component/Theme.xaml";
            var uri = new Uri(packUri, UriKind.Relative);
            return (ResourceDictionary)Application.LoadComponent(uri);
        }      
               
    }
}

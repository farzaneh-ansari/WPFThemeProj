using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ThemeDemo.Theme.ColorsGenerator
{
    public static class ThemeManager
    {
        public static string CurrentTheme
        {
            get;
            private set;
        }

        public static ResourceDictionary CurrentDictionary
        {
            get;
            private set;
        }

        public static ResourceDictionary Controls
        {
            get;
            private set;
        }

        public static ResourceDictionary GetThemeResourceDictionary(string themeName)
        {
            var libName = Assembly.GetExecutingAssembly().GetName().Name;            
            string packUri = String.Format(@"/ThemeDemo.Theme.{0};component/ResourceDictionary/Colors/{1}.xaml", themeName, themeName);
            var uri = new Uri(packUri, UriKind.Relative);
            return (ResourceDictionary)Application.LoadComponent(uri);
        }

        public static ResourceDictionary GetControlsResourceDictionary(string controlName)
        {
            var libName = Assembly.GetExecutingAssembly().GetName().Name;
            string packUri = String.Format(@"/ThemeDemo.Theme.BaseControls;component/ResourceDictionary/BaseControlStyles/{0}.xaml", controlName);
            var uri = new Uri(packUri, UriKind.Relative);
            return (ResourceDictionary)Application.LoadComponent(uri);
        }
        public static void ApplyTheme(string themeName)
        {
            CurrentTheme = themeName;
            if (themeName != null)
            {    
                CurrentDictionary = GetThemeResourceDictionary(themeName);
                IpipeColors.AddBrush();
                LaodAllControls("AllControls");
            }

        }

        public static void LaodAllControls(string controlName)
        {
             Controls = GetControlsResourceDictionary(controlName);           
            
        }
    }
}

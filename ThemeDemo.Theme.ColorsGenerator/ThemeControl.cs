using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace ThemeDemo.Theme.ColorsGenerator
{  

    public sealed class ThemeDictionary : ResourceDictionary
    {
        public string ThemeName
        {
            get => ThemeManager.CurrentTheme;
            set
                {
                ThemeManager.ApplyTheme(value);
                MergedDictionaries.Clear();
                MergedDictionaries.Add(ThemeManager.CurrentDictionary);
                MergedDictionaries.Add(ThemeManager.Controls);
            }
        }
    }
}

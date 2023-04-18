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

namespace ThemeDemo.IpipeCore
{

    public sealed class ThemeDictionary : ResourceDictionary
    {
        public string ThemeName
        {
            get => ThemeManager.CurrentTheme;
            set => ThemeManager.ApplyTheme(value);
        }

        public ThemeDictionary()
        {
            ThemeManager.ThemeChanged += ThemeManager_ThemeChanged;
            SetCurrentTheme();
        }

        private void SetCurrentTheme()
        {
            MergedDictionaries.Clear();

            if (ThemeManager.CurrentDictionary is not null)
            {
                MergedDictionaries.Add(ThemeManager.CurrentDictionary);
            }
        }

        private void ThemeManager_ThemeChanged(object? sender, EventArgs e)
        {
            SetCurrentTheme();
        }
    }
}

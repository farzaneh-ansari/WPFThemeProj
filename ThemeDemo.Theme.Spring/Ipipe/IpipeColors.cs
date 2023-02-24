using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace ThemeDemo.Theme.Spring.Ipipe
{
    internal enum ipipeKnownColors : uint
    { AliceBlueBrush = 0xFFF0F8FF, }

    internal static class IpipeColors 
    {
        readonly static ResourceDictionary dictionary = new ResourceDictionary();
        static IpipeColors()
        {
            dictionary[nameof(AliceBlueBrush)] = Color.FromArgb((byte)((uint)ipipeKnownColors.AliceBlueBrush >> 24 & 0xFF),
                   (byte)((uint)ipipeKnownColors.AliceBlueBrush >> 16 & 0xFF),
                   (byte)((uint)ipipeKnownColors.AliceBlueBrush >> 8 & 0xFF),
                   (byte)((uint)ipipeKnownColors.AliceBlueBrush & 0xFF));
        }
        public static Color AliceBlueBrush => (Color)dictionary[nameof(AliceBlueBrush)];
    }
    public static class IpipeBrushes 
    {
        readonly static ResourceDictionary dictionary = new ResourceDictionary();
        static IpipeBrushes()
        {           
            dictionary[nameof(AliceBlueBrush)] = new SolidColorBrush(IpipeColors.AliceBlueBrush);            
        }
        public static Brush AliceBlueBrush => (Brush)dictionary[nameof(AliceBlueBrush)];       
    }






}

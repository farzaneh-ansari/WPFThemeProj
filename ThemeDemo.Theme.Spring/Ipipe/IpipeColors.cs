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
    {
        AliceBlueBrush = 0xFFF0F8FF,
        AntiqueWhiteBrush = 0xFFFAEBD7,
        AquaBrush = 0xFF00FFFF,
    }

    internal static class IpipeColors 
    {
        readonly static ResourceDictionary dictionary = new ResourceDictionary();
        static IpipeColors()
        {        
            dictionary[nameof(AliceBlueBrush)] = UIntToColor((uint)ipipeKnownColors.AliceBlueBrush);          
            dictionary[nameof(AntiqueWhiteBrush)] = UIntToColor((uint)ipipeKnownColors.AntiqueWhiteBrush);
            dictionary[nameof(AquaBrush)] = UIntToColor((uint)ipipeKnownColors.AquaBrush);
        }
        public static Color AliceBlueBrush => (Color)dictionary[nameof(AliceBlueBrush)];
        public static Color AntiqueWhiteBrush => (Color)dictionary[nameof(AntiqueWhiteBrush)];
        public static Color AquaBrush => (Color)dictionary[nameof(AquaBrush)];

        private static Color UIntToColor(uint color)
        {
            byte a = (byte)(color >> 24);
            byte r = (byte)(color >> 16);
            byte g = (byte)(color >> 8);
            byte b = (byte)(color >> 0);
            return Color.FromArgb(a, r, g, b);
        }

        private static uint ColorToUInt(Color color)
        {
            return (uint)((color.A << 24) | (color.R << 16) |
                          (color.G << 8) | (color.B << 0));
        }
    }
    public static class IpipeBrushes 
    {
        readonly static ResourceDictionary dictionary = new ResourceDictionary();
        static IpipeBrushes()
        {           
            dictionary[nameof(AliceBlueBrush)] = new SolidColorBrush(IpipeColors.AliceBlueBrush);
            dictionary[nameof(AntiqueWhiteBrush)] = new SolidColorBrush(IpipeColors.AntiqueWhiteBrush);            
        }
        public static Brush AliceBlueBrush => (Brush)dictionary[nameof(AliceBlueBrush)];
        public static Brush AntiqueWhiteBrush => (Brush)dictionary[nameof(AntiqueWhiteBrush)];
    }

    public static class IpipeLinearGradientBrushes
    {
        readonly static ResourceDictionary dictionary = new ResourceDictionary();
        static IpipeLinearGradientBrushes()
        {            
            dictionary[nameof(AntiqueWhiteAquaBrush)] = new LinearGradientBrush(IpipeColors.AntiqueWhiteBrush, IpipeColors.AquaBrush, 100);
        }
        public static Brush AntiqueWhiteAquaBrush => (Brush)dictionary[nameof(AntiqueWhiteAquaBrush)];        
    }
}

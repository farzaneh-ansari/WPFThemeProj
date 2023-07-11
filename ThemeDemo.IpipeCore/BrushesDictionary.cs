using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace ThemeDemo.IpipeCore
{
    //[Ambient]
    //[UsableDuringInitialization(true)]
    public sealed class BrushesDictionary : ResourceDictionary
    {
        public BrushesDictionary()
        {
        }

        public new Uri Source
        {
            get => base.Source;
            set
            {
                base.Source = value;
                UpdateBrushes();
            }
        }

        //Change the color as dynamic resource
        private Color ApplicationBackground => (Color)this[nameof(ApplicationBackground)];//Colors.Peru;
        private Color ApplicationForeground => (Color)this[nameof(ApplicationForeground)];
        private Color VortalBaseColor1 => (Color)this[nameof(VortalBaseColor1)];
        private Color VortalBaseColor3 => (Color)this[nameof(VortalBaseColor3)];
        public Color VortalBaseColor4 => (Color)this[nameof(VortalBaseColor4)];
        public Color VortalBaseColor5 => (Color)this[nameof(VortalBaseColor5)];
        private Color VortalBaseColor7 => (Color)this[nameof(VortalBaseColor7)];
        private Color VortalBaseColor705 => (Color)this[nameof(VortalBaseColor705)];

        public SolidColorBrush ApplicationForegroundBrush => (SolidColorBrush)this[nameof(ApplicationForegroundBrush)];
        public SolidColorBrush ApplicationBackgroundBrush => (SolidColorBrush)this[nameof(ApplicationBackgroundBrush)];
        public SolidColorBrush TextBoxBackgroundBrush => (SolidColorBrush)this[nameof(TextBoxBackgroundBrush)];
        public SolidColorBrush TextBoxForegroundBrush => (SolidColorBrush)this[nameof(TextBoxForegroundBrush)];
        public SolidColorBrush TextBoxBorderBrush => (SolidColorBrush)this[nameof(TextBoxBorderBrush)];
        public SolidColorBrush TextBoxSelectionBrush => (SolidColorBrush)this[nameof(TextBoxSelectionBrush)];

        public SolidColorBrush ButtonForegroundBrush => (SolidColorBrush)this[nameof(ButtonForegroundBrush)];
        public SolidColorBrush ButtonBackgroundBrush => (SolidColorBrush)this[nameof(ButtonBackgroundBrush)];
        public SolidColorBrush ButtonBorderBrush => (SolidColorBrush)this[nameof(ButtonBorderBrush)];
        public SolidColorBrush ButtonMouseOverBrush => (SolidColorBrush)this[nameof(ButtonMouseOverBrush)];
        public SolidColorBrush ButtonPressedBrush => (SolidColorBrush)this[nameof(ButtonPressedBrush)];

        public SolidColorBrush ControlDisabledForegroundBrush => (SolidColorBrush)this[nameof(ControlDisabledForegroundBrush)];
        public SolidColorBrush ControlDisabledBackgroundBrush => (SolidColorBrush)this[nameof(ControlDisabledBackgroundBrush)];
        public SolidColorBrush ControlDisabledBorderBrush => (SolidColorBrush)this[nameof(ControlDisabledBorderBrush)];

        public LinearGradientBrush HeaderGradientBrush => (LinearGradientBrush)this[nameof(HeaderGradientBrush)];
             

        void UpdateBrushes()
        {
            this[nameof(ApplicationBackgroundBrush)] = new SolidColorBrush(ApplicationBackground);
            this[nameof(ApplicationForegroundBrush)] = new SolidColorBrush(ApplicationForeground);

            GradientStopCollection wfGradientStopCollection = new GradientStopCollection { 
                new GradientStop(VortalBaseColor7, 0.0),
                new GradientStop(Colors.Transparent, 0.5),
                new GradientStop(VortalBaseColor7, 1.0)
            };

            LinearGradientBrush wfLinearGradientBrush = new LinearGradientBrush(wfGradientStopCollection, new Point(0, 0),new Point(1, 0));           
            RotateTransform rt = new RotateTransform(0, 0.5, 0.5);           
            wfLinearGradientBrush.RelativeTransform = rt;
            this[nameof(HeaderGradientBrush)] = wfLinearGradientBrush;//new LinearGradientBrush(VortalBaseColor1, VortalBaseColor3, new Point(0, 0), new Point(0, 1));


            this[nameof(TextBoxBackgroundBrush)] = new SolidColorBrush(VortalBaseColor3);
            this[nameof(TextBoxBorderBrush)] = new SolidColorBrush(VortalBaseColor4);
            this[nameof(TextBoxForegroundBrush)] = new SolidColorBrush(VortalBaseColor7);
            this[nameof(TextBoxSelectionBrush)] = new SolidColorBrush(VortalBaseColor705);

            ButtonBrush();
            
            this[nameof(ControlDisabledForegroundBrush)] = new SolidColorBrush(VortalBaseColor5);
            this[nameof(ControlDisabledBackgroundBrush)] = new SolidColorBrush(VortalBaseColor1);
            this[nameof(ControlDisabledBorderBrush)] = new SolidColorBrush(VortalBaseColor1);//#333333 should convert
        }
        void ButtonBrush()
        {
            this[nameof(ButtonForegroundBrush)] = new SolidColorBrush(VortalBaseColor7);
            this[nameof(ButtonBackgroundBrush)] = new SolidColorBrush(VortalBaseColor3);
            this[nameof(ButtonBorderBrush)] = new SolidColorBrush(VortalBaseColor4);
            this[nameof(ButtonMouseOverBrush)] = new SolidColorBrush(VortalBaseColor4);
            this[nameof(ButtonPressedBrush)] = new SolidColorBrush(VortalBaseColor5);

        }
    }
}

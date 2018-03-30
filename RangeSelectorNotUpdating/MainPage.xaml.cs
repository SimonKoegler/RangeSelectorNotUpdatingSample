using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace RangeSelectorNotUpdating
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public double RangeMin
        {
            get { return (double)GetValue(RangeMinProperty); }
            set { SetValue(RangeMinProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RangeMin.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RangeMinProperty =
            DependencyProperty.Register("RangeMin", typeof(double), typeof(MainPage), new PropertyMetadata(0.0));
        

        public double RangeMax
        {
            get { return (double)GetValue(RangeMaxProperty); }
            set { SetValue(RangeMaxProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RangeMax.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RangeMaxProperty =
            DependencyProperty.Register("RangeMax", typeof(double), typeof(MainPage), new PropertyMetadata(100.0));


    }
}

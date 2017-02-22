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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ConverterApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void markkaeuro_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(markat.Text);
            double euro = value * 5.94573;
            toEuro.Text = euro.ToString("0.0000");
        }

        private void euromarkka_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(eurot.Text);
            double markka = value / 5.94573;
            toMarkka.Text = markka.ToString("0.0000");
        }

        private void textBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock_SelectionChanged_2(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void textBlock2_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}

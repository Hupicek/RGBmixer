using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RGBmixer
{
    public partial class MainWindow : Window
    {


        private void sliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int hodnotaR = (int)sliderR.Value;
            int hodnotaG = (int)sliderG.Value;
            int hodnotaB = (int)sliderB.Value;

            BarvaL.Background = new SolidColorBrush(Color.FromRgb((byte)hodnotaR, (byte)hodnotaG, (byte)hodnotaB));
        }
        private void sliderG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int hodnotaR = (int)sliderR.Value;
            int hodnotaG = (int)sliderG.Value;
            int hodnotaB = (int)sliderB.Value;

            BarvaL.Background = new SolidColorBrush(Color.FromRgb((byte)hodnotaR, (byte)hodnotaG, (byte)hodnotaB));
        }
        private void sliderB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int hodnotaR = (int)sliderR.Value;
            int hodnotaG = (int)sliderG.Value;
            int hodnotaB = (int)sliderB.Value;

            BarvaL.Background = new SolidColorBrush(Color.FromRgb((byte)hodnotaR, (byte)hodnotaG, (byte)hodnotaB));
        }

        private void sliderR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<T> e)
        {

        }
    }
}
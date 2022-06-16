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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ProyectoLanzadorDescriptor
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void maui1(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(typeof(Page1));
        }

        private void maui2(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(typeof(Page2));
        }

        private void maui3(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(typeof(Page3));
        }

        private void maui4(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(typeof(Page4));
        }

        private void btnSignature_Click(object sender, RoutedEventArgs e)
        {
            var msg = new Windows.UI.Popups.MessageDialog("Cruz Lara Luis Ángel\nBoleta: 2019301685\nNL: 6\nGrupo:8CM11");
            msg.ShowAsync();
        }
    }
}

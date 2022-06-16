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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WUimagenes
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

        private void btnSignature_Click(object sender, RoutedEventArgs e)
        {
            var msg = new Windows.UI.Popups.MessageDialog("Cruz Lara Luis Ángel\nBoleta: 2019301685\nNL: 6\nGrupo:8CM11");
            msg.ShowAsync();
        }

        private void btnPage1_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(typeof(BlankPage1));
        }

        private void btnPage2_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(typeof(BlankPage2));
        }

        private void btnPage3_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(typeof(BlankPage3));
        }

        private void btnPage4_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(typeof(BlankPage4));
        }

        private void btnPage5_Click(object sender, RoutedEventArgs e)
        {
            this.frame.Navigate(typeof(BlankPage5));
        }
    }
}

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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WUimagenes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage4 : Page
    {
        public BlankPage4()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Content = mainPage;
        }

        private void btn_play_Click(object sender, RoutedEventArgs e)
        {
            video.Play();
        }

        private void btn_pause_Click(object sender, RoutedEventArgs e)
        {
            video.Pause();
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            video.Stop();
        }
    }
}

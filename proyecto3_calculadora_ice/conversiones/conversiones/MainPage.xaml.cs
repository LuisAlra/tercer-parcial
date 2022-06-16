using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace conversiones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_conversiones(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new conversiones());
        }

        private void firma(object sender, EventArgs e)
        {
            DisplayAlert("Firma", "Cruz Lara Luis Ángel\nBoleta: 2019301685\nNL: 6\nGrupo:8CM11", "ok");
        }
    }
}

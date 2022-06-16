using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lanzador_XF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void firma(object sender, EventArgs e)
        {
            DisplayAlert("Firma", "Cruz Lara Luis Ángel\nBoleta: 2019301685\nNL: 6\nGrupo:8CM11", "ok");
        }

        private async void practicas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        private async void proyectos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        private async void examen(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private async void ciclo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        private async void notas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
    }
}

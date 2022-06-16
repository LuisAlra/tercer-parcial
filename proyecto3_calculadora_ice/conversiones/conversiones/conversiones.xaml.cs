using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace conversiones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class conversiones : ContentPage
    {
        double km2m, m2km, g2kg, kg2g, r2g, i2m, mi2m, output;      

        public conversiones()
        {
            InitializeComponent();
        }

        private void btn_r2g(object sender, EventArgs e)
        {
            try
            {
                r2g = double.Parse(r2gInput.Text);
                output = r2g * 180;
                r2gOutput.Text = $"{output} grados";
            }
            catch
            {
                DisplayAlert("Ingrese solo números válidos", "", "ok");
            }
        }

        private void btn_i2m(object sender, EventArgs e)
        {
            try
            {
                i2m = double.Parse(i2mInput.Text);
                output = i2m * 2.54;
                i2cmOutput.Text = $"{output} centimetros";
                i2mOutput.Text = $"{output / 100} metros";
            }
            catch
            {
                DisplayAlert("Ingrese solo números válidos", "", "ok");
            }
        }

        private void btn_mi2m(object sender, EventArgs e)
        {
            try
            {
                mi2m = double.Parse(mi2mInput.Text);
                output = mi2m * 1609;
                mi2mOutput.Text = $"{output} metros";
                mi2kmOutput.Text = $"{output / 1000} kilometros";
            }
            catch
            {
                DisplayAlert("Ingrese solo números válidos", "", "ok");
            }
        }

        private void btn_g2kg(object sender, EventArgs e)
        {
            try
            {
                g2kg = double.Parse(g2kgInput.Text);
                output = (g2kg * 1000000) / 1000;
                g2kgOutput.Text = $"{output} kg/m^3";
            }
            catch
            {
                DisplayAlert("Ingrese solo números válidos", "", "ok");
            }
        }
        private void btn_kg2g(object sender, EventArgs e)
        {
            try
            {
                kg2g = double.Parse(kg2gInput.Text);
                output = (kg2g * 1000) / 1000000;
                kg2gOutput.Text = $"{output} g/cm^3";
            }
            catch
            {
                DisplayAlert("Ingrese solo números válidos", "", "ok");
            }
        }

        private void btn_m2km(object sender, EventArgs e)
        {
            try
            {
                m2km = double.Parse(m2kmInput.Text);
                output = (m2km * 3600) / 1000;
                m2kmOutput.Text = $"{output} m/s";
            }
            catch
            {
                DisplayAlert("Ingrese solo números válidos", "", "ok");
            }
        }

        private void btn_km2m(object sender, EventArgs e)
        {
            try
            {
                km2m = double.Parse(km2mInput.Text);
                output = (km2m * 1000) / 3600;
                km2mOutput.Text = $"{output} km/h";
            }
            catch
            {
                DisplayAlert("Ingrese solo números válidos", "", "ok");
            }
        }
    }
}
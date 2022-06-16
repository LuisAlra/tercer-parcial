using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace XFessentials02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagBrujula : ContentPage
    {
        SensorSpeed vel = SensorSpeed.UI;

        public PagBrujula()
        {
            InitializeComponent();
        }

        private void Btactivar(object sender, EventArgs e)
        {
            if (Compass.IsMonitoring) return;
            Compass.ReadingChanged += Lectura;
            Compass.Start(vel);
        }

        private void Lectura(object sender, CompassChangedEventArgs e)
        {
            resul.Text = $"Al norte: {e.Reading.HeadingMagneticNorth.ToString()} grados";
        }

        private void Btdesactivar(object sender, EventArgs e)
        {
            if (!Compass.IsMonitoring) return;
            Compass.ReadingChanged -= Lectura;
            Compass.Stop();
        }
    }
}
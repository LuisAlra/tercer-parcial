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
    public partial class PagAcelerometro : ContentPage
    {
        SensorSpeed vel = SensorSpeed.UI;

        public PagAcelerometro()
        {
            InitializeComponent();
        }

        private void Btactivar(object sender, EventArgs e)
        {
            if (Accelerometer.IsMonitoring) return;

            Accelerometer.ReadingChanged += Lectura;
            Accelerometer.Start(vel);
        }

        private void Lectura (object sender, AccelerometerChangedEventArgs e)
        {
            x.Text = $"x: {e.Reading.Acceleration.X} ";
            y.Text = $"y: {e.Reading.Acceleration.Y} ";
            z.Text = $"z: {e.Reading.Acceleration.Z} ";
        }

        private void Btdesactivar(object sender, EventArgs e)
        {
            if (!Accelerometer.IsMonitoring) return;
            Accelerometer.ReadingChanged -= Lectura;
            Accelerometer.Stop();
        }
    }
}
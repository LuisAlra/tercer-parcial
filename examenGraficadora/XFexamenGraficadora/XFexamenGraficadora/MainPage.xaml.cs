using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using info.lundin.math;

namespace XFexamenGraficadora
{
    public partial class MainPage : ContentPage
    {
        double xi, xf, n, x, y, angle, magnitude;

        private void signature(object sender, EventArgs e)
        {
            DisplayAlert("Firma", "Cruz Lara Luis Ángel, 8CM11", "Ok");
        }

        string fxFunction;
        List<ChartEntry> entries = new List<ChartEntry> 
        {          
        };

        public MainPage()
        {
            InitializeComponent();
        }

        public void inputProcess()
        {
            try
            {
                xi = double.Parse(xiInput.Text) * 10;
                xf = double.Parse(xfInput.Text) * 10;
                fxFunction = fxInput.Text;
                n = chartView.Width;
            }
            catch
            {
                DisplayAlert("Error", "Ingrese únicamente números o funciones válidos en los respectivos valores de entrada", "Ok");
            }
        }

        public double parseFunction(double x, string fx)
        {
            ExpressionParser parser = new ExpressionParser();
            parser.Values.Add("x", x);
            return parser.Parse(fx);
        }

        public void drawChart()
        {
            var chart = new LineChart { Entries = entries };
            chart.BackgroundColor = SKColor.Parse("#00FFFFFF");
            chartView.Chart = chart;
        }

        public void clearChart()
        {
            entries.Clear();
            drawChart();
        }

        private void fxChart(object sender, EventArgs e)
        {
            clearChart();
            inputProcess();
            
            double h;
            h = (xf - xi) / n;

            for (double i = 0; i < n; i++)
            {
                x = xi + i * h;
                y = parseFunction(x, fxFunction);
                entries.Add(new ChartEntry((float)y)
                {
                    Color = SKColor.Parse("#3498db")
                });
            }

            drawChart();
        }

        private void gaChart(object sender, EventArgs e)
        {
            clearChart();
            inputProcess();

            double h;
            h = (xf - xi) / n;

            for (int k = 0; k < n; k++)
            {
                angle = xi + k * h;
                magnitude = parseFunction(angle, fxFunction);
                x = magnitude * Math.Cos(angle);
                y = magnitude * Math.Sin(angle);
                entries.Add(new ChartEntry((float)y)
                {
                    Color = SKColor.Parse("#3498db")
                });
            }

            drawChart();
        }

    }
}

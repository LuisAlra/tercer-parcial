using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFessentials02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagInicio : ContentPage
    {
        public PagInicio()
        {
            InitializeComponent();
        }

        private async void Btacelerometro_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagAcelerometro());
        }

        private async void Btbrujula_click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagBrujula());
        }
    }
}
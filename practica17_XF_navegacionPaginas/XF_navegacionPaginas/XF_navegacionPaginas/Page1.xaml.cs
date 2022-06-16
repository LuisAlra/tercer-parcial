using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_navegacionPaginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void p1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());

        }

        private async void p2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());

        }
    }
}
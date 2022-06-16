namespace MAUI_navegacionPaginas;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void firma(object sender, EventArgs e)
    {
        DisplayAlert("Firma", "Cruz Lara Luis Ángel\nBoleta: 2019301685\nNL: 6\nGrupo:8CM11", "ok");
    }

    private async void inicio(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page1());
    }
}


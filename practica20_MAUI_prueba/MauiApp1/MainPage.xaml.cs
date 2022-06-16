namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		DisplayAlert("Firma","Cruz Lara Luis Ángel\nBoleta: 2019301685\nNL: 6\nGrupo:8CM11","ok");
	}
}


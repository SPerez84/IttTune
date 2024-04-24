namespace IttTune.Screens;

public partial class HomeScreen : ContentPage
{
	public HomeScreen()
	{
		InitializeComponent();
	}

    async void btnMicrofono(object sender, EventArgs e)
    {
        await DisplayAlert("Navegacion", "Boton de microfono", "Ok");
    }

    async void btnCamara(object sender, EventArgs e)
    {
        await DisplayAlert("Borrar", "Boton de camara", "Ok");
    }

    async void btnTraducir(object sender, EventArgs e)
    {
        await DisplayAlert("Borrar", "Boton de traducir", "Ok");
    }
}
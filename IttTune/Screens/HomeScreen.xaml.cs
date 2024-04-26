using IttTune.Network;
using Newtonsoft.Json;

namespace IttTune.Screens
{
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

        
        async void btnTraduccion(object sender, EventArgs e)
        {
            await DisplayAlert("Navegacion", "Boton de microfono", "Ok");

        }
        /*async void btnTraducir(object sender, EventArgs e)
{
    if (!string.IsNullOrWhiteSpace(txtInput.Text))
    {
        string textToTranslate = txtInput.Text;
        await DisplayAlert("Llamada", "Llamada a deteccionApi", "Ok");

        // Detectar idioma
        string detectedLanguage = await deteccionApi.SendDetectionRequest(textToTranslate);
        await DisplayAlert("Llamada", "Llamada a tradcuccionPost", "Ok");

        // Traducir el texto al idioma deseado
        string translatedText = await traduccionPost.SendTranslationRequest(textToTranslate);

        txtOutput.Text = translatedText;
    }
}*/
    }
}

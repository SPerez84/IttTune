using Microsoft.Maui.Controls.Shapes;
using IttTune.Screens;

namespace IttTune
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HomeScreen());
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CajasDialogoMensajes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Page2>(this, "Hola", async s =>
            {
                await DisplayAlert("Saludo", "Hola!!!", "Ok");
            });
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            //var result = await DisplayActionSheet("Opciones", "Ok", null, 
            //    new[] { "Colombia", "México", "Costa Rica", "Perú" });

            //await DisplayAlert("Saludo", "Hola " + result, "Aceptar");

            await Navigation.PushAsync(new Page2());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TransformacionesAnimaciones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            await button1.ScaleTo(1.5, 2000, Easing.CubicInOut);
            await button1.ScaleTo(1, 2000, Easing.SpringIn);
        }
    }
}

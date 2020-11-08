using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ManejoEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            boton.Clicked += (s, a) => etiqueta.Text = "Hola " + DateTime.Now.ToString();
        }
    }
}

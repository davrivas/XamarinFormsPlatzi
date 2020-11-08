using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SistemaPropiedadesEnlazables
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            //var column = (int)button.GetValue(Grid.ColumnProperty);

            //if (column == 0)
            //{
            //    button.SetValue(Grid.ColumnProperty, 1);
            //}
            //else
            //{
            //    button.SetValue(Grid.ColumnProperty, 0);
            //}

            if (Grid.GetColumn(button) == 0)
            {
                Grid.SetColumn(button, 1);
            }
            else
            {
                Grid.SetColumn(button, 0);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace EnlaceDeDatos
{
    public class PrecioConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var entrada = (decimal)value;
            Color resultado;

            if (entrada >= 0 && entrada < 5)
            {
                resultado = Color.Green;
            }
            else if (entrada >= 5 && entrada < 8)
            {
                resultado = Color.Orange;
            }
            else
            {
                resultado = Color.Red;
            }

            return resultado;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

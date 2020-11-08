using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SistemaPropiedadesEnlazables
{
    public class MiControl : View
    {
        public string TheName {
            get {
                return (string)GetValue(TheNameProperty);
            }
            set {
                SetValue(TheNameProperty, value);
            }
        }

        public static readonly BindableProperty TheNameProperty = 
            BindableProperty.Create("TheName", typeof(string),
                typeof(MiControl), string.Empty, BindingMode.OneTime);
    }
}

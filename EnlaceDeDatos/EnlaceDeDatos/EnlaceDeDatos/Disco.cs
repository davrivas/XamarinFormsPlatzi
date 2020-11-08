using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnlaceDeDatos
{
    public class Disco : NotificationObject
    {
        private string _titulo;

        public string Titulo {
            get { return _titulo; }
            set { 
                _titulo = value;
                OnPropertyChanged();
            }
        }

        private string _banda;

        public string Banda {
            get { return _banda; }
            set {
                _banda = value;
                OnPropertyChanged();
            }
        }

        private string _genero;

        public string Genero {
            get { return _genero; }
            set {
                _genero = value;
                OnPropertyChanged();
            }
        }

        private DateTime _fechaLanzamiento;

        public DateTime FechaLanzamiento {
            get { return _fechaLanzamiento; }
            set {
                _fechaLanzamiento = value;
                OnPropertyChanged();
            }
        }

        private string _portada;

        public string Portada {
            get { return _portada; }
            set {
                _portada = value;
                OnPropertyChanged();
            }
        }

        private decimal _precio;

        public decimal Precio {
            get { return _precio; }
            set {
                _precio = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return $"{Titulo} {Banda}";
        }
    }
}

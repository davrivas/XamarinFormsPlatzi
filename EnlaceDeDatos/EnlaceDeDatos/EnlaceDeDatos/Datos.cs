using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EnlaceDeDatos
{
    public class Datos : NotificationObject
    {
        private ObservableCollection<Disco> _discos;

        public ObservableCollection<Disco> Discos {
            get { return _discos; }
            set {
                _discos = value;
                OnPropertyChanged();
            }
        }

        private Disco _discoSeleccionado;

        public Disco DiscoSeleccionado {
            get { return _discoSeleccionado; }
            set {
                _discoSeleccionado = value;
                OnPropertyChanged();
            }
        }

        public MyCommand AgregarDiscoCommand { get; set; }

        

        public Datos()
        {
            Discos = new ObservableCollection<Disco>
            {
                new Disco { Banda = "The Beatles", Titulo = "Help!", Genero = "Rock",
                FechaLanzamiento = new DateTime(1965,8,6), Portada = "help.jpg", Precio = (decimal)4.5 },
                new Disco { Banda = "The Beatles", Titulo = "Revolver", Genero = "Rock",
                FechaLanzamiento = new DateTime(1966,8,6), Portada = "revolver.jpg", Precio = 5 },
                new Disco { Banda = "The Beatles", Titulo = "Let it be", Genero = "Rock",
                FechaLanzamiento = new DateTime(1970,5,8), Portada = "letitbe.jpg", Precio = 8 }
            };

            AgregarDiscoCommand = new MyCommand(AgregarDiscoCommandExecute, AgregarDiscoCommandCanExecute);
        }

        private void AgregarDiscoCommandExecute()
        {
            Discos.Add(new Disco { Banda = "Nirvana", Titulo = "Nevermind", Precio = 1, FechaLanzamiento = new DateTime(1991,4,4) });

            AgregarDiscoCommand.ReevaluateCanExecute();
        }

        private bool AgregarDiscoCommandCanExecute()
        {
            return Discos.Count < 10;
        }
    }
}

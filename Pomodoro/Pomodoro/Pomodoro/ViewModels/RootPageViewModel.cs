using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Pomodoro.ViewModels
{
    public class RootPageViewModel : NotificationObject
    {
        private ObservableCollection<string> _menuItems;

        public ObservableCollection<string> MenuItems {
            get { return _menuItems; }
            set {
                _menuItems = value;
                OnPropertyChanged();
            }
        }

        private string _selectedmenuItem;

        public string SelectedMenuItem {
            get { return _selectedmenuItem; }
            set {
                _selectedmenuItem = value;
                OnPropertyChanged();
            }
        }

        public RootPageViewModel()
        {
            MenuItems = new ObservableCollection<string>
            {
                "Pomodoro", "Histórico", "Configuración"
            };

            PropertyChanged += RootPageViewModel_PropertyChanged;
        }

        private void RootPageViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(SelectedMenuItem))
            {
                if (SelectedMenuItem == "Pomodoro")
                {
                    MessagingCenter.Send(this, "GoToPomodoro");
                }

                if (SelectedMenuItem == "Configuración")
                {
                    MessagingCenter.Send(this, "GoToConfiguration");
                }
            }
        }
    }
}

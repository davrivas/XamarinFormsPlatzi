using PrimeraAplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrimeraAplicacion.ViewModels
{
    public class SurveyDetailsViewModel : NotificationObject
    {
        private string _name;

        public string Name {
            get { return _name; }
            set { 
                _name = value;
                OnPropertyChanged();
            }
        }

        private string _favoriteFood;

        public string FavoriteFood {
            get { return _favoriteFood; }
            set { 
                _favoriteFood = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }


        public SurveyDetailsViewModel()
        {
            SaveCommand = new Command(SaveCommandExecute);
        }

        private void SaveCommandExecute()
        {
            var newSurvey = new Survey
            {
                Name = Name,
                FavoriteFood = FavoriteFood
            };
            MessagingCenter.Send(this, "SaveSurvey", newSurvey);
        }
    }
}

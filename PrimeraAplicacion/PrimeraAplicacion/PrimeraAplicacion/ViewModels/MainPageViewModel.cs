using PrimeraAplicacion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrimeraAplicacion.ViewModels
{
    public class MainPageViewModel : NotificationObject
    {
        private ObservableCollection<Survey> _survey;

        public ObservableCollection<Survey> Surveys {
            get { return _survey; }
            set { 
                _survey = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; set; }

        public MainPageViewModel()
        {
            Surveys = new ObservableCollection<Survey>();

            AddCommand = new Command(AddCommandExecute);

            MessagingCenter.Subscribe<SurveyDetailsViewModel, Survey>(this, "SaveSurvey", (a, s) =>
            {
                Surveys.Add(s);
            });
        }

        private void AddCommandExecute()
        {
            MessagingCenter.Send(this, "AddSurvey");
        }
    }
}

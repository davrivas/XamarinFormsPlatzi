using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pomodoro.ViewModels
{
    public class ConfigurationPageViewModel : NotificationObject
    {
        private ObservableCollection<int> _pomodoroDurations;

        public ObservableCollection<int> PomodoroDurations {
            get { return _pomodoroDurations; }
            set {
                _pomodoroDurations = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<int> _breakDurations;

        public ObservableCollection<int> BreakDurations {
            get { return _breakDurations; }
            set {
                _breakDurations = value;
                OnPropertyChanged();
            }
        }

        private int _selectedPomodoroDuration;

        public int SelectedPomodoroDuration {
            get { return _selectedPomodoroDuration; }
            set {
                _selectedPomodoroDuration = value;
                OnPropertyChanged();
            }
        }

        private int _selectedBreakDuration;

        public int SelectedBreakDuration {
            get { return _selectedBreakDuration; }
            set {
                _selectedBreakDuration = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; set; }
        public ConfigurationPageViewModel()
        {
            LoadPomodoroDurations();
            LoadBreakDurations();
            LoadConfiguration();
            SaveCommand = new Command(async () => await SaveCommandExecute());
        }

        private void LoadPomodoroDurations()
        {
            PomodoroDurations = new ObservableCollection<int> { 1, 5, 10, 25 };
        }

        private void LoadBreakDurations()
        {
            BreakDurations = new ObservableCollection<int> { 1, 5, 10, 25 };
        }

        private void LoadConfiguration()
        {
            if (Application.Current.Properties.ContainsKey(Literals.PomodoroDuration))
                SelectedPomodoroDuration = (int)Application.Current.Properties[Literals.PomodoroDuration];

            if (Application.Current.Properties.ContainsKey(Literals.BreakDuration))
                SelectedBreakDuration = (int)Application.Current.Properties[Literals.BreakDuration];
        }

        private async Task SaveCommandExecute()
        {
            Application.Current.Properties[Literals.PomodoroDuration] = SelectedPomodoroDuration;
            Application.Current.Properties[Literals.BreakDuration] = SelectedBreakDuration;
            await Application.Current.SavePropertiesAsync();
        }
    }
}

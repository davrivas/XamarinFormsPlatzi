using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pomodoro.ViewModels
{
    public class PomodoroPageViewModel : NotificationObject
    {
        private Timer _timer;
        private int _pomodoroDuration;
        private int _breakDuration;

        private TimeSpan _ellapsed;

        public TimeSpan Ellapsed {
            get { return _ellapsed; }
            set {
                _ellapsed = value;
                OnPropertyChanged();
            }
        }

        private bool _isRunning;

        public bool IsRunning {
            get { return _isRunning; }
            set {
                _isRunning = value;
                OnPropertyChanged();
            }
        }

        private bool _isInBreak;

        public bool IsInBreak {
            get { return _isInBreak; }
            set {
                _isInBreak = value;
                OnPropertyChanged();
            }
        }

        public ICommand StartOrPauseCommand { get; set; }

        public PomodoroPageViewModel()
        {
            InitializeTimer();
            LoadConfiguredValues();
            StartOrPauseCommand = new Command(StartOrPauseCommandExecute);
        }

        private void LoadConfiguredValues()
        {
            _pomodoroDuration = (int)Application.Current.Properties[Literals.PomodoroDuration];
            _breakDuration = (int)Application.Current.Properties[Literals.BreakDuration];

            Entry 
        }

        private void InitializeTimer()
        {
            _timer = new Timer
            {
                Interval = 1000
            };
            _timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Ellapsed = Ellapsed.Add(TimeSpan.FromSeconds(1));

            if (IsRunning && Ellapsed.TotalSeconds == _pomodoroDuration  * 60)
            {
                IsRunning = false;
                IsInBreak = true;
                Ellapsed = TimeSpan.Zero;
            }

            if (IsInBreak && Ellapsed.TotalSeconds == _breakDuration * 60)
            {
                IsRunning = true;
                IsInBreak = false;
                Ellapsed = TimeSpan.Zero;
            }
        }

        private void StartTimer()
        {
            _timer.Start();
            IsRunning = true;
        }

        private void StopTimer()
        {
            _timer.Stop();
            IsRunning = false;
        }

        private void StartOrPauseCommandExecute()
        {
            if (IsRunning)
            {
                StopTimer();
            }
            else
            {
                StartTimer();
            }
        }
    }
}

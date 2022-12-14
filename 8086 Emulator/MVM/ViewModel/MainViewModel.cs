using System;
using _8086_Emulator.Core;

namespace _8086_Emulator.MVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand MovViewCommand { get; set; }

        public RelayCommand XchgViewCommand { get; set; }
        public RelayCommand IncViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public MovViewModel MovVM { get; set; }

        public XchgViewModel XchgVM { get; set; }
        public IncViewModel IncVM { get; set; }
        
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            MovVM = new MovViewModel();
            XchgVM = new XchgViewModel();
            IncVM = new IncViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            MovViewCommand = new RelayCommand(o =>
            {
                CurrentView = MovVM;
            });

            XchgViewCommand = new RelayCommand(o =>
            {
                CurrentView = XchgVM;
            });

            IncViewCommand = new RelayCommand(o =>
            {
                CurrentView = IncVM;
            });

        }
    }
}

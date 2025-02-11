using Caliburn.Micro;
using Caliburn.Micro.Maui;

namespace CaliburnMicroMaui.ViewModels
{
    public class MainViewModel : Screen
    {
        private string _total;
        public string Total
        {
            get { return _total; }
            set { _total = value; NotifyOfPropertyChange(() => Total); }
        }

        private int _count = 0;

        private INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            DisplayName = "Home Page";

            Increment();
        }

        public void Increment()
        {
            _count++;

            Total = $"Current total is {_count}";
        }

        public void Navigate()
        {
            _navigationService.NavigateToViewModelAsync<AnotherViewModel>();
        }
    }
}
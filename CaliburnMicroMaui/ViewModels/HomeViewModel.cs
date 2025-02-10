using Caliburn.Micro;

namespace CaliburnMicroMaui.ViewModels
{
    public class HomeViewModel : Screen
    {
        public MainViewModel MainViewModel { get; set; }

        public HomeViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            MainViewModel.ConductWith(this);
        }
    }
}
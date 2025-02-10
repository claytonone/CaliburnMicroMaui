using Caliburn.Micro;

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

        public MainViewModel()
        {
            DisplayName = "Home Page";
        }

        public void Increment()
        {
            _count++;

            Total = $"Current total is {_count}";
        }
    }
}
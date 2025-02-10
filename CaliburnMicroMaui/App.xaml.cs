using Caliburn.Micro;
using Caliburn.Micro.Maui;
using CaliburnMicroMaui.ViewModels;

namespace CaliburnMicroMaui
{
    public partial class App : Caliburn.Micro.Maui.MauiApplication
    {
        private readonly SimpleContainer _container = new SimpleContainer();

        public App()
        {
            InitializeComponent();

            Initialize();

            //DisplayRootView<HomeView>();

            DisplayRootViewForAsync<MainViewModel>();
        }

        protected override void Configure()
        {
            _container.Instance(_container);
            _container.PerRequest<HomeViewModel>();
            _container.PerRequest<MainViewModel>();

            base.Configure();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage)
        {
            _container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }
    }
}
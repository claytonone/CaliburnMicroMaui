using Android.App;
using Android.Runtime;
using System.Reflection;

namespace CaliburnMicroMaui
{
    [Application]
    public class MainApplication : Caliburn.Micro.Maui.CaliburnApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
        {
            Initialize();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        protected override void Configure()
        {
            base.Configure();
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return new List<Assembly>() { typeof(App).Assembly };
        }
    }
}

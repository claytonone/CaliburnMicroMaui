using System.Reflection;
using Android.App;
using Android.Runtime;

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

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return
            [
                GetType().Assembly,
                typeof (App).Assembly
            ];
        }
    }
}

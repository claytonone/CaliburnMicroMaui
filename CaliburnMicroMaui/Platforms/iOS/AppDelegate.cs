using System.Reflection;
using Foundation;

namespace CaliburnMicroMaui
{
    [Register("AppDelegate")]
    public class AppDelegate : Caliburn.Micro.Maui.CaliburnApplicationDelegate
    {
        public AppDelegate()
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

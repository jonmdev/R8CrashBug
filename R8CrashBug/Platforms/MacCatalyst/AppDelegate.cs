using Foundation;

namespace R8CrashBug {
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}

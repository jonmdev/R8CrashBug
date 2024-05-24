namespace R8CrashBug {
    public partial class App : Application {
        public App() {
            
            ContentPage mainPage = new();
            this.MainPage = mainPage;

            AbsoluteLayout absRoot = new();
            mainPage.Content = absRoot; 

            HybridWebView.HybridWebView hybridWebView = new();
            hybridWebView.HybridAssetRoot = "hybridview";
            hybridWebView.MainFile = "index.html";
            hybridWebView.JSInvokeTarget = this;

            absRoot.Add(hybridWebView);
        }   
    }
}

using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace AppCenterTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppCenterTestPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start($"android=2e57210e-5f44-45db-8f9c-82d34082517b;ios=81e74f5a-7ac2-4672-94d0-471d5d44265f;",
    typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

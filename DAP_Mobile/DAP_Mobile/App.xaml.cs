using DAP_Mobile.Services;
using DAP_Mobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DAP_Mobile
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzg5NDg3QDMxMzgyZTM0MmUzMGtrcnNBd0JJMlY3dDUxY0cvR2ZvUTZmK21PSjBpTGgvRFNzVldRNmN2eEE9");

            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

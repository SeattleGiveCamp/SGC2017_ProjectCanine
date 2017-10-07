using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using ProjectCanine.Helpers;
using System;

using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            MobileCenter.Start($"android={Constants.MobileCenterAndroid};" +
                   $"uwp={Constants.MobileCenterUWP};" +
                   $"ios={Constants.MobileCenteriOS}",
                   typeof(Analytics), typeof(Crashes));


            if (UseMockDataStore)
			{
                DependencyService.Register<MockDataStore>();
			}
            else
			{
                DependencyService.Register<CloudDataStore>();
			}


            MainPage = new NavigationPage(new MainPage());
        }
    }
}

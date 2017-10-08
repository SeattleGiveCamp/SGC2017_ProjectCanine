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

		public static string AzureFunctionUrl = "https://projectcanineapi.azurewebsites.net";
		// TODO: research whether this is the appropriate place for this setting
		public static string AzureFunctionKey = "DmWNeIZzapka7eTF6aimVzWT4ZDGclVBuPhME5YWsYKc1Pn1JPaugA==";
		
        public App()
        {
            InitializeComponent();

#if !DEBUG
            MobileCenter.Start($"android={Constants.MobileCenterAndroid};" +
                   $"uwp={Constants.MobileCenterUWP};" +
                   $"ios={Constants.MobileCenteriOS}",
                   typeof(Analytics), typeof(Crashes));

#endif
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

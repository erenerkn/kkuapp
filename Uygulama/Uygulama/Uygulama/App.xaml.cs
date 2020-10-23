using System;
using Uygulama.SoapServices;
using Uygulama.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Uygulama
{
	public partial class App : Application
	{
		public static string key = "db";
		public static string key2 = "db2";
		public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPages());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
        private static IStudentService _StudentService;
        public static IStudentService StudentService
        {
            get
            {
                if (_StudentService == null)
                {
                    _StudentService = DependencyService.Get<IStudentService>();
                }
                return _StudentService;
            }
        }
    }
}

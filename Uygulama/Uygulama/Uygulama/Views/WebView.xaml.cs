using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Utils;
using Uygulama.Views.TabMenu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uygulama.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebView : ContentPage
	{
		public WebView ()
		{
			InitializeComponent ();
            webAsync();
		}
        private async void webAsync()
        {
            var username = UygulamaTypes.User.UserName;
            var result = await App.StudentService.LoginStudentFTA(username);
            webView.Source = result;


        }
    }
}
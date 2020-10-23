using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Utils;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uygulama.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserInterface : ContentPage
	{
		public UserInterface ()
		{
			InitializeComponent ();
			fonkAsync();
		}
		private async void fonkAsync()
		{
			var dene = UygulamaTypes.User.UserName;
			var result = await App.StudentService.StudentInfo(dene);
			for (int i = 0; i < result.Split(';').Length; i++)
			{
				lblAd.Text = result.Split(';')[1];
				lblSoyad.Text = result.Split(';')[2];
			}
		}
		void Cıkıs(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new LoginPage());
        }

        private void Giris_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new WebView());
        }

        private void istatistik_Tapped(object sender, EventArgs e)
        {
			Navigation.PushModalAsync(new WebIstatistik());
			//Device.OpenUri(new Uri("http://example.com"));
		}

        private void Haberler_Tapped(object sender, EventArgs e)
        {
			Navigation.PushModalAsync(new WebHaber());
        }

        private void Etkinlikler_Tapped(object sender, EventArgs e)
        {
			Navigation.PushModalAsync(new WebEtkinlik());
		}

        private void Duyurular_Tapped(object sender, EventArgs e)
        {
			Navigation.PushModalAsync(new WebDuyuru());
		}
    }
}
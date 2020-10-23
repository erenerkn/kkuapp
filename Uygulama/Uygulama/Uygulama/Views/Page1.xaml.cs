using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uygulama.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}
		private void ogrbilgi(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			Navigation.PushAsync( new WebView());
			indicator.IsRunning = false;
		}
		private void kutuphane(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			Navigation.PushAsync(new KütüphaneData());
			indicator.IsRunning = false;
		}
		private void alders(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			Navigation.PushAsync(new StudentLecture());
			indicator.IsRunning = false;
		}
		private void yemekhane(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			Navigation.PushAsync(new Yemekhane());
			indicator.IsRunning = false;
		}
		private void duyuru(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			Navigation.PushAsync(new WebDuyuru());
			indicator.IsRunning = false;
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			Navigation.PushAsync(new Sosyal());
			indicator.IsRunning = false;
		}
	}
}
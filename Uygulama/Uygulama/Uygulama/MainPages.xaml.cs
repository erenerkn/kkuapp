using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uygulama
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPages : ContentPage
	{
		public MainPages ()
		{
			InitializeComponent ();

		}
		private async void ogrencigirisi(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			await Navigation.PushAsync(new StudentLogin());
			indicator.IsRunning = false;
		}
		private void sitegirisi(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			Navigation.PushAsync(new kkuedu());
			indicator.IsRunning = false;
		}

		private async Task personal_ClickedAsync(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			await Navigation.PushAsync(new PersonelLogin());
			indicator.IsRunning = false;
		}
	}
}
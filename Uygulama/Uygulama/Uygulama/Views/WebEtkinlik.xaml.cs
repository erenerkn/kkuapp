using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygulamaModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uygulama.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebEtkinlik : ContentPage
	{
		public WebEtkinlik ()
		{
			InitializeComponent ();
			fonkAsync();
		}
		async void fonkAsync()
		{
			try
			{
				var list = new List<WebActivity>();
				var result = await App.StudentService.webActivity();
				for (int i = 0; i < 10; i++)
				{

					list.Add(new WebActivity
					{
						activityHeader = result[i].activityHeader,
						activityNo = result[i].activityNo,
						Id = i + 1

					
					});

				}
				lstView.ItemsSource = list;
			}
			catch (Exception ex)
			{
				await DisplayAlert("hata", ex.Message, "ok");
			}
		}

		private async Task lstView_ItemTappedAsync(object sender, ItemTappedEventArgs e)
		{
			var studen = e.Item as WebActivity;
			//await DisplayAlert("deneme", "https://kku.edu.tr/Anasayfa/Duyuru/Index/" + studen.activityNo, "ok");
			await Task.Run(() => { Device.OpenUri(new Uri("https://kku.edu.tr/Anasayfa/Etkinlik/Index/" + studen.activityNo)); });
		}
	}
}
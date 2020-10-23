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
	public partial class WebHaber : ContentPage
	{
		public WebHaber ()
		{
			InitializeComponent ();
			fonkAsync();
			
		}
		async void fonkAsync()
		{
			try
			{
				var list = new List<WebNews>();
				var result = await App.StudentService.GetWebNews();
				for (int i = 0; i < 10; i++)
				{
					list.Add(new WebNews
					{
						Header = result[i].Header,
						No=result[i].No,
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
			var studen = e.Item as WebNews;
			//await DisplayAlert("deneme", "https://kku.edu.tr/Anasayfa/Duyuru/Index/" + studen.No , "ok");
			await Task.Run(() => { Device.OpenUri(new Uri("https://kku.edu.tr/Anasayfa/Haber/Index/" + studen.No)); });
		}
	}
}
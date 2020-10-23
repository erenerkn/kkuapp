using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Utils;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uygulama
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Yemekhane : ContentPage
	{
		public Yemekhane ()
		{
			InitializeComponent ();
			fonkAsync();
		}
		async void fonkAsync()
		{
			var dene = UygulamaTypes.User.UserName;
			var result = await App.StudentService.YemekhaneDetails(dene);
			for (int i = 0; i < result.Split(';').Length; i++)
			{
				var tarih = result.Split(';')[0].Split(' ')[0];
				lblTarih.Text = tarih;
				lblSaat.Text = result.Split(';')[1];
				lblYer.Text = result.Split(';')[2];
				lblBakiye.Text = result.Split(';')[3];
			}
		}
	}
}
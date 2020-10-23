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
	public partial class YemekhaneDetail : ContentPage
	{
		public YemekhaneDetail ()
		{
			InitializeComponent ();
			fonkAsync();
		}
		async void fonkAsync()
		{
			var dene = UygulamaTypes.User.UserName;
			var result = await App.StudentService.YemekhaneDetails(dene);
			for(int i=0; i<result.Split(';').Length; i++)
			{
				lblTarih.Text = result.Split(';')[0];
				lblSaat.Text = result.Split(';')[1];
				lblYer.Text = result.Split(';')[2];
				lblBakiye.Text = result.Split(';')[3];
			}
		}
	}
}
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
	public partial class StudentsInfo : ContentPage
	{
		public StudentsInfo ()
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
				lblTc.Text = result.Split(';')[0];
				lblAd.Text = result.Split(';')[1];
				lblSoyad.Text = result.Split(';')[2];
				lblProgram.Text = result.Split(';')[3];
				lblNo.Text = result.Split(';')[4];
				lblTelefon.Text = result.Split(';')[5];
				lblFakulte.Text = result.Split(';')[6];
				lblBolum.Text = result.Split(';')[7];
				lblDerece.Text = result.Split(';')[8];
				lblDanısman.Text = result.Split(';')[9];
			}
		}
	}
}
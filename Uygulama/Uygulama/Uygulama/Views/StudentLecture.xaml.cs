using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Utils;
using UygulamaModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uygulama.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentLecture : ContentPage
	{
		public StudentLecture ()
		{
			InitializeComponent ();
			fonkAsync();
		}
		async void fonkAsync()
		{
			try
			{
				var list = new List<StudentLectures>();
				var dene = UygulamaTypes.User.UserName;
				var result = await App.StudentService.studentLectures(dene);
				if (result != null)
				{
					for (int i = 0; i < result.Count; i++)
						{
							list.Add(new StudentLectures
							{
								dersAdı = result[i].dersAdı,
								dersKodu = result[i].dersKodu,
								hocaAdı = result[i].hocaAdı,
								hocaSoyad = result[i].hocaSoyad
							});
						}
						lstView.ItemsSource = list;
				}
				else
				{
					await DisplayAlert("Uyarı", "Kayıt Bulunamadı", "Tamam");
				}
			}
			catch (Exception ex)
			{
				await DisplayAlert("Uyarı",ex.Message, "Tamam");
			}
		}
	}
}
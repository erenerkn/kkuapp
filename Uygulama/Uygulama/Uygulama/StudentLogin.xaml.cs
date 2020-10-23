using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Models;
using Uygulama.Utils;
using Uygulama.Views.TabMenu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uygulama
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StudentLogin : ContentPage
	{
		public StudentLogin ()
		{
			InitializeComponent ();
			Entry_Username.Text = Settings.Key;
			Entry_Password.Text = Settings.Key2;
			if (Settings.Key != "" || Settings.Key2 != "")
			{
				remember.IsToggled = true;
			}
		}
		private async void SignInProcedureAsync(object sender, EventArgs e)
		{
			try
			{
				indicator.IsRunning = true;
				var ogrenciNo = Entry_Username.Text;
				var sifre = Entry_Password.Text;
				User user = new User();
				user.UserName = ogrenciNo;
				UygulamaTypes.User = user;
				var result = await App.StudentService.LoginStudent(ogrenciNo, sifre);
				if (result == "True")
				{
					
					await Navigation.PushAsync(new TabControl());
					indicator.IsRunning = false;
				}



				else
				{
					await DisplayAlert("Login", result, "Ok");
				}
			}
			catch (Exception ex)
			{
				await DisplayAlert("Hata", ex.Message, "Ok");
			}

		}

		private void Switch_Toggled(object sender, ToggledEventArgs e)
		{
			if (e.Value == true)
			{
				Settings.Key = Entry_Username.Text;
				Settings.Key2 = Entry_Password.Text;
			}
			else
			{
				Settings.Delete();
				Settings.Delete2();
			}
		}

		private async void Button_ClickedAsync(object sender, EventArgs e)
		{
			indicator.IsRunning = true;
			await Navigation.PushAsync(new ForgetPass());
			indicator.IsRunning = false;
		}
	}
}
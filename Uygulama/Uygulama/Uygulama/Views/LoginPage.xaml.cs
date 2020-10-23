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

namespace Uygulama.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            Init();
		}
        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignInProcedureAsync(s, e);


        }
        private async void SignInProcedureAsync(object sender,EventArgs e)
        {
			try
			{
				var ogrenciNo = Entry_Username.Text;
				var sifre = Entry_Password.Text;
				User user = new User();
				user.UserName = ogrenciNo;
				UygulamaTypes.User = user;
				var result = await App.StudentService.LoginStudent(ogrenciNo, sifre);
				if (result == "True")
				{
					await Navigation.PushModalAsync(new TabControl());
				}



				else
				{
					await DisplayAlert("Login", result, "Ok");
				}
			}
			catch(Exception ex)
			{
				await DisplayAlert("Hata", ex.Message, "Ok");
			}
			
        }
	}
}
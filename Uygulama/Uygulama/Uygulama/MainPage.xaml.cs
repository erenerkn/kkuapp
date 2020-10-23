using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama.Utils;
using Xamarin.Forms;

namespace Uygulama
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            var deneme=UygulamaTypes.User.UserName;
            DisplayAlert("deneme",deneme, "ok");
        }
    }
}

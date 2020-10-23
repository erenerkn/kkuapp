using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Uygulama
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sosyal : ContentPage
	{
		public Sosyal ()
		{
			InitializeComponent ();
		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("https://www.facebook.com/kirikkaleunv/"));
		}

		private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("https://twitter.com/kirikkaleunv/"));
		}

		private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
		{
			Device.OpenUri(new Uri("mailto:mail@kku.edu.tr"));
		}

		private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new StudentLogin());
		}
	}
}
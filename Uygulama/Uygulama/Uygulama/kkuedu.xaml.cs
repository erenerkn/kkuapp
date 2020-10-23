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
	public partial class kkuedu : ContentPage
	{
		public kkuedu ()
		{
			InitializeComponent ();
			Web();
		}
		private void Web()
		{
			webView.Source = "https://kku.edu.tr/Anasayfa";
		}
	}
}
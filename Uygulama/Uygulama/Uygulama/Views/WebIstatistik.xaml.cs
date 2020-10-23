using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;
using SkiaSharp;

namespace Uygulama.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WebIstatistik : ContentPage
	{
		public WebIstatistik ()
		{
			InitializeComponent ();
			fonkAsync();
		}
		private async void fonkAsync()
		{
			var result = await App.StudentService.webStatistics();
			string doktorabayan = result[0].doktoraBayan;
			string doktoraerkek = result[0].doktoraErkek;
			string lisansbayan = result[0].lisansBayan;
			string lisanserkek = result[0].lisansErkek;
			string myokadın = result[0].myoBayan;
			string myoerkek = result[0].myoErkek;
			string ylbayan = result[0].ylBayan;
			string ylerkek = result[0].ylErkek;
			var entries = new[]
			{
				 new Microcharts.Entry(Convert.ToInt32(doktorabayan))
				 {
					 Label = "Doktora Kadın",
					 ValueLabel = doktorabayan,
					 Color = SKColor.Parse("#2c3e50")
				 },
				 new Microcharts.Entry(Convert.ToInt32(doktoraerkek))
				 {
					 Label = "Doktora Erkek",
					 ValueLabel = doktoraerkek,
					 Color = SKColor.Parse("#77d065")
				 },
				 new Microcharts.Entry(Convert.ToInt32(lisansbayan))
				 {
					 Label = "Lisans Kadın",
					 ValueLabel = lisansbayan,
					 Color = SKColor.Parse("#b455b6")
				 },
				 new Microcharts.Entry(Convert.ToInt32(lisanserkek))
				 {
					 Label = "Lisans Erkek",
					 ValueLabel = lisanserkek,
					 Color = SKColor.Parse("#3498db")
				 },
				 new Microcharts.Entry(Convert.ToInt32(myokadın))
				 {
					 Label = "Ö.Lisans Kadın",
					 ValueLabel = myokadın,
					 Color = SKColor.Parse("#ff1493")
				 },
				 new Microcharts.Entry(Convert.ToInt32(myoerkek))
				 {
					 Label = "Ö.Lisans Erkek",
					 ValueLabel = myoerkek,
					 Color = SKColor.Parse("#ffe413")
				 },
				 new Microcharts.Entry(Convert.ToInt32(ylbayan))
				 {
					 Label = "Y.Lisans Kadın",
					 ValueLabel = ylbayan,
					 Color = SKColor.Parse("#808080")
				 },
				 new Microcharts.Entry(Convert.ToInt32(ylerkek))
				 {
					 Label = "Y.Lisans Erkek",
					 ValueLabel = ylerkek,
					 Color = SKColor.Parse("#000000")
				 }
			};
			var chart = new LineChart() { Entries = entries,LabelTextSize=30};
			charview.Chart = chart;
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;


namespace Uygulama.Views.TabMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabControl :Xamarin.Forms.TabbedPage
    {
        public TabControl ()
        {
            InitializeComponent();
			On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
		}
    }
}
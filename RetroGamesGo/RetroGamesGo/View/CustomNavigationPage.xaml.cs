using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RetroGamesGo.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomNavigationPage : NavigationPage
	{
		public CustomNavigationPage (Page root) : base (root)
		{
			InitializeComponent ();
		}
	}
}
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormIO
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
    {
		public MainPage ()
		{
			InitializeComponent ();
		}

        public void NavigateToPage(Page page)
        {
            Detail = new NavigationPage(page);
            IsPresented = false;
        }
    }
}
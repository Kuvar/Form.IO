using FormIO.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormIO
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage ()
		{
			InitializeComponent ();
            BindData();

        }

        private void BindData()
        {
            WebView browser = new WebView();

            HtmlWebViewSource htmlSource = new HtmlWebViewSource();

            htmlSource.Html = String.Format(Constants.html, "https://qxkynjqjapjoave.form.io/user/register");

            browser.Source = htmlSource;

            Content = browser;
        }
	}
}
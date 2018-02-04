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
	public partial class ComplexPage : ContentPage
	{
		public ComplexPage ()
		{
			InitializeComponent ();
            BindData();

        }

        private void BindData()
        {
            WebView browser = new WebView();

            HtmlWebViewSource htmlSource = new HtmlWebViewSource();

            htmlSource.Html = String.Format(Constants.html, "https://gbnpuigytnxvjpx.form.io/selesrep/userprofile");

            browser.Source = htmlSource;

            Content = browser;
        }
    }
}
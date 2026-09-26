using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.SwarVigyan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class swarvigyan : ContentPage
	{
		public swarvigyan ()
		{
			InitializeComponent ();
            BindingContext = App.AppSetup.MatrimonialViewModel;
            coverFlow.IsPanSwipeEnabled = true;
            coverFlow.IsUserInteractionEnabled = true;
            //Browser.OpenAsync(new Uri("https://www.atyourservicejain.com/books/narada_samhita_hindi.pdf"), BrowserLaunchMode.SystemPreferred);
            //webView.Source = "https://www.atyourservicejain.com/books/narada_samhita_hindi.pdf";
            //LoadPDF();
        }

        async Task btnBrowse_Click(object sender, System.EventArgs e)
        {
            await Browser.OpenAsync(new Uri("https://www.atyourservicejain.com/books/narada_samhita_hindi.pdf"), BrowserLaunchMode.SystemPreferred);
        }

        private void LoadPDF()
        {
            string pdfUrl = "http://www.atyourservicejain.com/books/narada_samhita_hindi.pdf";
            //pdfWebView.Source = pdfUrl;
        }
    }
}
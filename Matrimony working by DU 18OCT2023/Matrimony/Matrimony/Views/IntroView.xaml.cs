using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroView : ContentPage
    {
        public IntroView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread( () =>
            {
                Xamarin.Essentials.Preferences.Set("IsStarted", true);
                App.Current.MainPage = new MainPage();//Working-Label 1.0 //Matrimonial Version 1.0 
                //App.Current.MainPage = new NavigationPage(new MainPage());
            });

        }
    }
}
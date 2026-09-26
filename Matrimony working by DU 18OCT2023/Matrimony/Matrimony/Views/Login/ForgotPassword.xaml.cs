using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotPassword : ContentPage
    {
        public ForgotPassword()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.LoginViewModel;
        }
        private void RegistrationView_Clicked(object sender, EventArgs e)
        {
            //App.AppSetup.LoginViewModel.RegistrationViewCommand.Execute(10);
            Application.Current.MainPage = new NavigationPage(new Matrimony.Views.Login.Register());
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            //App.AppSetup.LoginViewModel.ForgotPasswordViewCommand.Execute(10);
            //App.AppSetup.MainViewModel.ViewAllBridalCommand.Execute(10);
            //await Navigation.PushAsync(new Matrimony.Views.Login.ForgotPassword());
            Application.Current.MainPage = new NavigationPage(new Matrimony.Views.Login.Login());
        }

        private void RetrievePassword_Tapped(object sender, EventArgs e)
        {
            //var context = (sender as View).BindingContext as MatrimonialMember;
            if (!string.IsNullOrEmpty(App.AppSetup.LoginViewModel.MobileNo))
            {
                Chat.Open("+91" + App.AppSetup.LoginViewModel.MobileNo, "Hi,Please provide password for "+ App.AppSetup.LoginViewModel.MobileNo);
                Application.Current.MainPage = new NavigationPage(new Matrimony.Views.Login.Login());
            }
            else
            {
                App.AppSetup.MainViewModel.ToastConfig.Message = $"Mobile number is empty.";
                App.AppSetup.MainViewModel.ToastConfig.Position = ToastPosition.Bottom;
                UserDialogs.Instance.Toast(App.AppSetup.LoginViewModel.ToastConfig);
            }
        }
    }
}
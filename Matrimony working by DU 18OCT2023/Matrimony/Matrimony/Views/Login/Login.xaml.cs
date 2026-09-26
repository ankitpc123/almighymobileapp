using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.LoginViewModel;
        }
        private void RegistrationView_Clicked(object sender, EventArgs e)
        {
            //App.AppSetup.LoginViewModel.RegistrationViewCommand.Execute(10);
            Application.Current.MainPage = new NavigationPage(new Matrimony.Views.Login.Register());
        }

        private void ForgotPasswordView_Clicked(object sender, EventArgs e)
        {
            //App.AppSetup.LoginViewModel.ForgotPasswordViewCommand.Execute(10);
            //App.AppSetup.MainViewModel.ViewAllBridalCommand.Execute(10);
            //await Navigation.PushAsync(new Matrimony.Views.Login.ForgotPassword());
            Application.Current.MainPage = new NavigationPage(new Matrimony.Views.Login.ForgotPassword());
        }
    }
}
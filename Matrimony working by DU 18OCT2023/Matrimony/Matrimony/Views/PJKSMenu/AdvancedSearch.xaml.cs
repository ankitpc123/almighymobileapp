using Acr.UserDialogs;
using Matrimony.Models;
using Matrimony.Models.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.PJKSMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdvancedSearch : ContentPage
    {
        static bool fromAdvs = false;
        public AdvancedSearch()
        {
            InitializeComponent();
            fromAdvs = false;
            BindingContext = App.AppSetup.MembersViewModel;
            App.AppSetup.MembersViewModel.IsBusy = false;
            App.AppSetup.MembersViewModel.map = this.mapView;
            App.AppSetup.MembersViewModel.LoadWanshCommand.Execute(null);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.AppSetup.MembersViewModel.GetAroundPeople(this.Navigation);
            //var loginUser = App.DatabaseService.GetAppMember();
            //if (loginUser != null)
            //{
            //    Helper.Helper.GetLocationUsingAddress(loginUser.address+','+loginUser.city + ',' +loginUser.state + ',' +loginUser.zip);
            //}
        }
    }
}
using System;
using System.Collections.Generic;
using Matrimony.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Matrimony.Views.PJKSMenu
{
    public partial class NearByView : ContentPage
    {
        public NearByView()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MapViewModel;
            App.AppSetup.MapViewModel.map = this.mapView;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.AppSetup.MapViewModel.GetAroundPeople(this.Navigation);
            //var loginUser = App.DatabaseService.GetAppMember();
            //if (loginUser != null)
            //{
            //    Helper.Helper.GetLocationUsingAddress(loginUser.address+','+loginUser.city + ',' +loginUser.state + ',' +loginUser.zip);
            //}
        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Matrimony.Models;
using System.Linq;

namespace Matrimony.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            //BindingContext = App.AppSetup.MainViewModel;
            // MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
            this.SetBinding(MasterDetailPage.IsPresentedProperty, "IsPresented");
            this.IsPresentedChanged += MainView_IsPresentedChanged;
            App.AppSetup.MainViewModel.Navigation = Navigation;
        }

        void MainView_IsPresentedChanged(object sender, EventArgs e)
        {
            App.AppSetup.BaseViewModel.IsPresented = ((MasterDetailPage)sender).IsPresented;
        }

        public async Task NavigateFromMenu(int id)
        {
            IsPresented = false;
            //if (!MenuPages.ContainsKey(id))
            //{
            //    switch (id)
            //    {

            //        case (int)MenuItemType.About:
            //            MenuPages.Add(id, new NavigationPage(new AboutPage()));
            //            break;
            //    }
            //}

            //var newPage = MenuPages[id];

            //if (newPage != null && Detail != newPage)
            //{
            //    Detail = newPage;

            //    if (Device.RuntimePlatform == Device.Android)
            //        await Task.Delay(100);

            //    IsPresented = false;
            //}
            //if (id == 4)
            //{
            //    await this.Navigation.PushAsync(new PJKS());
            //}
            //else if (id == 1)
            //{
            //    await this.Navigation.PushAsync(new AboutPage());
            //}
            //await Navigation.PushAsync(new NavigationPage(new AboutPage()));
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.AboutPage(), true));
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            //if (Device.OS == TargetPlatform.Android)
            //    DependencyService.Get<IAndroidMethods>().CloseApp();
            //return false;
            ///App.Current.MainPage = new NavigationPage(new HomeView());
            //return base.OnBackButtonPressed();
            return true;
        }
    }
}
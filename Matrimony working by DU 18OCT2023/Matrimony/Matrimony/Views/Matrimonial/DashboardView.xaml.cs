using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Matrimonial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardView : ContentPage
    {
        public DashboardView()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MatrimonialViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.AppSetup.MatrimonialViewModel.LoadDashboardCommand.Execute(null);

        }

        private void ViewAllBridal_Clicked(object sender, EventArgs e)
        {
            App.AppSetup.MatrimonialViewModel.ViewAllBridalCommand.Execute(10);
        }

        private void ViewAllGroom_Clicked(object sender, EventArgs e)
        {
            App.AppSetup.MatrimonialViewModel.ViewAllGroomCommand.Execute(10);
        }

        private void AddMember_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.AddMatrimonialMember(), true));
        }
        private void Search_Tapped(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(App.AppSetup.MainViewModel.SearchText))
                App.AppSetup.MatrimonialViewModel.SearchCommand.Execute(App.AppSetup.MainViewModel.SearchText.Trim());
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            App.AppSetup.MainViewModel.SearchText = (sender as Entry).Text;
        }

        private void AdvanceSearch_Tapped(object sender, EventArgs e)
        {
            App.AppSetup.MainViewModel.AdvanceSearchCommand.Execute(null);
        }
    }
}
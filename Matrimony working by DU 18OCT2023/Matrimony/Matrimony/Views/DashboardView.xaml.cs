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
            App.AppSetup.MainViewModel.ViewAllBridalCommand.Execute(10);
        }

        private void ViewAllGroom_Clicked(object sender, EventArgs e)
        {
            App.AppSetup.MainViewModel.ViewAllGroomCommand.Execute(10);
        }
    }
}
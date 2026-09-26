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
    public partial class MatrimonialAdvancedSearch : ContentPage
    {
        public MatrimonialAdvancedSearch()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.AdvanceSearchViewModel;
        }

        private void MainGroomButton_Clicked(object sender, EventArgs e)
        {
            MainBride.BackgroundColor = MainGroomButton.TextColor = Color.White;
            App.AppSetup.AdvanceSearchViewModel.BRIDETextColor = MainGroom.BackgroundColor = (Color)App.Current.Resources["ThemeBaseColor"];
        }

        private void MainBrideButton_Clicked(object sender, EventArgs e)
        {
            MainBride.BackgroundColor = MainGroomButton.TextColor = (Color)App.Current.Resources["ThemeBaseColor"];
            App.AppSetup.AdvanceSearchViewModel.BRIDETextColor = MainGroom.BackgroundColor = Color.White;
        }
    }
}
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
    public partial class AddMatrimonialMember : ContentPage
    {
        public AddMatrimonialMember()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MatrimonialViewModel;
            App.AppSetup.MatrimonialViewModel.LoadWanshCommand.Execute(null);
            App.AppSetup.MatrimonialViewModel.FirstName = "";
            App.AppSetup.MatrimonialViewModel.IsMale = true;
            App.AppSetup.MatrimonialViewModel.BirthDate = DateTime.Now.Date.AddYears(-18);
            App.AppSetup.MatrimonialViewModel.BirthTime = DateTime.Now.ToLocalTime().TimeOfDay;
            App.AppSetup.MatrimonialViewModel.IsManglik = true;
            App.AppSetup.MatrimonialViewModel.IsMilan = true;
            App.AppSetup.MatrimonialViewModel.Photo = ImageSource.FromFile("boy");
        }

        private void BloodGroup_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            App.AppSetup.MatrimonialViewModel.BloodGroup = (sender as RadioButton).Value.ToString();
            //App.AppSetup.ProfileViewModel.BloodGroup = (sender as RadioButton).Text;
        }
    }
}
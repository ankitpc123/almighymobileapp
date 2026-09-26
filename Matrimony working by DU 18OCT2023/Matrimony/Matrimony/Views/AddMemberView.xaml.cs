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
    public partial class AddMemberView : ContentPage
    {
        public AddMemberView()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.ProfileViewModel;
            App.AppSetup.ProfileViewModel.LoadWanshCommand.Execute(null);
            App.AppSetup.ProfileViewModel.FirstName = "";
            App.AppSetup.ProfileViewModel.IsMale = true;
            App.AppSetup.ProfileViewModel.BirthDate = DateTime.Now.Date.AddYears(-18);
            App.AppSetup.ProfileViewModel.BirthTime = DateTime.Now.ToLocalTime().TimeOfDay;
            App.AppSetup.ProfileViewModel.IsManglik = true;
            App.AppSetup.ProfileViewModel.IsMilan = true;
            App.AppSetup.ProfileViewModel.Photo = ImageSource.FromFile("boy");
        }

        private void BloodGroup_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            App.AppSetup.ProfileViewModel.BloodGroup = (sender as RadioButton).Value.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.PJKSMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddMember : ContentPage
    {
        public AddMember()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MembersViewModel;
            App.AppSetup.MembersViewModel.LoadWanshCommand.Execute(null);
            if (App.AppSetup.MembersViewModel.Member == null)
                App.AppSetup.MembersViewModel.Member = new Models.Member();
            App.AppSetup.MembersViewModel.Member.FirstName = "";

            //App.AppSetup.MembersViewModel.Member.DOB = DateTime.Now.Date.AddYears(-18);

            //App.AppSetup.MembersViewModel.Member.Photo = ImageSource.FromFile("boy");
        }

        private void BloodGroup_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //App.AppSetup.MatrimonialViewModel.BloodGroup = (sender as RadioButton).Value.ToString();
            //App.AppSetup.ProfileViewModel.BloodGroup = (sender as RadioButton).Text;
        }
    }
}
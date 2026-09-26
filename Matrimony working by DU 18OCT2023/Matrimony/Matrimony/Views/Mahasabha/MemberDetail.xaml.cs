using Acr.UserDialogs;
using Matrimony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Mahasabha
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MemberDetail : ContentPage
    {
        public MemberDetail()
        {
            InitializeComponent();
        }
        public MemberDetail(int memberid)
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MembersViewModel;
            App.AppSetup.MembersViewModel.GroupMemeberDetailsCommand.Execute(memberid);
        }

        private void Chat_Tapped(object sender, EventArgs e)
        {
            try
            {
                var context = App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member;
                if (context != null && !string.IsNullOrEmpty(context.Mobile))
                {
                    Chat.Open("+91" + context.Mobile, "Hi,");
                }
                else
                {
                    App.AppSetup.MembersViewModel.ToastConfig.Message = $"Mobile number is empty.";
                    App.AppSetup.MembersViewModel.ToastConfig.Position = ToastPosition.Bottom;
                    UserDialogs.Instance.Toast(App.AppSetup.MembersViewModel.ToastConfig);
                }
            }
            catch (Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.Toast(ex.Message);
            }

        }
        private async void SendInterest_Tapped(object sender, EventArgs e)
        {
            try
            {
                var context = App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member;
                if (context != null && !string.IsNullOrEmpty(context.Mobile))
                {
                    Xamarin.Essentials.SmsMessage smsMessage = new Xamarin.Essentials.SmsMessage("Hi,", "+91" + context.Mobile);
                    await Xamarin.Essentials.Sms.ComposeAsync(smsMessage);
                }
                else
                {
                    App.AppSetup.MembersViewModel.ToastConfig.Message = $"Mobile number is empty.";
                    App.AppSetup.MembersViewModel.ToastConfig.Position = ToastPosition.Bottom;
                    UserDialogs.Instance.Toast(App.AppSetup.MembersViewModel.ToastConfig);
                }
            }
            catch (Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.Toast(ex.Message);
            }

        }
    }
}
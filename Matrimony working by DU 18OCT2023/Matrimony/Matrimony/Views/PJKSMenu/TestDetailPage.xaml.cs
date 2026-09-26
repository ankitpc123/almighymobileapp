using Acr.UserDialogs;
using Matrimony.Models;
using Matrimony.ViewModels;
using PanCardView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.PJKSMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestDetailPage : ContentPage
    {
        public TestDetailPage()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MembersViewModel;
        }
        public TestDetailPage(int memberid)
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MembersViewModel;
            App.AppSetup.MembersViewModel.GroupMemeberDetailsCommand.Execute(memberid);
        }
        CancellationTokenSource _cancellationTokenSource;
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (BindingContext is MembersViewModel vm)
            {
                vm.ClearData(); // Method to clear or reset data
            }
            // Clear the ItemsSource and remove any bindings
            ///clvfamilyMemberList.ItemsSource = null;
            ///clvfamilyMemberList.BindingContext = null;
            _cancellationTokenSource?.Cancel();
        }
        private void Chat_Tapped(object sender, EventArgs e)
        {
            try
            {
                var context = App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member;
                if (App.AppSetup.MembersViewModel.GroupMemberDetailResponse != null
                    && App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member != null
                    && !string.IsNullOrEmpty(App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member.Mobile))
                {
                    Chat.Open("+91" + App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member.Mobile, "Hi,");
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
            try
            {
                var context = App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member;
                if (App.AppSetup.MembersViewModel.GroupMemberDetailResponse != null
                    && App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member != null
                    && !string.IsNullOrEmpty(App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member.Mobile))
                {
                    Xamarin.Essentials.SmsMessage smsMessage = new Xamarin.Essentials.SmsMessage("Hi,", "+91" + App.AppSetup.MembersViewModel.GroupMemberDetailResponse.member.Mobile);
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
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

namespace Matrimony.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BridalDetailView : ContentPage
    {
        public BridalDetailView(int memberid)
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MainViewModel;
            App.AppSetup.MainViewModel.DetailCommand.Execute(memberid);
        }

        //private void ShortList_Tapped(object sender, EventArgs e)
        //{
        //    var context = App.AppSetup.MainViewModel.MemberDetailResponse.matrimonialMember;
        //    if (context != null)
        //    {
        //        App.AppSetup.MainViewModel.ShortListMemberCommand.Execute(context);
        //    }
        //}
        //private void Call_Tapped(object sender, EventArgs e)
        //{
        //    var context = App.AppSetup.MainViewModel.MemberDetailResponse.matrimonialMember;
        //    if (context != null && !string.IsNullOrEmpty(context.mobile))
        //    {
        //        Xamarin.Essentials.PhoneDialer.Open(context.mobile);
        //    }
        //    else
        //    {
        //        App.AppSetup.MainViewModel.ToastConfig.Message = $"Mobile number is empty.";
        //        App.AppSetup.MainViewModel.ToastConfig.Position = ToastPosition.Bottom;
        //        UserDialogs.Instance.Toast(App.AppSetup.MainViewModel.ToastConfig);
        //    }
        //}
        private void Chat_Tapped(object sender, EventArgs e)
        {
            var context = App.AppSetup.MainViewModel.MemberDetailResponse.matrimonialMember;
            if (context != null && !string.IsNullOrEmpty(context.mobile))
            {
                Chat.Open("+91"+ context.mobile, "Hi,");
            }
            else
            {
                App.AppSetup.MainViewModel.ToastConfig.Message = $"Mobile number is empty.";
                App.AppSetup.MainViewModel.ToastConfig.Position = ToastPosition.Bottom;
                UserDialogs.Instance.Toast(App.AppSetup.MainViewModel.ToastConfig);
            }
        }
        private async void SendInterest_Tapped(object sender, EventArgs e)
        {
            var context = App.AppSetup.MainViewModel.MemberDetailResponse.matrimonialMember;
            if (context != null && !string.IsNullOrEmpty(context.mobile))
            {
                Xamarin.Essentials.SmsMessage smsMessage = new Xamarin.Essentials.SmsMessage("Hi,", "+91" + context.mobile);
                await Xamarin.Essentials.Sms.ComposeAsync(smsMessage);
            }
            else
            {
                App.AppSetup.MainViewModel.ToastConfig.Message = $"Mobile number is empty.";
                App.AppSetup.MainViewModel.ToastConfig.Position = ToastPosition.Bottom;
                UserDialogs.Instance.Toast(App.AppSetup.MainViewModel.ToastConfig);
            }
        }
    }
}
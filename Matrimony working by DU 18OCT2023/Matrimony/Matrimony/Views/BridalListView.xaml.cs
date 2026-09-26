using Acr.UserDialogs;
using Matrimony.Models;
using Matrimony.Models.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BridalListView : ContentPage
    {
        static bool fromAdvs= false;
        public BridalListView(AdvanceSearchResponse advanceSearchResponse)
        {
            InitializeComponent();
            fromAdvs = true;
            BindingContext = App.AppSetup.MainViewModel;
            App.AppSetup.MainViewModel.IsBusy = false;
            App.AppSetup.MainViewModel.BridalList = new System.Collections.ObjectModel.ObservableCollection<MatrimonialMember>(advanceSearchResponse?.list);
        }
        public BridalListView(int pagingnumber)
        {
            InitializeComponent();
            fromAdvs = false;
            BindingContext = App.AppSetup.MainViewModel;
            App.AppSetup.MainViewModel.IsBusy = false;
            App.AppSetup.MainViewModel.BridalListResponse= null;
            App.AppSetup.MainViewModel.BridalList?.Clear();
            App.AppSetup.MainViewModel.LoadBridalCommand.Execute(pagingnumber);
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var context = (sender as View).BindingContext as MatrimonialMember;
            if (context != null)
            {
                App.AppSetup.MainViewModel.ViewBridalDetailCommand.Execute(context.memberid);
            } 
        }

        //private void ShortList_Tapped(object sender, EventArgs e)
        //{
        //    var context = (sender as View).BindingContext as MatrimonialMember;
        //    if(context != null )
        //    {
        //        App.AppSetup.MainViewModel.ShortListMemberCommand.Execute(context);
        //    }
        //}
        //private void Call_Tapped(object sender, EventArgs e)
        //{
        //    var context = (sender as View).BindingContext as MatrimonialMember;
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
            var context = (sender as View).BindingContext as MatrimonialMember;
            if (context != null && !string.IsNullOrEmpty(context.mobile))
            {
                Chat.Open("+91" + context.mobile, "Hi,");
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
            var context = (sender as View).BindingContext as MatrimonialMember;
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

        private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            try
            {
                if (
            fromAdvs) return;
                if (App.AppSetup.MainViewModel?.BridalList?.LastOrDefault().memberid ==
                    App.AppSetup.MainViewModel?.BridalList?[e.LastVisibleItemIndex].memberid)
                {
                    var count = App.AppSetup.MainViewModel?.BridalList?.Count + 10;
                    App.AppSetup.MainViewModel.LoadBridalCommand.Execute(count);
                }
            }
            catch
            {

            }
        }}
}
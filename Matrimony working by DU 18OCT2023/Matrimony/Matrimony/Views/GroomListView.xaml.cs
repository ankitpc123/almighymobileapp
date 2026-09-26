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
    public partial class GroomListView : ContentPage
    {
        static bool fromAdvs = false;
        public GroomListView(AdvanceSearchResponse advanceSearchResponse)
        {
            InitializeComponent();
            fromAdvs = true;
            BindingContext = App.AppSetup.MainViewModel;
            App.AppSetup.MainViewModel.IsBusy = false;
            App.AppSetup.MainViewModel.GroomList = new System.Collections.ObjectModel.ObservableCollection<MatrimonialMember>(advanceSearchResponse?.list);
        }
        public GroomListView(int pagingnumber)
        {
            InitializeComponent();
            fromAdvs = false;
            BindingContext = App.AppSetup.MainViewModel;
            App.AppSetup.MainViewModel.IsBusy = false;
            App.AppSetup.MainViewModel.GroomListResponse = null;
            App.AppSetup.MainViewModel.GroomList?.Clear();
            App.AppSetup.MainViewModel.LoadGroomCommand.Execute(pagingnumber);
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var context = (sender as View).BindingContext as MatrimonialMember;
            if (context != null)
            {
                App.AppSetup.MainViewModel.ViewGroomDetailCommand.Execute(context.memberid);
            }
        }
        //private void ShortList_Tapped(object sender, EventArgs e)
        //{
        //    var context = (sender as View).BindingContext as MatrimonialMember;
        //    if (context != null)
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
                if (fromAdvs) return;
                if (App.AppSetup.MainViewModel?.GroomList?.LastOrDefault().memberid ==
                    App.AppSetup.MainViewModel?.GroomList?[e.LastVisibleItemIndex].memberid)
                {
                    var count = App.AppSetup.MainViewModel?.GroomList?.Count + 10;
                    App.AppSetup.MainViewModel.LoadGroomCommand.Execute(count);
                }

            }
            catch
            {

            }
        }
    }
}
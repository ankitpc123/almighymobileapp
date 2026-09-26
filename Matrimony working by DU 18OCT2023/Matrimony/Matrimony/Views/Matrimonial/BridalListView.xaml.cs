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

namespace Matrimony.Views.Matrimonial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BridalListView : ContentPage
    {
        static bool fromAdvs = false;
        public BridalListView(AdvanceSearchResponse advanceSearchResponse)
        {
            InitializeComponent();
            fromAdvs = true;
            BindingContext = App.AppSetup.MatrimonialViewModel;
            App.AppSetup.MatrimonialViewModel.IsBusy = false;
            App.IsMemberMale = false;
            App.AppSetup.MatrimonialViewModel.BridalList = new System.Collections.ObjectModel.ObservableCollection<MatrimonialMember>(advanceSearchResponse?.list);
        }
        public BridalListView(int pagingnumber)
        {
            InitializeComponent();
            fromAdvs = false;
            BindingContext = App.AppSetup.MatrimonialViewModel;
            App.AppSetup.MatrimonialViewModel.IsBusy = false;
            App.IsMemberMale = false;
            App.AppSetup.MatrimonialViewModel.BridalListResponse = null;
            App.AppSetup.MatrimonialViewModel.BridalList?.Clear();
            App.AppSetup.MatrimonialViewModel.LoadBridalCommand.Execute(pagingnumber);
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var context = (sender as View).BindingContext as MatrimonialMember;
            if (context != null)
            {
                App.IsMemberMale = context.gender.ToLower() == "male";
                App.AppSetup.MatrimonialViewModel.ViewBridalDetailCommand.Execute(context.memberid);
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
            try
            {
                var context = (sender as View).BindingContext as MatrimonialMember;
                if (context != null && !string.IsNullOrEmpty(context.mobile))
                {
                    Chat.Open("+91" + context.mobile, "Hi,");
                }
                else
                {
                    App.AppSetup.MatrimonialViewModel.ToastConfig.Message = $"Mobile number is empty.";
                    App.AppSetup.MatrimonialViewModel.ToastConfig.Position = ToastPosition.Bottom;
                    UserDialogs.Instance.Toast(App.AppSetup.MatrimonialViewModel.ToastConfig);
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
                var context = (sender as View).BindingContext as MatrimonialMember;
                if (context != null && !string.IsNullOrEmpty(context.mobile))
                {
                    Xamarin.Essentials.SmsMessage smsMessage = new Xamarin.Essentials.SmsMessage("Hi,", "+91" + context.mobile);
                    await Xamarin.Essentials.Sms.ComposeAsync(smsMessage);
                }
                else
                {
                    App.AppSetup.MatrimonialViewModel.ToastConfig.Message = $"Mobile number is empty.";
                    App.AppSetup.MatrimonialViewModel.ToastConfig.Position = ToastPosition.Bottom;
                    UserDialogs.Instance.Toast(App.AppSetup.MatrimonialViewModel.ToastConfig);
                }
            }
            catch (Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.Toast(ex.Message);
            }
            
        }

        private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            try
            {
                if (
            fromAdvs) return;
                if (App.AppSetup.MatrimonialViewModel?.BridalList?.LastOrDefault().memberid ==
                    App.AppSetup.MatrimonialViewModel?.BridalList?[e.LastVisibleItemIndex].memberid)
                {
                    var count = App.AppSetup.MatrimonialViewModel?.BridalList?.Count + 10;
                    App.AppSetup.MatrimonialViewModel.LoadBridalCommand.Execute(count);
                }
            }
            catch
            {

            }
        }

        private void AddMember_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.AddMatrimonialMember(), true));
        }
        private void Search_Tapped(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(App.AppSetup.MainViewModel.SearchText))
                App.AppSetup.MatrimonialViewModel.SearchCommand.Execute(App.AppSetup.MainViewModel.SearchText.Trim());
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            App.AppSetup.MainViewModel.SearchText = (sender as Entry).Text;
        }

        private void AdvanceSearch_Tapped(object sender, EventArgs e)
        {
            App.AppSetup.MainViewModel.AdvanceSearchCommand.Execute(null);
        }
    }
}
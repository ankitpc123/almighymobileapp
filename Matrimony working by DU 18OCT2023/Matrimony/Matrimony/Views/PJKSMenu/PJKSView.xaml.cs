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

namespace Matrimony.Views.PJKSMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PJKSView : ContentPage
	{
        static bool fromAdvs = false;
        //public PJKSView(AdvanceSearchResponse advanceSearchResponse)
        //{
        //    InitializeComponent();
        //    fromAdvs = true;
        //    BindingContext = App.AppSetup.MembersViewModel;
        //    App.AppSetup.MembersViewModel.IsBusy = false;
        //    App.IsMemberMale = false;
        //    App.AppSetup.MembersViewModel.MembersList = new System.Collections.ObjectModel.ObservableCollection<Member>(advanceSearchResponse?.list);
        //}
        public PJKSView(int pagingnumber)
        {
            InitializeComponent();
            fromAdvs = false;
            BindingContext = App.AppSetup.MembersViewModel;
            App.AppSetup.MembersViewModel.IsBusy = false;
            App.IsMemberMale = false;
            App.AppSetup.MembersViewModel.MembersResponse = null;
            App.AppSetup.MembersViewModel.MembersList?.Clear();
            App.AppSetup.MembersViewModel.MembersCommand.Execute(pagingnumber);
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var context = (sender as View).BindingContext as MatrimonialMember;
            if (context != null)
            {
                App.IsMemberMale = context.gender.ToLower() == "male";
                //App.AppSetup.MembersViewModel.ViewBridalDetailCommand.Execute(context.memberid);
            }
        }

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
                var context = (sender as View).BindingContext as MatrimonialMember;
                if (context != null && !string.IsNullOrEmpty(context.mobile))
                {
                    Xamarin.Essentials.SmsMessage smsMessage = new Xamarin.Essentials.SmsMessage("Hi,", "+91" + context.mobile);
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

        private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            try
            {
                if (
            fromAdvs) return;
                if (App.AppSetup.MembersViewModel?.MembersList?.LastOrDefault().MemberId ==
                    App.AppSetup.MembersViewModel?.MembersList?[e.LastVisibleItemIndex].MemberId)
                {
                    var count = App.AppSetup.MembersViewModel?.MembersList?.Count + 10;
                    App.AppSetup.MembersViewModel.MembersCommand.Execute(count);
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


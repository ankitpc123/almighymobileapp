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
    public partial class Dashboard : ContentPage
    {
        static bool fromAdvs = false;
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(int pagingnumber)
        {
            InitializeComponent();
            fromAdvs = false;
            BindingContext = App.AppSetup.MembersViewModel;
            App.AppSetup.MembersViewModel.IsBusy = false;
            App.IsMemberMale = false;
            App.AppSetup.MembersViewModel.MembersResponse = null;
            App.AppSetup.MembersViewModel.MembersList?.Clear();
            App.AppSetup.MembersViewModel.MembersCommand.Execute(pagingnumber);

            App.AppSetup.MembersViewModel.IsBusy = false;
            App.AppSetup.MembersViewModel.PJKSGroupCommitteeMembersResponse = null;
            App.AppSetup.MembersViewModel.PJKSGroupCommitteeMembersList?.Clear();
            App.AppSetup.MembersViewModel.GetPJKSGroupCommitteeListCommand.Execute(1);

            App.AppSetup.MembersViewModel.IsBusy = false;
            App.AppSetup.MembersViewModel.BirthdayMarriageAnniversaryMembersResponse = null;
            App.AppSetup.MembersViewModel.BirthdayMarriageAnniversaryMembersList?.Clear();
            App.AppSetup.MembersViewModel.BirthdayMarriageAnniversaryMembersCommand.Execute(pagingnumber);


        }
        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            // Your logic when an item is selected
            var context = (Member)e.SelectedItem;

            if (context != null)
            {
                //App.AppSetup.MembersViewModel.SelectedItem = context;
                App.AppSetup.MembersViewModel.ViewGroupMemeberDetailCommand.Execute(context.MemberId);
            }
            // Unselect the item
            //memberslist.SelectedItem = null;
            // Optionally deselect the item to prevent it from staying highlighted
            ((ListView)sender).SelectedItem = null;
        }

        private void ViewGroupMemeberDetail_Tapped(object sender, EventArgs e)
        {
            var context = (sender as View).BindingContext as Member;
            if (context != null)
            {
                App.AppSetup.MembersViewModel.ViewGroupMemeberDetailCommand.Execute(context.MemberId);
                //TESTPage
                //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.PJKSMenu.TESTPage(), true));
                //App.AppSetup.MatrimonialViewModel.ViewBridalDetailCommand.Execute(207);
            }
        }

        private void Chat_Tapped(object sender, EventArgs e)
        {
            try
            {
                var context = (sender as View).BindingContext as Member;
                if (context != null && !string.IsNullOrEmpty(context.Mobile))
                {
                    Chat.Open("+91" + context.Mobile, "जय जिनेन्द्र,");
                }
                else
                {
                    App.AppSetup.MatrimonialViewModel.ToastConfig.Message = $"Mobile number is empty.";
                    App.AppSetup.MatrimonialViewModel.ToastConfig.Position = ToastPosition.Bottom;
                    UserDialogs.Instance.Toast(App.AppSetup.MatrimonialViewModel.ToastConfig);
                }
                //Chat.Open("+919893297289", "जय जिनेन्द्र,");
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
                //var context = App.AppSetup.MatrimonialViewModel.MemberDetailResponse.matrimonialMember;
                //if (context != null && !string.IsNullOrEmpty(context.mobile))
                //{
                //    Xamarin.Essentials.SmsMessage smsMessage = new Xamarin.Essentials.SmsMessage("Hi,", "+91" + context.mobile);
                //    await Xamarin.Essentials.Sms.ComposeAsync(smsMessage);
                //}
                //else
                //{
                //    App.AppSetup.MatrimonialViewModel.ToastConfig.Message = $"Mobile number is empty.";
                //    App.AppSetup.MatrimonialViewModel.ToastConfig.Position = ToastPosition.Bottom;
                //    UserDialogs.Instance.Toast(App.AppSetup.MatrimonialViewModel.ToastConfig);
                //}
                Xamarin.Essentials.SmsMessage smsMessage = new Xamarin.Essentials.SmsMessage("जय जिनेन्द्र,", "+919755342608");
                await Xamarin.Essentials.Sms.ComposeAsync(smsMessage);
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
                if (fromAdvs) return;
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

        private void HappyWishes_Tapped(object sender, EventArgs e)
        {
            try
            {
                var context = (sender as View).BindingContext as Member;
                bool dob=false, dom= false;
                if (context.DOB != null)
                    dob = ((context.DOB.ToString("d").Substring(0, 5) == DateTime.Today.ToString("dd/MM/yyyy").Substring(0, 5))
                ||(context.DOB.Month== DateTime.Today.Month && context.DOB.Day== DateTime.Today.Day));
                if (context.DOM != null)
                    dom = ((context.DOM.ToString("d").Substring(0, 5) == DateTime.Today.ToString("dd/MM/yyyy").Substring(0, 5))
                        || (context.DOM.Month == DateTime.Today.Month && context.DOM.Day == DateTime.Today.Day));

                if (context != null)    
                {
                    if (dob && dom)
                        Chat.Open("+91" + context.Mobile, "जय जिनेन्द्र "+ context.FirstName + " जी,जन्म दिवस एवं शादी की वर्षगांठ की ढेर सारी हार्दिक शुभकामनायें,ज्योति पंकज जैन,पारसजनकल्याण संस्थान");
                    else if (dob)
                        Chat.Open("+91" + context.Mobile, "जय जिनेन्द्र "+ context.FirstName + " जी,जन्म दिवस की ढेर सारी हार्दिक शुभकामनायें,ज्योति पंकज जैन,पारसजनकल्याण संस्थान");
                    else if (dom)
                        Chat.Open("+91" + context.Mobile, "जय जिनेन्द्र "+ context.FirstName + " जी,शादी की वर्षगांठ की ढेर सारी हार्दिक शुभकामनायें,ज्योति पंकज जैन,पारसजनकल्याण संस्थान");
                }
                else
                {
                    App.AppSetup.MatrimonialViewModel.ToastConfig.Message = $"जय जिनेन्द्र.";
                    App.AppSetup.MatrimonialViewModel.ToastConfig.Position = ToastPosition.Bottom;
                    UserDialogs.Instance.Toast(App.AppSetup.MatrimonialViewModel.ToastConfig.Message);
                }

            }
            catch (Exception ex)
            {
                Acr.UserDialogs.UserDialogs.Instance.Toast(ex.Message);
            }

        }

        #region "संस्थान परिवार"
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            App.AppSetup.MembersViewModel.SearchText = (sender as Entry).Text;
        }
        private void Search_Tapped(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(App.AppSetup.MembersViewModel.SearchText))
            App.AppSetup.MembersViewModel.TabIndex = tabView.TabIndex;
            App.AppSetup.MembersViewModel.SearchCommand.Execute(App.AppSetup.MembersViewModel.SearchText.Trim());
        }
        private void AddMember_Tapped(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.PJKSMenu.AddMember(), true));
        }
        private void OpenAdvanceSearchPage_Tapped(object sender, EventArgs e)
        {
            App.AppSetup.MembersViewModel.OpenAdvanceSearchPageCommand.Execute(null);
        }

        #endregion

    }

}
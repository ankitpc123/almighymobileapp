using Acr.UserDialogs;
using Matrimony.ApiProvider;
using Matrimony.Managers;
using Matrimony.Models;
using Matrimony.Models.Response;
using Matrimony.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Matrimony.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            SearchText = "Atul";
        }
        public INavigation Navigation { get; set; }

        #region Set Property
        private int memberId { get; set; }

        public int MemberId 
        {
            get
            {
                return memberId;
            }
            set
            {
                memberId = value;
                RaisePropertyChanged(() => MemberId);
            }
        }

        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }

        
        public string image { get; set; }

        string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                //SetProperty(ref bridalListResponse, value);
                RaisePropertyChanged(() => SearchText);
            }
        }

        BridalListResponse bridalListResponse;
        public BridalListResponse BridalListResponse
        {
            get { return bridalListResponse; }
            set
            {
                bridalListResponse = value;
                //SetProperty(ref bridalListResponse, value);
                RaisePropertyChanged(() => BridalListResponse);
            }
        }

        GroomListResponse groomListResponse;
        public GroomListResponse GroomListResponse
        {
            get { return groomListResponse; }
            set
            {
                groomListResponse = value;
                //SetProperty(ref groomListResponse, value);

                RaisePropertyChanged(() => GroomListResponse);
            }
        }

        DashboardResponse dashboardResponse;
        public DashboardResponse DashboardResponse
        {
            get { return dashboardResponse; }
            set
            {
                dashboardResponse = value;
                RaisePropertyChanged(() => DashboardResponse);
            }
        }

        SearchResponse searchResponse;
        public SearchResponse SearchResponse 
        {
            get { return searchResponse; }
            set
            {
                searchResponse = value;
                RaisePropertyChanged(() => DashboardResponse);
            }
        }

        MemberDetailResponse memberDetailResponse;
        public MemberDetailResponse MemberDetailResponse
        {
            get { return memberDetailResponse; }
            set
            {
                memberDetailResponse = value;
                RaisePropertyChanged(() => MemberDetailResponse);
            }
        }

        private ObservableCollection<MatrimonialMember> bridalList;
        public ObservableCollection<MatrimonialMember> BridalList
        {
            get { return bridalList; }
            set
            {
                bridalList = value;
                RaisePropertyChanged(() => BridalList);
            }
        }
        private ObservableCollection<MatrimonialMember> groomList;
        public ObservableCollection<MatrimonialMember> GroomList
        {
            get { return groomList; }
            set
            {
                groomList = value;
                RaisePropertyChanged(() => GroomList);
            }
        }
        
        private ObservableCollection<Wansh> wanshList;
        public ObservableCollection<Wansh> WanshList
        {
            get { return wanshList; }
            set
            {
                wanshList = value;
                RaisePropertyChanged(() => WanshList);
            }
        }
        #endregion

        #region Set Commands
        //public Command<int> ViewAllBridalCommand { get { return new Command<int>(ViewAllBridalCommandExecution); } }
        //public Command<int> ViewAllGroomCommand { get { return new Command<int>(ViewAllGroomCommandExecution); } }
        //public Command<int> ViewBridalDetailCommand { get { return new Command<int>(ViewBridalDetailCommandExecution); } }
        //public Command<int> ViewGroomDetailCommand { get { return new Command<int>(ViewGroomDetailCommandExecution); } }
        //public Command<int> LoadBridalCommand { get { return new Command<int>(LoadBridalCommandExecution); } }
        //public Command<int> LoadGroomCommand { get { return new Command<int>(LoadGroomCommandExecution); } }
        //public Command LoadDashboardCommand { get { return new Command(DashboardResponseCommandExecution); } }
        //public Command<string> SearchCommand { get { return new Command<string>(SearchCommandExecution); } }
        //public Command<int> DetailCommand { get { return new Command<int>(DetailCommandExecution); } }
        public Command<MatrimonialMember> ShortListMemberCommand { get { return new Command<MatrimonialMember>(ShortListMemberCommandExecution); } }

        //public ICommand AdvanceSearchCommand => new Command(async() => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushModalAsync(new Views.SearchView(), true));
        public ICommand AdvanceSearchCommand => new Command(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.MatrimonialAdvancedSearch(), true));

        public Command LoadWanshCommand { get { return new Command(LoadWanshCommandExecution); } }
        #endregion

        #region Command Execution
        //private async void LoadBridalCommandExecution(int pagingnumber)
        //{
        //    if (IsBusy) return;
        //    IsBusy = true;
        //    UserDialogs.Instance.ShowLoading();
        //   // Task.Run(async () =>
        //   // {
        //        await apiService.GetBridalList(pagingnumber,() =>
        //        {
        //            UserDialogs.Instance.HideLoading();
        //            if (BridalListResponse == null || BridalList?.Count ==0)
        //            {
        //                BridalListResponse = apiService.BridalListResponse;
        //                BridalList = new ObservableCollection<MatrimonialMember>(apiService.BridalListResponse.BridalList);
        //            }
        //            else
        //            {
        //                var newBridalList =apiService.BridalListResponse.BridalList.Skip(BridalList.Count).ToList();
        //                foreach (var i in newBridalList)
        //                {
        //                    BridalList.Add(i);
        //                }
        //            }
        //            IsBusy = false;
        //        }, (failure) =>
        //         {
        //               UserDialogs.Instance.HideLoading();
        //           });
        //  //  });
        //}

        //private async void LoadGroomCommandExecution(int pagingnumber)
        //{
        //    if (IsBusy)
        //        return;
        //    IsBusy = true;
        //    UserDialogs.Instance.ShowLoading();
        //    //Task.Run(async () =>
        //    //{
        //        await apiService.GetGroomList(pagingnumber,() =>
        //        {
        //            UserDialogs.Instance.HideLoading();
        //            if (GroomListResponse == null || GroomList?.Count == 0)
        //            {
        //                GroomListResponse = apiService.GroomListResponse;
        //                GroomList = new ObservableCollection<MatrimonialMember>(apiService.GroomListResponse.GroomList);
        //            }
        //            else
        //           {
        //                try
        //                {
        //                    var newGrooms = apiService.GroomListResponse.GroomList.Skip(GroomList.Count).ToList();
        //                    foreach (var i in newGrooms)
        //                    {
        //                        GroomList.Add(i);
        //                    }
        //                }
        //                catch(Exception ex)
        //                {

        //                    IsBusy = false;
        //                }
        //                //GroomList = new ObservableCollection<MatrimonialMember>(apiService.GroomListResponse.GroomList);
        //            }
        //            //BridalListResponse = apiService.BridalListResponse;

        //            IsBusy = false;
        //            // GroomListResponse = apiService.GroomListResponse;
        //        }, (failure) =>
        //        {
        //            IsBusy = false;
        //            UserDialogs.Instance.HideLoading();
        //        });
        //    //});
        //}

        //private void ViewAllBridalCommandExecution(int pagingnumber)
        //{
        //    Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.BridalListView(pagingnumber), true));
        //    //Navigation.PushAsync(new Views.BridalListView(pagingnumber), true);
        //}
        //private void ViewAllGroomCommandExecution(int pagingnumber)
        //{
        //    Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.GroomListView(pagingnumber), true));//Matrimonial Version 1.0 
        //    //Navigation.PushAsync(new Views.GroomListView(pagingnumber), true);//Matrimonial Version 2.0 
        //}
        //private void ViewBridalDetailCommandExecution(int memberid)
        //{
        //    Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.BridalDetailView(memberid), true));//Matrimonial Version 1.0 
        //    //Navigation.PushAsync(new Views.BridalDetailView(memberid), true);//Matrimonial Version 2.0 
        //}
        //private void ViewGroomDetailCommandExecution(int memberid)
        //{
        //    Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.GroomDetailView(memberid), true));//Matrimonial Version 1.0 
        //    //Navigation.PushAsync(new Views.GroomDetailView(memberid), true);//Matrimonial Version 2.0 
        //}

        //private void DashboardResponseCommandExecution()
        //{
        //    UserDialogs.Instance.ShowLoading();
        //    Task.Run(async () =>
        //    {
        //        try
        //        {
        //            var shortlistmember = App.DatabaseService.GetAllMembers()?.Select(x => x.MemberId)?.ToList();
        //            await apiService.DashboardDataList(shortlistmember, () =>
        //             {
        //                 UserDialogs.Instance.HideLoading();
        //                 DashboardResponse = apiService.DhashboardResponse;

        //             }, (failure) =>
        //                      {
        //                          UserDialogs.Instance.HideLoading();
        //                      });
        //        }
        //        catch(Exception ex)
        //        {

        //        }
        //    });
        //}

        //private void SearchCommandExecution(string searchtext)
        //{
        //    UserDialogs.Instance.ShowLoading();
        //    Task.Run(async () =>
        //    {
        //        await apiService.SearchDataList(searchtext, () =>
        //        {
        //            try
        //            {
        //                UserDialogs.Instance.HideLoading();
        //                Device.BeginInvokeOnMainThread(() =>
        //                {
        //                    var detailPage = ((MasterDetailPage)App.Current.MainPage).Detail.Navigation;

        //                    if (detailPage.NavigationStack[^1] is BridalListView)
        //                    {
        //                        BridalListResponse = new BridalListResponse
        //                        {
        //                            BridalList = new List<MatrimonialMember>(apiService.SearchResponse.SearchList),
        //                            success = true
        //                        };
        //                    }
        //                    else if (detailPage.NavigationStack[^1] is GroomListView)
        //                    {
        //                        GroomListResponse = new GroomListResponse
        //                        {
        //                            GroomList = new List<MatrimonialMember>(apiService.SearchResponse.SearchList),
        //                            success = true
        //                        };
        //                    }
        //                    else if (detailPage.NavigationStack[^1] is Views.Matrimonial.DashboardView)
        //                    {
        //                        if (apiService.SearchResponse.SearchList[0].gender.ToLower() == "male")
        //                        {
        //                            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.GroomDetailView(apiService.SearchResponse.SearchList[0].memberid), true));//Matrimonial Version 1.0 
        //                            //Navigation.PushAsync(new Views.GroomDetailView(apiService.SearchResponse.SearchList[0].memberid), true);//Matrimonial Version 2.0 
        //                        }
        //                        else
        //                        {
        //                            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.BridalDetailView(apiService.SearchResponse.SearchList[0].memberid), true));//Matrimonial Version 1.0 
        //                            //Navigation.PushAsync(new Views.BridalDetailView(apiService.SearchResponse.SearchList[0].memberid), true);//Matrimonial Version 2.0 
        //                        }
        //                    }
        //                });
        //            }
        //            catch(Exception ex)
        //            {
        //                UserDialogs.Instance.HideLoading();
        //            }
        //        }, (failure) =>
        //        {
        //            UserDialogs.Instance.HideLoading();
        //        });
        //    });
        //}
        //private void DetailCommandExecution(int memberid)
        //{
        //    UserDialogs.Instance.ShowLoading();
        //    Task.Run(async () =>
        //    {
        //        await apiService.GetMemeberDetails(memberid, () =>
        //        {
        //            UserDialogs.Instance.HideLoading();
        //            MemberId = apiService.MemberDetailResponse.matrimonialMember.memberid;
        //            if (apiService.MemberDetailResponse.matrimonialMemberImageList != null
        //                && apiService.MemberDetailResponse.matrimonialMemberImageList.Count == 0)
        //            {
        //                apiService.MemberDetailResponse.matrimonialMemberImageList.Add(new MatrimonialMemberImageList
        //                {
        //                    imagename = ""
        //                });
        //            }
        //            if (apiService.MemberDetailResponse.matrimonialContactList != null
        //                && apiService.MemberDetailResponse.matrimonialContactList.Count == 0)
        //            {
        //                apiService.MemberDetailResponse.matrimonialContactList.Add(new MatrimonialContactList
        //                {
        //                   name="",
        //                   mobile="",
        //                   relation="",
        //                   address1="",
        //                   address2="",
        //                   city="",
        //                   state="",
        //                   district=""
        //                });
        //            }
        //            MemberDetailResponse = apiService.MemberDetailResponse;
                    
        //        }, (failure) =>
        //        {
        //            UserDialogs.Instance.HideLoading();
        //        });
        //    });
        //}


        private void ShortListMemberCommandExecution(MatrimonialMember member)
        {
            App.DatabaseService.SaveOrUpdate(new Member { MemberId = member.memberid, FirstName = member.fullname });
            ToastConfig.Message = $"{ member.fullname } is short listed.";
            ToastConfig.Position = ToastPosition.Bottom;
            UserDialogs.Instance.Toast(ToastConfig);
        }

        private async void LoadWanshCommandExecution()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            //UserDialogs.Instance.ShowLoading();
            //Task.Run(async () =>
            //{
            await apiService.GetWanshList(() =>
            {
                //UserDialogs.Instance.HideLoading();
                if (apiService.WanshResponse.WanshList?.Count >= 0)
                {
                    WanshList = new ObservableCollection<Wansh>(apiService.WanshResponse.WanshList);
                }
                IsBusy = false;
            }, (failure) =>
            {
                IsBusy = false;
                //UserDialogs.Instance.HideLoading();
            });
            //});
        }

        #endregion
    }
}

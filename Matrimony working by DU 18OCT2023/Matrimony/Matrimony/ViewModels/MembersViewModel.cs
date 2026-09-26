using Acr.UserDialogs;
using Matrimony.Helper;
using Matrimony.Models;
using Matrimony.Models.Matrimonial;
using Matrimony.Models.Request;
using Matrimony.Models.Response;
using Matrimony.Views.Matrimonial;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Maps;

namespace Matrimony.ViewModels
{
    public class MembersViewModel : BaseViewModel
    {
        public MembersViewModel()
        {
            IsMembersListEmpty = true;
            IsEmpty = false;
            MembersCommand.Execute(null);
        }
        ObservableCollection<CommitteeMember> committeeMemberList= new ObservableCollection<CommitteeMember> {
                    new CommitteeMember { Name="श्री राजेंद्र जैन",Position="अध्यक्ष" ,Image="598" },
                    new CommitteeMember { Name="श्री विनोद जैन फारेस्ट",Position="उपाध्यक्ष" ,Image="876" },
                    new CommitteeMember { Name = "श्री वीरेंद्र कुमार जैन बम्होरी", Position = "उपाध्यक्ष", Image = "844" },
                    new CommitteeMember { Name = "श्री तारा चंद्र जैन ऐस बी आई", Position = "उपाध्यक्ष", Image = "822" },
                    new CommitteeMember { Name = "डॉ के के जैन रोहित नगर", Position = "उपाध्यक्ष", Image = "371" },
                    new CommitteeMember { Name = "श्री सिंघई चंद्र कुमार जैन", Position = "सचिव", Image = "231" },
                    new CommitteeMember { Name = "श्री मयंक जैन", Position = "कोषाध्यक्ष", Image = "38" },
                    new CommitteeMember { Name = "श्रीमती सुजाता जैन निवार", Position = "सहसचिव", Image = "13" },
                    new CommitteeMember { Name = "श्री ब्रतेश जैन", Position = "सदस्य", Image = "227" },
                    new CommitteeMember { Name = "श्री गौरव  हरीश जैन", Position = "", Image = "54" },
                    new CommitteeMember { Name = "श्री अजित जैन सुनवाहा", Position = "सदस्य", Image = "130" },
                    new CommitteeMember { Name = "श्री अभिषेक जैन मड़देवरा", Position = "सदस्य", Image = "115" },
                   
                    new CommitteeMember { Name = "डॉ श्रीमती रूबी जैन", Position = "सदस्य", Image = "57" },
                    new CommitteeMember { Name = "श्री सौरभ संतोष जैन कोटरा", Position = "सदस्य", Image = "709" },
                    new CommitteeMember { Name = "श्री आशीष जैन सिंघई एस बी आई", Position = "सदस्य", Image = "209" },
                    new CommitteeMember { Name = "श्री कैलाश जैन भानपुर", Position = "सदस्य", Image = "380" }
                };
        public ObservableCollection<CommitteeMember> CommitteeMemberList
        {
            get { 
                return committeeMemberList; 
            
            }
            set
            {
                committeeMemberList = value;
                RaisePropertyChanged(() => CommitteeMemberList);
            }
        }
        public ObservableCollection<CommitteeMember> CommitteeMemberList1
        {
            get
            {
                return new ObservableCollection<CommitteeMember> {
                    new CommitteeMember { Name="श्री राजेंद्र जैन",Position="अध्यक्ष" ,Image="" },
                    new CommitteeMember { Name="श्री विनोद जैन फारेस्ट",Position="उपाध्यक्ष" ,Image="" },
                    new CommitteeMember { Name="श्री वीरेंद्र कुमार जैन बम्होरी",Position="उपाध्यक्ष" ,Image="" },
                    new CommitteeMember { Name="श्री तारा चंद्र जैन ऐस बी आई",Position="उपाध्यक्ष" ,Image="" },
                    new CommitteeMember { Name="डॉ के के जैन रोहित नगर",Position="उपाध्यक्ष" ,Image="" },
                    new CommitteeMember { Name="श्री सिंघई चंद्र कुमार जैन",Position="सचिव" ,Image="" },
                    new CommitteeMember { Name="श्री मयंक जैन",Position="कोषाध्यक्ष" ,Image="" },
                    new CommitteeMember { Name="श्रीमती सुजाता जैन निवार",Position="सहसचिव" ,Image="" },
                    new CommitteeMember { Name="श्री ब्रतेश जैन",Position="सदस्य" ,Image="" },
                    new CommitteeMember { Name="श्री गौरव  हरीश जैन",Position="" ,Image="" },
                    new CommitteeMember { Name="श्री अजित जैन सुनवाहा",Position="सदस्य" ,Image="" },
                    new CommitteeMember { Name="श्री अभिषेक जैन मड़देवरा",Position="सदस्य" ,Image="" },
                   
                    new CommitteeMember { Name="डॉ श्रीमती रूबी जैन",Position="सदस्य" ,Image="" },
                    new CommitteeMember { Name="श्री सौरभ संतोष जैन कोटरा",Position="सदस्य" ,Image="" },
                    new CommitteeMember { Name="श्री आशीष जैन एस बी आई",Position="सदस्य" ,Image="" },
                    new CommitteeMember { Name="श्री कैलाश जैन भानपुर",Position="सदस्य" ,Image="" }
                };
            }
            set
            {
                CommitteeMemberList1 = value;
                RaisePropertyChanged(() => CurrentPage);
            }
        }

        string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                RaisePropertyChanged(() => SearchText);
            }
        }

        private Member member;
        public Member Member
        {
            get { return member; }
            set
            {
                member = value;
                RaisePropertyChanged(() => Member);
            }
        }
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                RaisePropertyChanged(() => FirstName);
            }
        }
        private string selectEducation;
        public string SelectEducation
        {
            get { return selectEducation; }
            set
            {
                selectEducation = value;
                RaisePropertyChanged(() => SelectEducation);
            }
        }
        private ImageSource photo;
        public ImageSource Photo
        {
            get { return photo; }
            set
            {
                photo = value;
                RaisePropertyChanged(() => Photo);
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
        public string GetImageUrl
        {
            get
            {
                return "welcome";
            }
        }
        private ObservableCollection<Member> membersList;
        public ObservableCollection<Member> MembersList
        {
            get { return membersList; }
            set
            {
                membersList = value;
                RaisePropertyChanged(() => MembersList);
            }
        }
        private ObservableCollection<Member> membersListInMemory;
        public ObservableCollection<Member> MembersListInMemory
        {
            get { return membersListInMemory; }
            set
            {
                membersListInMemory = value;
                RaisePropertyChanged(() => MembersListInMemory);
            }
        }

        public string kundaliImageNameUrl
        {
            get
            {
                
                return App.AppHostUrl+"images/kundali.png";
            }
        }
        public List<MemberImage> MemberImageList  {
            get {
                return new List<MemberImage>{
                    new MemberImage { id=1, memberid=3, imagename = "1.jpg" },
                    new MemberImage { id = 2, memberid = 3, imagename = "2.jpg" },
                    new MemberImage { id = 3, memberid = 3, imagename = "3.jpg" },
                    new MemberImage { id = 4, memberid = 3, imagename = "4.jpg" },
                    new MemberImage { id = 5, memberid = 3, imagename = "5.jpg" }
                };
                //return new List<MemberImage> { new MemberImage { imagename = "" } };
            }
        }

        private MembersResponse membersResponse;
        public MembersResponse MembersResponse
        {
            get {
                if (membersResponse == null)
                {
                    membersResponse = new MembersResponse();
                    membersResponse.list = new List<Member>();
                }
                return membersResponse; 
            }
            set
            {
                membersResponse = value;
                RaisePropertyChanged(() => MembersResponse);
            }
        }

        private AddGroupMemberResponse addGroupMemberResponse;
        public AddGroupMemberResponse AddGroupMemberResponse
        {
            get { return addGroupMemberResponse; }
            set
            {
                addGroupMemberResponse = value;
                RaisePropertyChanged(() => AddGroupMemberResponse);
            }
        }

        private ObservableCollection<Member> birthdayMarriageAnniversaryMembersList;
        public ObservableCollection<Member> BirthdayMarriageAnniversaryMembersList
        {
            get { return birthdayMarriageAnniversaryMembersList; }
            set
            {
                birthdayMarriageAnniversaryMembersList = value;
                RaisePropertyChanged(() => BirthdayMarriageAnniversaryMembersList);
            }
        }

        private MembersResponse birthdayMarriageAnniversaryMembersResponse;
        public MembersResponse BirthdayMarriageAnniversaryMembersResponse
        {
            get
            {
                if (birthdayMarriageAnniversaryMembersResponse == null)
                {
                    birthdayMarriageAnniversaryMembersResponse = new MembersResponse();
                    birthdayMarriageAnniversaryMembersResponse.list = new List<Member>();
                }
                return birthdayMarriageAnniversaryMembersResponse;
            }
            set
            {
                birthdayMarriageAnniversaryMembersResponse = value;
                RaisePropertyChanged(() => BirthdayMarriageAnniversaryMembersResponse);
            }
        }

        private ObservableCollection<Member> birthdayMarriageAnniversaryMembersList1;
        public ObservableCollection<Member> BirthdayMarriageAnniversaryMembersList1
        {
            get { return birthdayMarriageAnniversaryMembersList1; }
            set
            {
                birthdayMarriageAnniversaryMembersList1 = value;
                RaisePropertyChanged(() => BirthdayMarriageAnniversaryMembersList1);
            }
        }

        private MembersResponse birthdayMarriageAnniversaryMembersResponse1;
        public MembersResponse BirthdayMarriageAnniversaryMembersResponse1
        {
            get
            {
                if (birthdayMarriageAnniversaryMembersResponse1 == null)
                {
                    birthdayMarriageAnniversaryMembersResponse1 = new MembersResponse();
                    birthdayMarriageAnniversaryMembersResponse1.list = new List<Member>();
                }
                return birthdayMarriageAnniversaryMembersResponse1;
            }
            set
            {
                birthdayMarriageAnniversaryMembersResponse1 = value;
                RaisePropertyChanged(() => BirthdayMarriageAnniversaryMembersResponse1);
            }
        }

        public int TabIndex { get; set; }

        MemberImage _currentPage;
        public MemberImage CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                _currentPage = value;
                RaisePropertyChanged(() => CurrentPage);
            }
        }


        private ObservableCollection<Member> pjksGroupCommitteeMembersList;
        public ObservableCollection<Member> PJKSGroupCommitteeMembersList
        {
            get { return pjksGroupCommitteeMembersList; }
            set
            {
                pjksGroupCommitteeMembersList = value;
                RaisePropertyChanged(() => PJKSGroupCommitteeMembersList);
            }
        }

        private MembersResponse pjksGroupCommitteeMembersResponse;
        public MembersResponse PJKSGroupCommitteeMembersResponse
        {
            get
            {
                if (pjksGroupCommitteeMembersResponse == null)
                {
                    pjksGroupCommitteeMembersResponse = new MembersResponse();
                    pjksGroupCommitteeMembersResponse.list = new List<Member>();
                }
                return pjksGroupCommitteeMembersResponse;
            }
            set
            {
                pjksGroupCommitteeMembersResponse = value;
                RaisePropertyChanged(() => PJKSGroupCommitteeMembersResponse);
            }
        }

        GroupMemberResponse groupMemberDetailResponse;
        public GroupMemberResponse GroupMemberDetailResponse
        {
            get
            {
                if (groupMemberDetailResponse == null)
                {
                    groupMemberDetailResponse = new GroupMemberResponse();
                    groupMemberDetailResponse.member = new Member();
                    groupMemberDetailResponse.familyMemberList = new List<Member>();
                    groupMemberDetailResponse.memberImageList = new List<MemberImage>();
                }
                return groupMemberDetailResponse;
            }
            set
            {
                //if (groupMemberDetailResponse != null)
                //{
                //    groupMemberDetailResponse.ClearLists();
                //}
                groupMemberDetailResponse = value;
                RaisePropertyChanged(() => GroupMemberDetailResponse);
            }
        }
         public void ClearData()
        {
            if (groupMemberDetailResponse != null)
            {
                groupMemberDetailResponse.ClearLists();
            }
            groupMemberDetailResponse = null;
            
        }

        public bool IsEmpty { get; set; }
        public bool IsMembersListEmpty { get; set; }
        #region "Advanced Search"

        public double? latitude;
        public double? longitude;
        public double Longitude
        {
            get
            {
                return Constant.currentLat;
            }
            set
            {
                longitude = value;
            }
        }
        public double Latitude
        {
            get
            {
                return Constant.currentLng;// latitude == null ? 0.0 : Convert.ToDouble(latitude);
            }
            set
            {
                latitude = value;
            }
        }

        private Wansh wans;
        public Wansh Wans
        {
            get { return wans; }
            set
            {
                wans = value;
                RaisePropertyChanged(() => Wans);
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

        string minage;
        public string MinAge
        {
            get { return minage; }
            set
            {
                minage = value;
                RaisePropertyChanged(() => MinAge);
            }
        }
        string maxage;
        public string MaxAge
        {
            get { return maxage; }
            set
            {
                maxage = value;
                RaisePropertyChanged(() => MaxAge);
            }
        }

        


        #endregion

        #region Set Commands
        public Command<int> MembersCommand { get { return new Command<int>(ExecuteGetMembersCommand); } }
        public Command<int> BirthdayMarriageAnniversaryMembersCommand { get { return new Command<int>(ExecuteGetBirthdayMarriageAnniversaryMembersCommand); } }
        public Command<int> GroupMemeberDetailsCommand { get { return new Command<int>(GroupMemeberDetailsCommandExecution); } }
        public Command<int> ViewGroupMemeberDetailCommand { get { return new Command<int>(ViewGroupMemeberDetailCommandExecution); } }
        public Command<string> SearchCommand { get { return new Command<string>(SearchCommandExecution); } }

        public Command<int> GetPJKSGroupCommitteeListCommand { get { return new Command<int>(ExecuteGetPJKSGroupCommitteeListCommand); } }

        public ICommand OpenAdvanceSearchPageCommand => new Command(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.PJKSMenu.AdvancedSearch(), true));

        public Command AdvanceSearchCommand => new Command(AdvanceSearchCommandExecution);
        public Command LoadWanshCommand { get { return new Command(LoadWanshCommandExecution); } }

        public Command SaveCommand => new Command(SaveCommandExecution);
        #endregion

        #region Command Execution
        private async void ExecuteGetMembersCommand(int a)
        {
            if (IsBusy) return;
            IsBusy = true;
            UserDialogs.Instance.ShowLoading();
            await apiService.GetMembers(() =>
            {
                UserDialogs.Instance.HideLoading();
                if (membersResponse == null || MembersList?.Count == 0)
                {
                    MembersResponse = apiService.MembersResponse;
                    MembersList = new ObservableCollection<Member>(apiService.MembersResponse.list);
                    MembersListInMemory = new ObservableCollection<Member>(apiService.MembersResponse.list);
                }
                else
                {
                    var newList = apiService.MembersResponse.list.Skip(MembersList.Count).ToList();
                    foreach (var i in newList)
                    {
                        MembersList.Add(i);
                    }
                }
                IsBusy = false;
            },
            (requestFailedReason) =>
                     {
                         //UserDialogs.Instance.Alert(requestFailedReason.ErrorMessage, null, "OK");
                         //UserDialogs.Instance.HideLoading();
                     });
        }
        
        private void ViewGroupMemeberDetailCommandExecution(int memberid)
        {
            //if(memberid==3)
            //    Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.PJKSMenu.TestDetailPage(memberid), true));
            //else
                Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.PJKSMenu.MemberDetail(memberid), true));
        }
        private void GroupMemeberDetailsCommandExecution(int memberid)
        {
            UserDialogs.Instance.ShowLoading();
            if (groupMemberDetailResponse != null && GroupMemberDetailResponse.memberImageList != null)
                GroupMemberDetailResponse.memberImageList.Clear();
            Task.Run(async () =>
            {
                await apiService.GetGroupMemeberDetail(memberid, () =>
                {
                    UserDialogs.Instance.HideLoading();
                    MemberId = apiService.GroupMemberResponse.member.MemberId;

                    if (apiService.GroupMemberResponse.memberImageList == null)
                        apiService.GroupMemberResponse.memberImageList = new List<MemberImage>();

                    if (apiService.GroupMemberResponse.memberImageList != null
                        && apiService.GroupMemberResponse.memberImageList.Count == 0)
                    {
                        apiService.GroupMemberResponse.memberImageList.Add(new MemberImage
                        {
                            imagename = ""
                        });
                    }
                    GroupMemberDetailResponse = apiService.GroupMemberResponse;
                 }, (failure) =>
                {
                    UserDialogs.Instance.HideLoading();
                });
            });
        }

        private void SearchCommandExecution(string searchtext)
        {
            UserDialogs.Instance.ShowLoading();
            Task.Run(async () =>
            {
                try
                {
                    /*Device.BeginInvokeOnMainThread(async () =>
                    {
                        ObservableCollection<CommitteeMember>  CommitteeMemberList1 = new ObservableCollection<CommitteeMember>(
                            CommitteeMemberList.Where(x => x.Position == "सदस्य")
                        );
                        committeeMemberList.Clear();
                        foreach(var m in CommitteeMemberList1) {
                            committeeMemberList.Add(m);
                        }
                        UserDialogs.Instance.HideLoading();
                    });*/
                    if (TabIndex == 0)
                    {
                        membersList.Clear();
                        ObservableCollection<Member> membersListFiltered = new ObservableCollection<Member>(
                                MembersListInMemory.Where(x => x.FirstName.Contains(searchtext)
                                                || x.Mobile.Contains(searchtext) || x.MemberId.ToString().Contains(searchtext)
                                                || x.MemberNo.ToString().Contains(searchtext) || x.Address1.Contains(searchtext))
                            );

                        //Device.BeginInvokeOnMainThread(async () =>
                        //{
                        //    membersList.Clear();
                        //});
                        Device.BeginInvokeOnMainThread(async () =>
                        {

                            if (membersList.Count == 0)
                            {
                                if (string.IsNullOrEmpty(searchtext))
                                {
                                    foreach (var m in MembersListInMemory)
                                    {
                                        membersList.Add(m);
                                    }
                                }
                                else
                                {
                                    foreach (var m in membersListFiltered)
                                    {
                                        membersList.Add(m);
                                    }
                                }
                            }

                            UserDialogs.Instance.HideLoading();
                        });
                    }
                    else if (TabIndex == 1)
                    {
                        
                        PJKSGroupCommitteeMembersList.Clear();
                        ObservableCollection<Member> membersListFiltered = new ObservableCollection<Member>(
                                PJKSGroupCommitteeMembersResponse.list.Where(x => x.FirstName.Contains(searchtext)
                                                || x.Mobile.Contains(searchtext) || x.MemberId.ToString().Contains(searchtext)
                                                || x.MemberNo.ToString().Contains(searchtext) || x.Address1.Contains(searchtext))
                            );
                        Device.BeginInvokeOnMainThread(async () =>
                        {

                            if (PJKSGroupCommitteeMembersList.Count == 0)
                            {
                                if (string.IsNullOrEmpty(searchtext))
                                {
                                    foreach (var m in PJKSGroupCommitteeMembersResponse.list)
                                    {
                                        PJKSGroupCommitteeMembersList.Add(m);
                                    }
                                }
                                else
                                {
                                    foreach (var m in membersListFiltered)
                                    {
                                        PJKSGroupCommitteeMembersList.Add(m);
                                    }
                                }
                            }

                            UserDialogs.Instance.HideLoading();
                        });
                    }
                    else if (TabIndex == 2)
                    {
                        BirthdayMarriageAnniversaryMembersList.Clear();
                        ObservableCollection<Member> membersListFiltered = new ObservableCollection<Member>(
                                BirthdayMarriageAnniversaryMembersResponse.list.Where(x => x.FirstName.Contains(searchtext)
                                                || x.Mobile.Contains(searchtext) || x.MemberId.ToString().Contains(searchtext)
                                                || x.MemberNo.ToString().Contains(searchtext) || x.Address1.Contains(searchtext))
                            );
                        Device.BeginInvokeOnMainThread(async () =>
                        {

                            if (BirthdayMarriageAnniversaryMembersList.Count == 0)
                            {
                                if (string.IsNullOrEmpty(searchtext))
                                {
                                    foreach (var m in BirthdayMarriageAnniversaryMembersResponse.list)
                                    {
                                        BirthdayMarriageAnniversaryMembersList.Add(m);
                                    }
                                }
                                else
                                {
                                    foreach (var m in membersListFiltered)
                                    {
                                        BirthdayMarriageAnniversaryMembersList.Add(m);
                                    }
                                }
                            }

                            UserDialogs.Instance.HideLoading();
                        });
                    }
                }
                catch (Exception ex)
                {
                    UserDialogs.Instance.HideLoading();
                }

                /*await apiService.SearchPJKSDataList(searchtext, () =>
                {
                    try
                    {
                        UserDialogs.Instance.HideLoading();
                        //MembersResponse = apiService.SearchPJKSResponse;
                        Device.BeginInvokeOnMainThread(async () =>
                        {
                            membersList.Clear();
                            int listc = apiService.SearchPJKSResponse.list.Count();
                            membersList = new ObservableCollection<Member>(apiService.SearchPJKSResponse.list);
                            listc = membersList.Count();
                        });

                    }
                    catch (Exception ex)
                    {
                        UserDialogs.Instance.HideLoading();
                    }
                }, (failure) =>
                {
                    UserDialogs.Instance.HideLoading();
                });*/
            });
        }

        private async void ExecuteGetPJKSGroupCommitteeListCommand(int GroupId)
        {
            if (IsBusy) return;
            IsBusy = true;
            UserDialogs.Instance.ShowLoading();
            await apiService.GetPJKSGroupCommitteeList(GroupId ,() =>
            {
                UserDialogs.Instance.HideLoading();
                
                if (PJKSGroupCommitteeMembersList == null || PJKSGroupCommitteeMembersList?.Count == 0)
                {
                    PJKSGroupCommitteeMembersResponse = apiService.PJKSGroupCommitteeMembersResponse;
                    PJKSGroupCommitteeMembersList = new ObservableCollection<Member>(apiService.PJKSGroupCommitteeMembersResponse.list);
                }
                else
                {
                    var newList = apiService.PJKSGroupCommitteeMembersResponse.list.Skip(PJKSGroupCommitteeMembersList.Count).ToList();
                    foreach (var i in newList)
                    {
                        PJKSGroupCommitteeMembersList.Add(i);
                    }
                }
                IsBusy = false;
            },
            (requestFailedReason) =>
            {
                //UserDialogs.Instance.Alert(requestFailedReason.ErrorMessage, null, "OK");
                //UserDialogs.Instance.HideLoading();
            });
        }

        private async void ExecuteGetBirthdayMarriageAnniversaryMembersCommand(int a)
        {
            if (IsBusy) return;
            IsBusy = true;
            UserDialogs.Instance.ShowLoading();
            await apiService.GetBirthdayMarriageAnniversaryMembers(() =>
            {
                UserDialogs.Instance.HideLoading();
                if (BirthdayMarriageAnniversaryMembersList == null || BirthdayMarriageAnniversaryMembersList?.Count == 0)
                {
                    BirthdayMarriageAnniversaryMembersResponse = apiService.BirthdayMarriageAnniversaryMembersResponse;
                    BirthdayMarriageAnniversaryMembersList = new ObservableCollection<Member>(apiService.BirthdayMarriageAnniversaryMembersResponse.list);
                }
                else
                {
                    var newList = apiService.BirthdayMarriageAnniversaryMembersResponse.list.Skip(BirthdayMarriageAnniversaryMembersList.Count).ToList();
                    foreach (var i in newList)
                    {
                        BirthdayMarriageAnniversaryMembersList.Add(i);
                    }
                }
                IsBusy = false;
            },
            (requestFailedReason) =>
            {
                //UserDialogs.Instance.Alert(requestFailedReason.ErrorMessage, null, "OK");
                //UserDialogs.Instance.HideLoading();
            });
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

        private void AdvanceSearchCommandExecution()
        {
            UserDialogs.Instance.ShowLoading();
            string searchtext = "9893297289";
            Device.BeginInvokeOnMainThread(async () =>
            {
                await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopAsync();
            });
            Task.Run(async () =>
            {
                try
                {
                    membersList.Clear();

                    Models.Request.AdvanceSearchRequest advanceSearchRequest = new Models.Request.AdvanceSearchRequest
                    {
                        minage = MinAge == null ? "" : $"{DateTime.Now.Year - Convert.ToInt32(MinAge.Remove(MinAge.Length - 5).TrimEnd())}-{DateTime.Now.Month}-{DateTime.Now.Day}",
                        maxage = MaxAge == null ? "" : $"{DateTime.Now.Year - Convert.ToInt32(MaxAge.Remove(MaxAge.Length - 5).TrimEnd())}-{DateTime.Now.Month}-{DateTime.Now.Day}",
                    };
                    advanceSearchRequest.gender = "";
                    advanceSearchRequest.wansh = wans.wanshInHindi;
                    UserDialogs.Instance.ShowLoading();

                    await apiService.GetPJKSAdvanceSearchList(advanceSearchRequest, () =>
                    {
                        

                        Device.BeginInvokeOnMainThread(async () =>
                        {

                            if (membersList.Count == 0 && apiService.MembersResponse.list.Count() > 0)
                            {
                                MembersResponse = apiService.MembersResponse;
                                MembersList = new ObservableCollection<Member>(apiService.MembersResponse.list);
                                UserDialogs.Instance.HideLoading();
                            }
                            else
                            {
                                /*foreach (var m in MembersListInMemory)
                                {
                                    membersList.Add(m);
                                }*/
                                //IsMembersListEmpty = false;
                                //IsEmpty = true;
                                UserDialogs.Instance.HideLoading();
                                Acr.UserDialogs.UserDialogs.Instance.Alert("No Record Found In Search");
                                Member Member = new Member();
                                Member.MemberId = 0;
                                Member.MemberNo = 0;
                                membersList.Add(Member);

                            }
                        });

                    }, (failure) =>
                    {
                        UserDialogs.Instance.HideLoading();
                    });
                   
                    
                }
                catch (Exception ex)
                {
                    UserDialogs.Instance.HideLoading();
                }

            });
        }

        private void SaveCommandExecution()
        {
            if (IsValidate())
            {
                UserDialogs.Instance.ShowLoading();
                Task.Run(async () =>
                {
                    try
                    {
                        AddGroupMemberRequest addGroupMemberRequest = new AddGroupMemberRequest
                        {
                            FirstName = FirstName,
                            middlename = "",
                            LastName = "",
                            //email = EMail,
                            //mobile = MobileNo,
                            //address = Address,
                            //birthplace = BirthPlace,
                            //birthtime = BirthTime.ToString(),
                            //bloodgroup = BloodGroup,
                            //brothers = int.Parse(Brothers),
                            //sisters = int.Parse(Sisters),
                            //city = City,
                            //state = State,
                            //zip = ZipCode,
                            //education = SelectEducation,
                            //familyoccupation = SelectOccupation,
                            //fathername = FatherName,
                            //mangali = IsManglik ? "Yes" : "No",
                            //milan = IsMilan ? "Yes" : "No",
                            //wans = Wans.id.ToString(),
                            //gender = IsMale ? "Male" : "Female",
                            //gotra = Gotra.wansh,
                            //income = Convert.ToDecimal(MonthlyIncome),
                            //mobile2 = ContactNo,
                            //occupation = SelectOccupation,
                            //religion = SelectedReligion,
                            //subreligion = SubSelectedReligion,
                            //dob = BirthDate.ToString("yyyy/MM/dd")
                        };
                        if (Photo is StreamImageSource)
                        {
                            StreamImageSource streamImageSource = (StreamImageSource)Photo;
                            System.Threading.CancellationToken cancellationToken = System.Threading.CancellationToken.None;
                            Task<Stream> task = streamImageSource.Stream(cancellationToken);
                            Stream stream = task.Result; byte[] byteArray;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                stream.CopyTo(ms);
                                byteArray = ms.ToArray();
                            }
                            addGroupMemberRequest.imageBase64String = Convert.ToBase64String(byteArray);
                        }

                        await apiService.AddGroupMember(addGroupMemberRequest, () =>
                        {
                            UserDialogs.Instance.HideLoading();
                            AddGroupMemberResponse = apiService.AddGroupMemberResponse;
                            //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopAsync(true));
                            //App.AppSetup.MatrimonialViewModel.ViewGroomDetailCommand.Execute(addGroupMemberResponse.MemberId);
                        }, (failure) =>
                        {
                            UserDialogs.Instance.HideLoading();
                        });
                    }
                    catch (Exception ex)
                    {
                        UserDialogs.Instance.HideLoading();

                    }
                });

            }
        }
        #endregion

        private bool IsValidate()
        {
            return true;
            bool validate = false;
            if (string.IsNullOrEmpty(member.FirstName))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("First name field is empty.");
                return false;
            }
            //else if (string.IsNullOrEmpty(LastName))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Last name field is empty.");
            //    return false;
            //}
            else if (string.IsNullOrEmpty(member.Mobile))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Mobile number field is empty.");
                return false;
            }
            //else if (string.IsNullOrEmpty(EMail))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Email field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(BirthPlace))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Birth place field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(SelectedReligion))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Please select religion.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(SubSelectedReligion))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Please select sub-religion.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(SelectedHeightInft))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Please select height in feet.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(SelectedHeightInInch))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Please select height in inches.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(MonthlyIncome))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Monthly income field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(Address))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Address field is empty.");
            //    return false;
            //}
            else if (string.IsNullOrEmpty(member.city))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("City field is empty.");
                return false;
            }
            //else if (string.IsNullOrEmpty(State))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("State field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(ZipCode))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Zipcode field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(FatherName))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Father name field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(MotherName))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Mother name field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(SelectOccupation))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Zipcode field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(Sisters))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Number of sister field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(Brothers))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Number of brother field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(SelectEducation))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Select education field.");
            //    return false;
            //}
            else
            {
                return true;
            }

            return validate;
        }

        public void ReSet()
        {
            //FirstName = "";
            //MiddleName = "";
            //LastName = "";
            //EMail = "";
            //MobileNo = "";
            //Address = "";
            //BirthPlace = "";
            //BloodGroup = "";
            //Brothers = "0";
            //Sisters = "0";
            //City = "";
            //State = "";
            //ZipCode = "";
            //SelectEducation = "";
            //SelectOccupation = "";
            //FatherName = "";
            ////Gotra = "";
            //MonthlyIncome = "";
            //ContactNo = "";
            //SelectOccupation = "";
            //SelectedReligion = "";
            //SubSelectedReligion = "";
        }


        INavigation navigation;
        public CustomMap map { get; set; }
        private bool _IsReceviedData = false;
        public bool IsReceviedData
        {
            get { return _IsReceviedData; }
            set
            {
                _IsReceviedData = value;
                RaisePropertyChanged(() => IsReceviedData);
            }
        }

        private NearByResponse _nearByResponse;
        public NearByResponse nearByResponse
        {
            get { return _nearByResponse; }
            set
            {
                _nearByResponse = value;
                RaisePropertyChanged(() => nearByResponse);
            }
        }

        public async Task GetAroundPeople(INavigation _nav)
        {
            navigation = _nav;
            UserDialogs.Instance.ShowLoading();

            try
            {
                await apiService.GetNearByList("5", Constant.currentLat.ToString(), Constant.currentLng.ToString(), () =>
                {
                    UserDialogs.Instance.HideLoading();
                    IsReceviedData = true;
                    nearByResponse = apiService.nearByResponse;
                    foreach (var nearBy in nearByResponse.list)
                    {
                        CustomPin pin = new CustomPin
                        {
                            Label = nearBy.FullName,
                            Address = nearBy.GetAddress,
                            Type = PinType.Generic,
                            Position = new Position(nearBy.latitude, nearBy.longitude),
                            MemberID = nearBy.MemberNo,
                            gender = ""

                        };
                        pin.MarkerClicked += Pin_MarkerClicked;
                        pin.InfoWindowClicked += Pin_InfoWindowClicked;
                        map.Pins.Add(pin);
                    }
                    Device.BeginInvokeOnMainThread(() => {
                        var position = new Position(Constant.currentLat, Constant.currentLng);
                        map.MoveToRegion(new MapSpan(position, 10, 10));
                    });
                }, (failure) =>
                {
                    IsReceviedData = false;
                    UserDialogs.Instance.HideLoading();
                });

            }
            catch (Exception ex)
            {
                IsReceviedData = false;
                UserDialogs.Instance.HideLoading();

            }
        }

        private void Pin_InfoWindowClicked(object sender, PinClickedEventArgs e)
        {
            var customPin = (CustomPin)sender;
            if (customPin.gender.ToLower().Equals("female"))
            {
                navigation.PushAsync(new BridalDetailView(customPin.MemberID));
            }
            else
            {
                navigation.PushAsync(new GroomDetailView(customPin.MemberID));
            }
        }

        private void Pin_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            var customPin = (CustomPin)sender;
        }
    }
}

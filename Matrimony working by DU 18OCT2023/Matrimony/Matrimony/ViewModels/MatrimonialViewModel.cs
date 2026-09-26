using Acr.UserDialogs;
using Matrimony.Models;
using Matrimony.Models.Matrimonial;
using Matrimony.Models.Response;
using Matrimony.Views;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Matrimony.ViewModels
{
    public class MatrimonialViewModel : BaseViewModel
    {
        public MatrimonialViewModel()
        {
            SearchText = "Atul";
            ReSet();
        }
        public INavigation Navigation { get; set; }
        public List<ImageModel> AstrologyImageList
        {
            get
            {
                return new List<ImageModel> {
                    new ImageModel { ImagePath="gallery/astrology",imagename="astrology1.PNG" },
                    new ImageModel { ImagePath="gallery/astrology",imagename="astrology2.PNG" }, 
                    new ImageModel { ImagePath="gallery/astrology",imagename="astrology3.PNG" },
                    new ImageModel { ImagePath="gallery/astrology",imagename="astrology4.PNG" },
                    new ImageModel { ImagePath="gallery/astrology",imagename="astrology5.PNG" },
                    new ImageModel { ImagePath="gallery/astrology",imagename="astrology6.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology7.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology8.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology9.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology10.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology11.PNG" }
                };
            }
        }

        public List<MemberImage> MemberImageList
        {
            get
            {
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
        public List<ImageModel> VastuVigyanImageList
        {
            get
            {
                return new List<ImageModel> {
                    new ImageModel { ImagePath="gallery/vastu",imagename="vastu1.PNG" },
                    new ImageModel { ImagePath="gallery/vastu",imagename="vastu2.PNG" } ,
                    new ImageModel { ImagePath="gallery/vastu",imagename="vastu3.PNG" }
                    //new ImageModel { ImagePath="astrology",imagename="astrology4.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology5.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology6.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology7.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology8.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology9.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology10.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology11.PNG" }
                };
            }
        }

        public List<ImageModel> SwarVigyanImageList
        {
            get
            {
                return new List<ImageModel> {
                    new ImageModel { ImagePath="gallery/swarvigyan",imagename="swarvigyan1.PNG" },
                    new ImageModel { ImagePath="gallery/swarvigyan",imagename="swarvigyan2.PNG" },
                    new ImageModel { ImagePath="gallery/swarvigyan",imagename="swarvigyan3.PNG" },
                    new ImageModel { ImagePath="gallery/swarvigyan",imagename="swarvigyan4.PNG" },
                    new ImageModel { ImagePath="gallery/swarvigyan",imagename="swarvigyan5.PNG" },
                    new ImageModel { ImagePath="gallery/swarvigyan",imagename="swarvigyan6.PNG" }
                    //new ImageModel { ImagePath="astrology",imagename="astrology7.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology8.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology9.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology10.PNG" },
                    //new ImageModel { ImagePath="astrology",imagename="astrology11.PNG" }
                };
            }
        }

        public List<ImageModel> MudraVigyanImageList
        {
            get
            {
                return new List<ImageModel> {
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="1.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="2.PNG" } ,
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="3.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="4.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="5.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="6.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="7.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="8.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="9.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="10.PNG" } ,
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="11.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="12.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="13.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="14.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="15.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="16.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="17.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="18.PNG" } ,
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="19.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="20.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="21.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="22.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="23.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="24.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="25.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="26.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="27.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="28.PNG" },
                    new ImageModel { ImagePath="gallery/mudravigyan",imagename="29.PNG" }
                };
            }
        }

        #region Set Property
        public string kundaliImageNameUrl
        {
            get
            {
                return App.AppHostUrl+ "images/kundali.png";
            }
        }
        public string GirlImageUrl
        {
            get
            {
                return "bridedulhanimage";
            }
        }
        public string BoyImageUrl
        {
            get
            {
                return "groomdulhaimage";
            }
        }
        public string GirlCard
        {
            get
            {
                return App.AppHostUrl +"images/girlcard.png";
            }
        }
        public string BoyCard
        {
            get
            {
                return App.AppHostUrl + "images/boycard.png";
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

        public string image { get; set; }

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
            get {
                if (memberDetailResponse == null)
                {
                    memberDetailResponse = new MemberDetailResponse();
                    memberDetailResponse.matrimonialMember = new MatrimonialMember();
                    memberDetailResponse.matrimonialContactList = new List<MatrimonialContact>();
                    memberDetailResponse.matrimonialFamilyMemberList = new List<MatrimonialFamilyMember>();
                    memberDetailResponse.matrimonialMemberImageList = new List<MatrimonialMemberImage>();
                }
                return memberDetailResponse; 
            }
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

        public ObservableCollection<JainCast> JainCastList
        {
            get { return new ObservableCollection<JainCast> { new JainCast {id=1, CastName= "Digember", CastNameInHindi= "दिगम्बर" }, new JainCast { id = 2, CastName = "Swetamber", CastNameInHindi = "श्वेताम्बर" } }; }
        }

        #endregion

        #region Matrimonial Member Property

        private MediaFile mediaFile;
        public MediaFile MediaFile
        {
            get { return mediaFile; }
            set
            {
                mediaFile = value;
                RaisePropertyChanged(() => MediaFile);
            }
        }

        private string mobileNo;
        public string MobileNo
        {
            get { return mobileNo; }
            set
            {
                mobileNo = value;
                RaisePropertyChanged(() => MobileNo);
            }
        }

        private string eMail;
        public string EMail
        {
            get { return eMail; }
            set
            {
                eMail = value;
                RaisePropertyChanged(() => EMail);
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
        private string middleName;
        public string MiddleName
        {
            get { return middleName; }
            set
            {
                middleName = value;
                RaisePropertyChanged(() => MiddleName);
            }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                RaisePropertyChanged(() => LastName);
            }
        }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
                RaisePropertyChanged(() => BirthDate);
            }
        }
        private TimeSpan birthTime;
        public TimeSpan BirthTime
        {
            get { return birthTime; }
            set
            {
                birthTime = value;
                RaisePropertyChanged(() => BirthTime);
            }
        }
        private string birthPlace;
        public string BirthPlace
        {
            get { return birthPlace; }
            set
            {
                birthPlace = value;
                RaisePropertyChanged(() => BirthPlace);
            }
        }

        private bool isMale;
        public bool IsMale
        {
            get { return isMale; }
            set
            {
                isMale = value;
                RaisePropertyChanged(() => IsMale);
            }
        }

        private string selectedReligion;
        public string SelectedReligion
        {
            get { return selectedReligion; }
            set
            {
                selectedReligion = value;
                RaisePropertyChanged(() => SelectedReligion);
            }
        }

        private string subselectedReligion;
        public string SubSelectedReligion
        {
            get { return subselectedReligion; }
            set
            {
                subselectedReligion = value;
                RaisePropertyChanged(() => SubSelectedReligion);
            }
        }

        private bool isManglik;
        public bool IsManglik
        {
            get { return isManglik; }
            set
            {
                isManglik = value;
                RaisePropertyChanged(() => IsManglik);
            }
        }
        private bool isMilan;
        public bool IsMilan
        {
            get { return isMilan; }
            set
            {
                isMilan = value;
                RaisePropertyChanged(() => IsMilan);
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
        private Wansh gotra;
        public Wansh Gotra
        {
            get { return gotra; }
            set
            {
                gotra = value;
                RaisePropertyChanged(() => Gotra);
            }
        }

        private string selectedHeightInft;
        public string SelectedHeightInft
        {
            get { return selectedHeightInft; }
            set
            {
                selectedHeightInft = value;
                RaisePropertyChanged(() => SelectedHeightInft);
            }
        }

        private string selectedHeightInInch;
        public string SelectedHeightInInch
        {
            get { return selectedHeightInInch; }
            set
            {
                selectedHeightInInch = value;
                RaisePropertyChanged(() => SelectedHeightInInch);
            }
        }
        private string monthlyIncome;
        public string MonthlyIncome
        {
            get { return monthlyIncome; }
            set
            {
                monthlyIncome = value;
                RaisePropertyChanged(() => MonthlyIncome);
            }
        }

        private string bloodGroup;
        public string BloodGroup
        {
            get { return bloodGroup; }
            set
            {
                bloodGroup = value;
                RaisePropertyChanged(() => BloodGroup);
            }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                RaisePropertyChanged(() => Address);
            }
        }
        private string city;
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                RaisePropertyChanged(() => City);
            }
        }
        private string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                RaisePropertyChanged(() => State);
            }
        }
        private string zipCode;
        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                zipCode = value;
                RaisePropertyChanged(() => ZipCode);
            }
        }

        private string fatherName;
        public string FatherName
        {
            get { return fatherName; }
            set
            {
                fatherName = value;
                RaisePropertyChanged(() => FatherName);
            }
        }

        private string motherName;
        public string MotherName
        {
            get { return motherName; }
            set
            {
                motherName = value;
                RaisePropertyChanged(() => MotherName);
            }
        }

        private string contactNo;
        public string ContactNo
        {
            get { return contactNo; }
            set
            {
                contactNo = value;
                RaisePropertyChanged(() => ContactNo);
            }
        }
        private string selectOccupation;
        public string SelectOccupation
        {
            get { return selectOccupation; }
            set
            {
                selectOccupation = value;
                RaisePropertyChanged(() => SelectOccupation);
            }
        }

        private string sisters;
        public string Sisters
        {
            get { return sisters; }
            set
            {
                sisters = value;
                RaisePropertyChanged(() => Sisters);
            }
        }

        private string brothers;
        public string Brothers
        {
            get { return brothers; }
            set
            {
                brothers = value;
                RaisePropertyChanged(() => Brothers);
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
        private string courceName;
        public string CourceName
        {
            get { return courceName; }
            set
            {
                courceName = value;
                RaisePropertyChanged(() => CourceName);
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
        private AddMemberResponse addMemberResponse;
        public AddMemberResponse AddMemberResponse
        {
            get { return addMemberResponse; }
            set
            {
                addMemberResponse = value;
                RaisePropertyChanged(() => AddMemberResponse);
            }
        }
        //private ObservableCollection<Wansh> wanshList;
        //public ObservableCollection<Wansh> WanshList
        //{
        //    get { return wanshList; }
        //    set
        //    {
        //        wanshList = value;
        //        RaisePropertyChanged(() => WanshList);
        //    }
        //}
        #endregion

        #region Set Commands
        public Command<int> ViewAllBridalCommand { get { return new Command<int>(ViewAllBridalCommandExecution); } }
        public Command<int> ViewAllGroomCommand { get { return new Command<int>(ViewAllGroomCommandExecution); } }
        public Command<int> ViewBridalDetailCommand { get { return new Command<int>(ViewBridalDetailCommandExecution); } }
        public Command<int> ViewGroomDetailCommand { get { return new Command<int>(ViewGroomDetailCommandExecution); } }
        public Command<int> LoadBridalCommand { get { return new Command<int>(LoadBridalCommandExecution); } }
        public Command<int> LoadGroomCommand { get { return new Command<int>(LoadGroomCommandExecution); } }
        public Command LoadDashboardCommand { get { return new Command(DashboardResponseCommandExecution); } }
        public Command<string> SearchCommand { get { return new Command<string>(SearchCommandExecution); } }
        public Command<int> DetailCommand { get { return new Command<int>(DetailCommandExecution); } }
        public Command<MatrimonialMember> ShortListMemberCommand { get { return new Command<MatrimonialMember>(ShortListMemberCommandExecution); } }

        public ICommand AdvanceSearchCommand => new Command(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.MatrimonialAdvancedSearch(), true));

        public Command LoadWanshCommand { get { return new Command(LoadWanshCommandExecution); } }

        public Command CameraCommand => new Command(CameraCommandExecution);

        public Command SaveCommand => new Command(SaveCommandExecution);

        #endregion

        #region Command Execution
        private async void LoadBridalCommandExecution(int pagingnumber)
        {
            if (IsBusy) return;
            IsBusy = true;
            UserDialogs.Instance.ShowLoading();
            // Task.Run(async () =>
            // {
            await apiService.GetBridalList(pagingnumber, () =>
            {
                UserDialogs.Instance.HideLoading();
                if (BridalListResponse == null || BridalList?.Count == 0)
                {
                    BridalListResponse = apiService.BridalListResponse;
                    BridalList = new ObservableCollection<MatrimonialMember>(apiService.BridalListResponse.BridalList);
                }
                else
                {
                    var newBridalList = apiService.BridalListResponse.BridalList.Skip(BridalList.Count).ToList();
                    foreach (var i in newBridalList)
                    {
                        BridalList.Add(i);
                    }
                }
                IsBusy = false;
            }, (failure) =>
            {
                UserDialogs.Instance.HideLoading();
            });
            //  });
        }

        private async void LoadGroomCommandExecution(int pagingnumber)
        {
            if (IsBusy)
                return;
            IsBusy = true;
            UserDialogs.Instance.ShowLoading();
            //Task.Run(async () =>
            //{
            await apiService.GetGroomList(pagingnumber, () =>
            {
                UserDialogs.Instance.HideLoading();
                if (GroomListResponse == null || GroomList?.Count == 0)
                {
                    GroomListResponse = apiService.GroomListResponse;
                    GroomList = new ObservableCollection<MatrimonialMember>(apiService.GroomListResponse.GroomList);
                }
                else
                {
                    try
                    {
                        var newGrooms = apiService.GroomListResponse.GroomList.Skip(GroomList.Count).ToList();
                        foreach (var i in newGrooms)
                        {
                            GroomList.Add(i);
                        }
                    }
                    catch (Exception ex)
                    {

                        IsBusy = false;
                    }
                    //GroomList = new ObservableCollection<MatrimonialMember>(apiService.GroomListResponse.GroomList);
                }
                //BridalListResponse = apiService.BridalListResponse;

                IsBusy = false;
                // GroomListResponse = apiService.GroomListResponse;
            }, (failure) =>
            {
                IsBusy = false;
                UserDialogs.Instance.HideLoading();
            });
            //});
        }

        private void ViewAllBridalCommandExecution(int pagingnumber)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.BridalListView(pagingnumber), true));
            //Navigation.PushAsync(new Views.Matrimonial.BridalListView(pagingnumber), true);
        }
        private void ViewAllGroomCommandExecution(int pagingnumber)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.GroomListView(pagingnumber), true));//Matrimonial Version 1.0 
            //Navigation.PushAsync(new Views.Matrimonial.GroomListView(pagingnumber), true);//Matrimonial Version 2.0 
        }
        private void ViewBridalDetailCommandExecution(int memberid)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.BridalDetailView(memberid), true));//Matrimonial Version 1.0 
            //Navigation.PushAsync(new Views.Matrimonial.BridalDetailView(memberid), true);//Matrimonial Version 2.0 
        }
        private void ViewGroomDetailCommandExecution(int memberid)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.GroomDetailView(memberid), true));//Matrimonial Version 1.0 
            //Navigation.PushAsync(new Views.Matrimonial.GroomDetailView(memberid), true);//Matrimonial Version 2.0 
        }

        private void DashboardResponseCommandExecution()
        {
            UserDialogs.Instance.ShowLoading();
            Task.Run(async () =>
            {
                try
                {
                    var shortlistmember = App.DatabaseService.GetAllMembers()?.Select(x => x.MemberId)?.ToList();
                    await apiService.DashboardDataList(shortlistmember, () =>
                    {
                        UserDialogs.Instance.HideLoading();
                        DashboardResponse = apiService.DhashboardResponse;

                    }, (failure) =>
                    {
                        UserDialogs.Instance.HideLoading();
                    });
                }
                catch (Exception ex)
                {

                }
            });
        }

        private void SearchCommandExecution(string searchtext)
        {
            UserDialogs.Instance.ShowLoading();
            Task.Run(async () =>
            {
                await apiService.SearchDataList(searchtext, () =>
                {
                    try
                    {
                        UserDialogs.Instance.HideLoading();
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            var detailPage = ((MasterDetailPage)App.Current.MainPage).Detail.Navigation;

                            if (detailPage.NavigationStack[^1] is Views.Matrimonial.BridalListView)
                            {
                                BridalListResponse = new BridalListResponse
                                {
                                    BridalList = new List<MatrimonialMember>(apiService.SearchResponse.SearchList),
                                    success = true
                                };
                            }
                            else if (detailPage.NavigationStack[^1] is Views.Matrimonial.GroomListView)
                            {
                                GroomListResponse = new GroomListResponse
                                {
                                    GroomList = new List<MatrimonialMember>(apiService.SearchResponse.SearchList),
                                    success = true
                                };
                            }
                            else if (detailPage.NavigationStack[^1] is Views.Matrimonial.DashboardView)
                            {
                                if (apiService.SearchResponse.SearchList[0].gender.ToLower() == "male")
                                {
                                    Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.GroomDetailView(apiService.SearchResponse.SearchList[0].memberid), true));//Matrimonial Version 1.0 
                                    //Navigation.PushAsync(new Views.Matrimonial.GroomDetailView(apiService.SearchResponse.SearchList[0].memberid), true);//Matrimonial Version 2.0 
                                }
                                else
                                {
                                    Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.BridalDetailView(apiService.SearchResponse.SearchList[0].memberid), true));//Matrimonial Version 1.0 
                                    //Navigation.PushAsync(new Views.Matrimonial.BridalDetailView(apiService.SearchResponse.SearchList[0].memberid), true);//Matrimonial Version 2.0 
                                }
                            }
                        });
                    }
                    catch (Exception ex)
                    {
                        UserDialogs.Instance.HideLoading();
                    }
                }, (failure) =>
                {
                    UserDialogs.Instance.HideLoading();
                });
            });
        }
        private void DetailCommandExecution(int memberid)
        {
            UserDialogs.Instance.ShowLoading();
            Task.Run(async () =>
            {
                await apiService.GetMemeberDetails(memberid, () =>
                {
                    UserDialogs.Instance.HideLoading();
                    MemberId = apiService.MemberDetailResponse.matrimonialMember.memberid;
                    if (apiService.MemberDetailResponse.matrimonialMemberImageList != null
                        && apiService.MemberDetailResponse.matrimonialMemberImageList.Count == 0)
                    {
                        apiService.MemberDetailResponse.matrimonialMemberImageList.Add(new MatrimonialMemberImage
                        {
                            imagename = ""
                        });
                    }
                    if (apiService.MemberDetailResponse.matrimonialContactList != null
                        && apiService.MemberDetailResponse.matrimonialContactList.Count == 0)
                    {
                        apiService.MemberDetailResponse.matrimonialContactList.Add(new MatrimonialContact
                        {
                            name = "",
                            mobile = "",
                            relation = "",
                            address1 = "",
                            address2 = "",
                            city = "",
                            state = "",
                            district = ""
                        });
                    }
                    MemberDetailResponse = apiService.MemberDetailResponse;

                }, (failure) =>
                {
                    UserDialogs.Instance.HideLoading();
                });
            });
        }


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

        private void CameraCommandExecution()
        {
            var actionsheetconfig = new ActionSheetConfig();
            actionsheetconfig.UseBottomSheet = true;
            var opt1 = new ActionSheetOption("Take Photo");
            var opt2 = new ActionSheetOption("Photo from gallary");
            actionsheetconfig.Options.Add(opt1);
            actionsheetconfig.Options.Add(opt2);
            var action = UserDialogs.Instance.ActionSheet(actionsheetconfig);

            opt1.Action = delegate ()
            {
                //var cameraPermision = await Xamarin.Essentials.Permissions.CheckStatusAsync<Permissions.Camera>();
                //if (cameraPermision != PermissionStatus.Granted)
                //    cameraPermision = await Xamarin.Essentials.Permissions.RequestAsync<Permissions.Camera>(); 
                Device.BeginInvokeOnMainThread(async () =>
                {

                    await CrossMedia.Current.Initialize();

                    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                    {
                        await App.Current.MainPage.DisplayAlert("No Camera", ":( No camera available.", "OK");
                        return;
                    }
                    try
                    {
                        var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                        {
                            AllowCropping = true,
                            Directory = "JainMatrimony",
                            Name = $"IMG_{DateTime.Now.Ticks}.jpg",
                            PhotoSize = PhotoSize.Custom,
                            CustomPhotoSize = 90, //Resize to 90% of original,
                            CompressionQuality = 92,
                        });

                        if (file == null)
                            return;

                        var st = Convert.ToBase64String(File.ReadAllBytes(file.AlbumPath));

                        Photo = ImageSource.FromStream(() =>
                        {
                            var stream = file.GetStream();
                            return stream;
                        });
                    }
                    catch (Exception ex1)
                    {

                    }
                });
            };

            opt2.Action = delegate ()
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await CrossMedia.Current.Initialize();

                    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                    {
                        await App.Current.MainPage.DisplayAlert("No Camera", ":( No camera available.", "OK");
                        return;
                    }

                    var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                    {
                        PhotoSize = PhotoSize.Custom,
                        CustomPhotoSize = 90, //Resize to 90% of original,
                        CompressionQuality = 92,
                    });

                    if (file == null)
                        return;



                    Photo = ImageSource.FromStream(() =>
                    {
                        var stream = file.GetStream();
                        return stream;
                    });
                });
            };
        }
        private void SaveCommandExecution()
        {
            if (IsValidate())
            {
                UserDialogs.Instance.ShowLoading();
                Task.Run(async () =>
                {
                    if (SelectedHeightInft == null)
                        SelectedHeightInft = "0";
                    if (SelectedHeightInInch == null)
                        SelectedHeightInInch = "0";
                    if (Brothers == null)
                        Brothers = "0";
                    if (Sisters == null)
                        Sisters = "0";
                    if (MonthlyIncome == null)
                        MonthlyIncome = "0";
                    try
                    {
                        AddMemberRequest addMemberRequest = new AddMemberRequest
                        {
                            firstname = FirstName,
                            middlename = MiddleName,
                            lastname = LastName,
                            email = EMail,
                            mobile = MobileNo,
                            address = Address,
                            birthplace = BirthPlace,
                            birthtime = BirthTime.ToString(),
                            bloodgroup = BloodGroup,
                            brothers = int.Parse(Brothers),
                            sisters = int.Parse(Sisters),
                            city = City,
                            state = State,
                            zip = ZipCode,
                            education = SelectEducation,
                            familyoccupation = SelectOccupation,
                            fathername = FatherName,
                            mangali = IsManglik ? "Yes" : "No",
                            milan = IsMilan ? "Yes" : "No",
                            wans = Wans.id.ToString(),
                            gender = IsMale ? "Male" : "Female",
                            gotra = Gotra.wansh,
                            income = Convert.ToDecimal(MonthlyIncome),
                            mobile2 = ContactNo,
                            occupation = SelectOccupation,
                            religion = SelectedReligion,
                            subreligion = SubSelectedReligion,
                            dob = BirthDate.ToString("yyyy/MM/dd")
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
                            addMemberRequest.imageBase64String = Convert.ToBase64String(byteArray);
                        }
                        if (!string.IsNullOrEmpty(SelectedHeightInft) && !string.IsNullOrEmpty(SelectedHeightInInch))
                            addMemberRequest.height = Convert.ToString(((int.Parse(SelectedHeightInft.Replace("ft", "")) * 30) + (int.Parse(SelectedHeightInInch.Split(" ")[0]) * 2.54f)));
                        await apiService.AddMember(addMemberRequest, () =>
                        {
                            UserDialogs.Instance.HideLoading();
                            AddMemberResponse = apiService.AddMemberResponse;
                            //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopAsync(true));
                            if (IsMale)
                                App.AppSetup.MatrimonialViewModel.ViewBridalDetailCommand.Execute(AddMemberResponse.memberid);
                            else
                                App.AppSetup.MatrimonialViewModel.ViewGroomDetailCommand.Execute(AddMemberResponse.memberid);
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
        private bool IsValidate()
        {
            //return true;
            bool validate = false;
            if (string.IsNullOrEmpty(FirstName))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("First name field is empty.");
                return false;
            }
            //else if (string.IsNullOrEmpty(LastName))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Last name field is empty.");
            //    return false;
            //}
            else if (string.IsNullOrEmpty(MobileNo))
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
            else if (string.IsNullOrEmpty(City))
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
            FirstName = "";
            MiddleName = "";
            LastName = "";
            EMail = "";
            MobileNo = "";
            Address = "";
            BirthPlace = "";
            BloodGroup = "";
            Brothers = "0";
            Sisters = "0";
            City = "";
            State = "";
            ZipCode = "";
            SelectEducation = "";
            SelectOccupation = "";
            FatherName = "";
            //Gotra = "";
            MonthlyIncome = "";
            ContactNo = "";
            SelectOccupation = "";
            SelectedReligion = "";
            SubSelectedReligion = "";
        }
        #endregion
    }
}

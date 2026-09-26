using Acr.UserDialogs;
using Matrimony.Models;
using Matrimony.Models.Response;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Matrimony.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public ProfileViewModel()
        {
            wanshList = new ObservableCollection<Wansh>();
            ReSet();
        }
        #region Set Property

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
        private string gotra;
        public string Gotra
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

        #region Command
        public Command CameraCommand => new Command(CameraCommandExecution);

        public Command SaveCommand => new Command(SaveCommandExecution);
        public Command LoadWanshCommand { get { return new Command(LoadWanshCommandExecution); } }
        #endregion

        #region Command Execution 

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
                    catch(Exception ex1)
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
                            email= EMail,
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
                            gotra = Gotra,
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
                        if(!string.IsNullOrEmpty(SelectedHeightInft) && !string.IsNullOrEmpty(SelectedHeightInInch))
                            addMemberRequest.height = Convert.ToString(((int.Parse(SelectedHeightInft.Replace("ft", "")) * 30) + (int.Parse(SelectedHeightInInch.Split(" ")[0]) * 2.54f)));
                        await apiService.AddMember(addMemberRequest, () =>
                         {
                             UserDialogs.Instance.HideLoading();
                             AddMemberResponse = apiService.AddMemberResponse;
                             //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopAsync(true));
                             if(IsMale)
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
                    WanshList = new System.Collections.ObjectModel.ObservableCollection<Wansh>(apiService.WanshResponse.WanshList);
                }
                IsBusy = false;
            }, (failure) =>
            {
                IsBusy = false;
                //UserDialogs.Instance.HideLoading();
            });
            //});
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
            Sisters="0";
            City = "";
            State = "";
            ZipCode = "";
            SelectEducation = "";
            SelectOccupation = "";
            FatherName = "";
            Gotra = "";
            MonthlyIncome = "";
            ContactNo = "";
            SelectOccupation = "";
            SelectedReligion = "";
            SubSelectedReligion = "";
        }
        #endregion
    }
}

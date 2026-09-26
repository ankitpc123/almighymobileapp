using Acr.UserDialogs;
using Matrimony.Models;
using Matrimony.Models.Request;
using Matrimony.Models.Response;
using Matrimony.Views;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Matrimony.ViewModels
{
    public class AppMemberViewModel : BaseViewModel
    {

        #region Set Property
        public string AppLogoImage
        {
            get
            {
                //if (image == "" || image == null)
                return "appicons";//gender == "Female" ? "girl" : "boy";// "welcome.jpg";// "MarriageIcon.jpg";
                //else
                //    return $"{apiService.ImageHostName}{memberid}/{image}";// string.Concat(App.GetImageGalleryFolderURL, memberid, "/", image);
            }
        }

        private string devicetoken;
        public string DeviceToken
        {
            get { return devicetoken; }
            set
            {
                devicetoken = value;
                RaisePropertyChanged(() => DeviceToken);
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

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        private string confirmpassword;
        public string ConfirmPassword
        {
            get { return confirmpassword; }
            set
            {
                confirmpassword = value;
                RaisePropertyChanged(() => ConfirmPassword);
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

        private string profession;
        public string Profession
        {
            get { return profession; }
            set
            {
                profession = value;
                RaisePropertyChanged(() => Profession);
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
        //show/hide password
        //var vPasswordEntry = new Entry() { IsPassword = true };
        //vPasswordEntry.Effects.Add(new FontEffect());  

        private AddAppMemberResponse addAppMemberResponse;
        public AddAppMemberResponse AddAppMemberResponse
        {
            get { return addAppMemberResponse; }
            set
            {
                addAppMemberResponse = value;
                RaisePropertyChanged(() => AddAppMemberResponse);
            }
        }
        #endregion

        #region Command
        public Command CameraCommand => new Command(CameraCommandExecution);
        public Command SaveCommand => new Command(SaveCommandExecution);

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
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await CrossMedia.Current.Initialize();

                    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                    {
                        await App.Current.MainPage.DisplayAlert("No Camera", ":( No camera available.", "OK");
                        return;
                    }

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
                    try
                    {
                        AppMemberRequest addAppMemberRequest = new AppMemberRequest
                        {
                            firstname = FirstName,
                            //middlename = MiddleName,
                            //lastname = LastName,
                            mobile = MobileNo,
                            //email=EMail,
                            //address = Address,
                            //city = City,
                            //state = State,
                            //zip = ZipCode,
                            //profession= Profession,
                            //gender = IsMale ? "Male" : "Female",
                            devicetoken= DeviceToken
                        };
                        //if (Photo is StreamImageSource)
                        //{
                        //    StreamImageSource streamImageSource = (StreamImageSource)Photo;
                        //    System.Threading.CancellationToken cancellationToken = System.Threading.CancellationToken.None;
                        //    Task<Stream> task = streamImageSource.Stream(cancellationToken);
                        //    Stream stream = task.Result; byte[] byteArray;
                        //    using (MemoryStream ms = new MemoryStream())
                        //    {
                        //        stream.CopyTo(ms);
                        //        byteArray = ms.ToArray();
                        //    }
                        //    addAppMemberRequest.imageBase64String = Convert.ToBase64String(byteArray);
                        //}
                        await apiService.AddAppMember(addAppMemberRequest, () =>
                        {
                            UserDialogs.Instance.HideLoading();
                            AddAppMemberResponse = apiService.AddAppMemberResponse;
                            //App.DatabaseService.SaveOrUpdateAppMember(new AppMember { 
                            //    appMemberId = AddAppMemberResponse.memberid,
                            //    firstname = FirstName,
                            //    middlename = MiddleName,
                            //    lastname = LastName,
                            //    mobile = MobileNo,
                            //    email = EMail,
                            //    address = Address,
                            //    city = City,
                            //    state = State,
                            //    zip = ZipCode,
                            //    profession = Profession,
                            //    imagename = AddAppMemberResponse.appMember.imagename,
                            //    imagepath = AddAppMemberResponse.appMember.imagepath,
                            //    gender = IsMale ? "Male" : "Female"
                            //});
                            //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopAsync(true));
                            //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.BridalDetailView(memberid), true));
                            //App.Current.MainPage = new MainPage();
                            Xamarin.Essentials.Preferences.Set("IsLogin", true);
                            Xamarin.Essentials.Preferences.Set("LoggedInAppMemberId", AddAppMemberResponse.memberid);
                            Xamarin.Essentials.Preferences.Set("AppMemberImgePath", AddAppMemberResponse.appMember.imagepath);
                            Xamarin.Essentials.Preferences.Set("MobileNo", MobileNo);

                            Device.BeginInvokeOnMainThread(() =>
                            {
                                //Xamarin.Essentials.Preferences.Set("IsStarted", true);
                                Xamarin.Essentials.Preferences.Set("IsLogin", true);
                                //App.Current.MainPage = new Views.Login.Login();
                                App.Current.MainPage = new MainPage();
                            });
                        }, (failure) =>
                        {
                            UserDialogs.Instance.HideLoading();
                            Acr.UserDialogs.UserDialogs.Instance.Alert(apiService.AddAppMemberResponse.message);
                        });
                        //App.Current.MainPage = new MainPage();
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
            bool validate = false;
            if (string.IsNullOrEmpty(FirstName))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("कृपया नाम भरें");//First name field is empty.
                return false;
            }
            //else if (string.IsNullOrEmpty(LastName))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Last name field is empty.");
            //    return false;
            //}
            else if (string.IsNullOrEmpty(MobileNo))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("कृपया मोबाइल नम्बर भरें");//Mobile number field is empty.
                return false;
            }
            //else if (string.IsNullOrEmpty(EMail))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Email field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(Address))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("Address field is empty.");
            //    return false;
            //}
            //else if (string.IsNullOrEmpty(City))
            //{
            //    Acr.UserDialogs.UserDialogs.Instance.Alert("City field is empty.");
            //    return false;
            //}
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
            else
            {
                return true;
            }

            return validate;
        }
        #endregion
    }
}

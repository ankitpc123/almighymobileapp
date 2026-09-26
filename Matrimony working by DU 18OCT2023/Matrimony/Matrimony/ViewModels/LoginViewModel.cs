using Acr.UserDialogs;
using Matrimony.Models;
using Matrimony.Models.Request;
using Matrimony.Models.Response;
using Matrimony.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Matrimony.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region "Property"
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

        private string loginId;
        public string LoginId
        {
            get { return loginId; }
            set
            {
                loginId = value;
                RaisePropertyChanged(() => LoginId);
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


        private AddAppMemberResponse logniAppMemberResponse;
        public AddAppMemberResponse LoginAppMemberResponse
        {
            get { return logniAppMemberResponse; }
            set
            {
                logniAppMemberResponse = value;
                RaisePropertyChanged(() => LoginAppMemberResponse);
            }
        }

        #endregion

        #region Set Commands
        public Command<int> RegistrationViewCommand { get { return new Command<int>(RegistrationViewCommandExecution); } }
        public Command<int> ForgotPasswordViewCommand { get { return new Command<int>(ForgotPasswordViewCommandExecution); } }
        public Command<int> ForgotPasswordCommand { get { return new Command<int>(ForgotPasswordCommandExecution); } }

        public Command LoginCommand => new Command(LoginCommandExecution);
        #endregion

        #region Command Execution
        private void RegistrationViewCommandExecution(int pagingnumber)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Login.Register(), true));
        }
        private void ForgotPasswordViewCommandExecution(int pagingnumber)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Login.ForgotPassword(), true));
        }
        //ForgotPasswordCommand
        private void ForgotPasswordCommandExecution(int pagingnumber)
        {
            Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Login.ForgotPassword(), true));
        }

        private void LoginCommandExecution()
        {
            if (IsLoginValidate())
            {
                UserDialogs.Instance.ShowLoading();
                Task.Run(async () =>
                {
                    try
                    {
                        LoginRequest loginAppMemberRequest = new LoginRequest
                        {
                            loginId = LoginId,
                            password = Password
                        };
                        await apiService.LoginAppMember(loginAppMemberRequest, () =>
                        {
                            UserDialogs.Instance.HideLoading();
                            AddAppMemberResponse = apiService.AddAppMemberResponse;
                            //AppMember member = App.DatabaseService.GetAppMemberById(AddAppMemberResponse.memberid);
                            //if (member == null)
                            //{
                            //    member = AddAppMemberResponse.appMember;
                            //}

                            App.DatabaseService.SaveOrUpdateAppMember(new AppMember
                            {
                                appMemberId = AddAppMemberResponse.appMember.appMemberId,
                                devicetoken = AddAppMemberResponse.appMember.devicetoken,
                                firstname = AddAppMemberResponse.appMember.firstname,
                                middlename = AddAppMemberResponse.appMember.middlename,
                                lastname = AddAppMemberResponse.appMember.lastname,
                                mobile = AddAppMemberResponse.appMember.mobile,
                                email = AddAppMemberResponse.appMember.email,
                                address = AddAppMemberResponse.appMember.address,
                                city = AddAppMemberResponse.appMember.city,
                                state = AddAppMemberResponse.appMember.state,
                                zip = AddAppMemberResponse.appMember.zip,
                                profession = AddAppMemberResponse.appMember.profession,
                                imagename = AddAppMemberResponse.appMember.imagename,
                                imagepath = AddAppMemberResponse.appMember.imagepath,
                                gender = AddAppMemberResponse.appMember.gender
                            });

                            Xamarin.Essentials.Preferences.Set("IsLogin", true);
                            Xamarin.Essentials.Preferences.Set("LoggedInAppMemberId", AddAppMemberResponse.memberid);
                            Xamarin.Essentials.Preferences.Set("AppMemberImgePath", AddAppMemberResponse.appMember.imagepath);
                            //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopAsync(true));
                            //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.BridalDetailView(memberid), true));
                            //App.Current.MainPage = new MainPage();
                            //App.Current.MainPage = new Views.IntroView();
                            Device.BeginInvokeOnMainThread(() =>
                            {
                                Xamarin.Essentials.Preferences.Set("IsStarted", true);
                                App.Current.MainPage = new MainPage();
                            });
                            //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.BridalListView(10), true));
                        }, (failure) =>
                        {
                            UserDialogs.Instance.HideLoading();
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

        private bool IsLoginValidate()
        {
            bool validate = false;
            if (string.IsNullOrEmpty(LoginId))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("LoginId field is empty.");
                return false;
            }
            else if (string.IsNullOrEmpty(Password))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Password field is empty.");
                return false;
            }
            else
            {
                return true;
            }

            return validate;
        }

        #endregion

    }
}

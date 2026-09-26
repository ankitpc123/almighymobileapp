using Acr.UserDialogs; 
using Matrimony.Models.Request;
using Matrimony.Models.Response;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Matrimony.ViewModels
{
    public class AdvanceSearchViewModel : BaseViewModel
    {
        public AdvanceSearchViewModel()
        { }

        #region Set Property

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
        string minheight;
        public string MinHeight
        {
            get { return minheight; }
            set
            {
                minheight = value;
                RaisePropertyChanged(() => MinHeight);
            }
        }
        string maxheight;
        public string MaxHeight
        {
            get { return maxheight; }
            set
            {
                maxheight = value;
                RaisePropertyChanged(() => MaxHeight);
            }
        }

        string maritalstatus;
        public string MaritalStatus
        {
            get { return maritalstatus; }
            set
            {
                maritalstatus = value;
                RaisePropertyChanged(() => MaritalStatus);
            }
        }
        string religion;
        public string Religion
        {
            get { return religion; }
            set
            {
                religion = value;
                RaisePropertyChanged(() => Religion);
            }
        }

        string mothertoungue;
        public string MotherToungue
        {
            get { return mothertoungue; }
            set
            {
                mothertoungue = value;
                RaisePropertyChanged(() => MotherToungue);
            }
        }
        string minincome;
        public string MinIncome
        {
            get { return minincome; }
            set
            {
                minincome = value;
                RaisePropertyChanged(() => MinIncome);
            }
        }
        string maxincome;
        public string MaxIncome
        {
            get { return maxincome; }
            set
            {
                maxincome = value;
                RaisePropertyChanged(() => MaxIncome);
            }
        }

        private AdvanceSearchResponse advancesearchResponse;

        public AdvanceSearchResponse AdvanceSearchResponse
        {
            get { return advancesearchResponse; }
            set { advancesearchResponse = value; RaisePropertyChanged(() => AdvanceSearchResponse); }
        }
        private Color bridetextColor= Color.FromHex("#FFFFFF");

        public Color BRIDETextColor
        {
            get { return bridetextColor; }
            set { bridetextColor = value; RaisePropertyChanged(() =>BRIDETextColor); }
        }

        #endregion



        public Command SearchCommand => new Command(SearchCommandExecution);

        #region Command Execution 
        private async void SearchCommandExecution()
        {     
           // if (IsValidate())
            {
                //Task.Run(async () =>
                //{
                    try 
                    {
                        AdvanceSearchRequest advanceSearchRequest = new AdvanceSearchRequest
                        {
                            //maritalstatus = MaritalStatus == null ? "" : MaritalStatus,
                            minage = MinAge == null ? "" : $"{DateTime.Now.Year - Convert.ToInt32(MinAge.Remove(MinAge.Length - 5).TrimEnd())}-{DateTime.Now.Month}-{DateTime.Now.Day}",
                            minheight = MinHeight == null ? "" : Convert.ToString(Math.Round( int.Parse(MinHeight.Replace("ft", "").Replace("'", "").Trim().Split(' ')[0]) * 30.48)) ,
                            //minincome = MinIncome == null ? "" : MinIncome,
                            maxage = MaxAge == null ? "" : $"{DateTime.Now.Year - Convert.ToInt32(MaxAge.Remove(MaxAge.Length - 5).TrimEnd())}-{DateTime.Now.Month}-{DateTime.Now.Day}",
                            maxheight = MaxHeight == null ? "" : Convert.ToString(Math.Round(int.Parse(MaxHeight.Replace("ft", "").Replace("'", "").Trim().Split(' ')[0]) * 30.48)),
                            //maxincome = MaxIncome == null ? "" : MaxIncome == null ? "" : MaxIncome,
                            //mothertoungh = MotherToungue == null ? "" : MotherToungue,
                            //religion = Religion == null ? "" : Religion,
                            gender = BRIDETextColor == Color.FromHex("#FFFFFF") ? "female" : "male",
                        };
                    UserDialogs.Instance.ShowLoading();

                    await apiService.GetAdvanceSearchList(advanceSearchRequest, () =>
                       {
                           UserDialogs.Instance.HideLoading();
                           AdvanceSearchResponse = apiService.AdvanceSearchResponse;
                           Device.BeginInvokeOnMainThread(async () =>
                           {
                               await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PopAsync(true);
                               if (advanceSearchRequest.gender?.ToLower() == "female")
                               {
                                   await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.BridalListView(AdvanceSearchResponse), true);
                               }
                               else
                               {
                                   await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Matrimonial.GroomListView(AdvanceSearchResponse), true);
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
                //});
            }
        }

        private bool IsValidate()
        {
            bool validate = false;
            if (string.IsNullOrEmpty(MinAge))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Select MinAge field.");
                return false;
            }
            else if (string.IsNullOrEmpty(MaxAge))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Select MaxAge field .");
                return false;
            }
            else if (string.IsNullOrEmpty(MinHeight))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Select MinHeight field.");
                return false;
            }
            else if (string.IsNullOrEmpty(MaxHeight))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Select MaxHeight field.");
                return false;
            }

            else if (string.IsNullOrEmpty(MaritalStatus))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Select Marital Status  field.");
                return false;
            }
            else if (string.IsNullOrEmpty(MotherToungue))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Select Mother Toungue field.");
                return false;
            }

            else if (string.IsNullOrEmpty(MotherToungue))
            {
                MotherToungue = "Hindi";
                //Acr.UserDialogs.UserDialogs.Instance.Alert("Select MotherToungue field.");
                //return false;
            }
            else if (string.IsNullOrEmpty(MaxIncome))
            {
                //MinIncome = 
                //Acr.UserDialogs.UserDialogs.Instance.Alert("Select MaxIncome field.");
                //return false;
            }
            else
            {
                return true;
            }

            return validate =true;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Matrimony.Helper;
using Matrimony.Models;
using Matrimony.Models.Response;
using Matrimony.Views;
using Matrimony.Views.Matrimonial;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Matrimony.ViewModels
{
    public class MapViewModel : BaseViewModel
    {
        INavigation navigation;
        public CustomMap map { get; set; }
        public MapViewModel()
        {
            //GetAroundPeople();
        }


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
                await apiService.GetNearByList("5", "20", "70", () =>
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
                            gender = "Male"

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

    public class CustomPin : Pin
    {
        public int MemberID { get; set; }
        public string gender { get; set; }
    }

    public class CustomMap : Map
    {
        public List<CustomPin> CustomPins { get; set; }
    }
}

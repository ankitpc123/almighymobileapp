using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Matrimony.Models;
using Matrimony.Services;
using Matrimony.Managers;
using Matrimony.ApiProvider;
using GalaSoft.MvvmLight;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Acr.UserDialogs;

namespace Matrimony.ViewModels
{
    public class BaseViewModel :ViewModelBase//, INotifyPropertyChanged
    {
        public   IApiService apiService { get; set; }
        public   IApiProvider apiProvider { get; set; }
        public BaseViewModel()
        {
            apiService = SimpleIoc.Default.GetInstance<IApiService>();//, ApiService>(); SimpleIoc.Default.;
            apiProvider = SimpleIoc.Default.GetInstance<IApiProvider>();
            ToastConfig =  new ToastConfig("") { BackgroundColor = (Color)App.Current.Resources["NavigationPrimary"], MessageTextColor = Color.White, Position = ToastPosition.Top, Duration = TimeSpan.FromSeconds(3) };
        }
        //public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

      public ToastConfig ToastConfig { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public string AppMemberImageUrl
        {
            get
            {
                var imagepath = Xamarin.Essentials.Preferences.Get("AppMemberImgePath", "");

                if (!string.IsNullOrEmpty(imagepath))
                {
                    return imagepath;
                }
                else
                    return "boy";
                //return $"http://www.atyourservicejain.com/Images/gallery/AppMember/1/1.jpg";
            }
        }
        public string ImageUrl
        {
            get
            {
                var imagepath = Xamarin.Essentials.Preferences.Get("AppMemberImgePath", "");

                if (!string.IsNullOrEmpty(imagepath))
                {
                    return imagepath;
                }
                else
                    return "boy";
                //return $"http://www.atyourservicejain.com/Images/gallery/AppMember/1/1.jpg";
            }
        }
        private bool isPresented = false;
        public bool IsPresented
        {
            get
            {
                return isPresented;
            }
            set
            {
                isPresented = value;
                RaisePropertyChanged(() => IsPresented);
            }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

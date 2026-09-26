using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Matrimony.ApiProvider;
using Matrimony.Managers;
using Matrimony.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Matrimony
{
   public class AppSetup
    {
        public AppSetup()
        {
            SimpleIoc.Default.Register<Matrimony.ApiProvider.IApiProvider, Matrimony.ApiProvider.ApiProvider>();
            SimpleIoc.Default.Register<IApiService, ApiService>();

            SimpleIoc.Default.Register<BaseViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<ProfileViewModel>();
            SimpleIoc.Default.Register<AdvanceSearchViewModel>();
            SimpleIoc.Default.Register<AppMemberViewModel>();
            SimpleIoc.Default.Register<MembersViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<MatrimonialViewModel>();
            SimpleIoc.Default.Register<AstrologyViewModel>();
            SimpleIoc.Default.Register<MapViewModel>();
        }
        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public BaseViewModel BaseViewModel => ServiceLocator.Current.GetInstance<BaseViewModel>();
        public ProfileViewModel ProfileViewModel => ServiceLocator.Current.GetInstance<ProfileViewModel>();
        public AdvanceSearchViewModel AdvanceSearchViewModel => ServiceLocator.Current.GetInstance<AdvanceSearchViewModel>();
        public AppMemberViewModel AppMemberViewModel => ServiceLocator.Current.GetInstance<AppMemberViewModel>();
        public LoginViewModel LoginViewModel => ServiceLocator.Current.GetInstance<LoginViewModel>();
        public MembersViewModel MembersViewModel => ServiceLocator.Current.GetInstance<MembersViewModel>();
        public MatrimonialViewModel MatrimonialViewModel => ServiceLocator.Current.GetInstance<MatrimonialViewModel>();
        public AstrologyViewModel AstrologyViewModel => ServiceLocator.Current.GetInstance<AstrologyViewModel>();
        public MapViewModel MapViewModel => ServiceLocator.Current.GetInstance<MapViewModel>();
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}

using Xamarin.Forms;
using Matrimony.Services;
using Matrimony.Views;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Matrimony.Models;
using Matrimony.Helper;
using System.Threading.Tasks;
using System;
using Xamarin.Essentials;


namespace Matrimony
{
    public partial class App : Application
    {
        public static DatabaseService DatabaseService { get; set; }
        private static AppSetup appSetup;
        public static AppSetup AppSetup => appSetup;
        public static int MatrimonialMemberId = 0;
        public static int MemberId = 0;
        public static bool IsMemberMale = false;
        public static string AppHostUrl
        {
            get
            {
                return "https://atyourservicejain.in/";
            }
        }
        public static string GetImageFolderURL
        {
            get
            {
                //return "http://www.atyourservicejain.com/images/";
                return "http://atyourservicejain.in/images/";
            }
        }
        public static string GetImageGalleryFolderURL
        {
            get
            {
                //return "http://www.atyourservicejain.com/images/gallery/";
                return "http://atyourservicejain.in/images/gallery/";
            }
        }

        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "RadioButton_Experimental", "Shapes_Experimental", "CollectionView_Experimental" });

            ServiceLocator.SetLocatorProvider(() => (IServiceLocator) SimpleIoc.Default);
            SimpleIoc.Default.Register<AppSetup>();
            appSetup = SimpleIoc.Default.GetInstance<AppSetup>();


            // DependencyService.Register<MockDataStore>(); 
            var isStarted = Xamarin.Essentials.Preferences.Get("IsStarted", false);
            var IsLogin = Xamarin.Essentials.Preferences.Get("IsLogin", false);
            var imagepath = Xamarin.Essentials.Preferences.Get("AppMemberImgePath", "");
            
            DatabaseService = new DatabaseService();
            //1.
            //IsLogin = false;
            if (!IsLogin)
            {
                //MainPage = new Views.Login.Login();
                MainPage = new Views.Login.Register();
            }
            else if (isStarted)
                MainPage = new MainPage();
            else
                MainPage = new Views.IntroView();//Matrimonial Version 1.0 

            //2.
            //MainPage = new Views.PJKS(10);//NEW page

            //3.
            //Only MNEU TEST to open page via menu
            //MainPage =new NavigationPage(new MainPage());
            Device.StartTimer(new TimeSpan(0, 0, 5), () =>
            {
                // do something every 5 seconds
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await GetCurrentLocation();
                    // interact with UI elements
                });
                return true; // runs again, or false to stop
            });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private static async Task GetCurrentLocation()
        {
            try
            {
                GeolocationRequest request = new Xamarin.Essentials.GeolocationRequest(Xamarin.Essentials.GeolocationAccuracy.Medium, new TimeSpan(30));
                Location location = await Xamarin.Essentials.Geolocation.GetLocationAsync(request);
                if (location != null)
                {
                    Constant.currentLat = location.Latitude;
                    Constant.currentLng = location.Longitude;
                    Console.WriteLine(Constant.currentLat + "____" + Constant.currentLng);
                }

            }
            catch (Exception)
            {

            }
        }
    }
}

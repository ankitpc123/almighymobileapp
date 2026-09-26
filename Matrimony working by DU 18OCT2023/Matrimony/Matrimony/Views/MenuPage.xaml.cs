using Matrimony.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MainViewModel;
            lblVersion.Text = $"Ver {Xamarin.Essentials.AppInfo.VersionString}";
            ListViewMenu.SelectedItem = null;
            menuItems = new List<HomeMenuItem>
            {      
                ///new HomeMenuItem {IconSource="resource://Matrimony.Resources.home.svg", TargetType = typeof(AboutPage), Id = MenuItemType.About, Title="About" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.family.svg", Id = MenuItemType.About, Title="My Family" },
                new HomeMenuItem {IconSource="resource://Matrimony.Resources.pjks.svg", TargetType = typeof(PJKS), Id = MenuItemType.PJKS, Title="पारसजनकल्याण संस्थान" },
                new HomeMenuItem {IconSource="resource://Matrimony.Resources.pjks.svg", TargetType = typeof(PJKS), Id = MenuItemType.Mahasabha, Title="महासभा" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.pujari.svg", Id = MenuItemType.About, Title="Pujari" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.tolet.svg", Id = MenuItemType.About, Title="To-let" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.salespurchase.svg", Id = MenuItemType.About, Title="Sales/Purchase" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.library.svg", Id = MenuItemType.LibraryDashboard, Title="Library" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.panchang.svg", Id = MenuItemType.Panchang, Title="Panchang" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.astrology.svg", Id = MenuItemType.About, Title="Astrology" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.findmycoach.svg", Id = MenuItemType.About, Title="Find my coach" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.directories.svg", Id = MenuItemType.About, Title="Directories" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.feedback.svg", Id = MenuItemType.About, Title="Feedback" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.aboutus.svg", Id = MenuItemType.About, Title="About us" },
                new HomeMenuItem {IconSource="resource://Matrimony.Resources.contectus.svg", Id = MenuItemType.ContactUs, Title="संपर्क करें" },
                new HomeMenuItem {IconSource="resource://Matrimony.Resources.family.svg", Id = MenuItemType.ContactUs, Title="वैवाहिक विवरण देखें" },
                //new HomeMenuItem {IconSource="resource://Matrimony.Resources.logout.svg", Id = MenuItemType.About, Title="Logout" }
            };

            ListViewMenu.ItemsSource = menuItems;

            //ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                ListViewMenu.SelectedItem = null;
                    return;
                //var item = e.SelectedItem as HomeMenuItem;
                //if (item != null)
                //{
                //    new NavigationPage((Page)Activator.CreateInstance(item.GetType()));
                //    ListViewMenu.SelectedItem = null;
                //    //IsPresented = false;
                //}
            };

            ListViewMenu.ItemTapped +=async(s,e)=>
            {
                try
                {
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        App.AppSetup.MainViewModel.IsPresented = false;
                    });

                    var id = (int)((HomeMenuItem)e.Item).Id;

                    if (id == 4)
                    {
                        Device.BeginInvokeOnMainThread(async () =>
                        {
                            await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.PJKSMenu.Dashboard(10));
                           
                        });
                    }
                    else if (id == 5)
                    {
                        Device.BeginInvokeOnMainThread(async() =>
                        {
                            await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Mahasabha.Dashboard(10));
                            
                        });
                        
                    }
                    else if (id == 6)
                    {
                        Device.BeginInvokeOnMainThread(async () =>
                        {
                            //await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new ContactUs());
                            //var MobileNo = Xamarin.Essentials.Preferences.Get("MobileNo", "");
                            Chat.Open("+919893297289", "जय जिनेन्द्र,");
                        });

                    }
                    ListViewMenu.SelectedItem = null;
                    ((MasterDetailPage)App.Current.MainPage).IsPresented = false;
                    //var menu = e.Item as HomeMenuItem;
                    //await RootPage.NavigateFromMenu(id);
                    //await Navigation.PushAsync(new NavigationPage(new AboutPage()));
                    //Device.BeginInvokeOnMainThread(() =>
                    //{
                    //    App.Current.MainPage = new Views.Library.LibraryDashboard();
                    //});
                    //ListViewMenu.SelectedItem = null;
                    //App.AppSetup.MainViewModel.IsPresented = false;
                    //Navigation.PushAsync(new PJKS(10), true);

                    return;

                    Xamarin.Forms.OpenWhatsApp.Chat.Open("+919893297289", "Hi,");
                    //App.Current.MainPage = new NavigationPage(new Views.Library.LibraryDashboard());
                    //App.Current.MainPage = new NavigationPage(new Views.AboutPage());
                    //await Detail.Navigation.PushAsync(AboutPage, true);
                    //working
                    //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.AboutPage(), true));
                }
                catch (Exception ex)
                {
                    Acr.UserDialogs.UserDialogs.Instance.Toast(ex.Message);
                }
                
            };
            
        }
        void OnUserProfileTap(object sender, EventArgs e)
        {
            App.AppSetup.MainViewModel.IsPresented = false;
            Navigation.PushAsync(new AboutPage(), true);
            //App.Current.MainPage = new NavigationPage(new AboutPage());//working
        }
    }
}
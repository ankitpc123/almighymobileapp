using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.NewFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PJKSBottamToolBoxView : Frame
    {
        public PJKSBottamToolBoxView()
        {
            InitializeComponent();
        }

        public async void Vastu_Tapped(object sender, EventArgs e)
        {
            ////Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.VastuSashtra.VastuSashtra(), true));
        }

        public async void MudraVigyan_Tapped(object sender, EventArgs e)
        {
            //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Health.MarmChikitsa(), true));
            ////Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.MudraVigyan.mudravigyan(), true));

        }

        public async void SwarVigyan_Tapped(object sender, EventArgs e)
        {
            //Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Health.MarmChikitsa(), true));
            ////Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.SwarVigyan.swarvigyan(), true));

        }

        public async void JYOTISH_Tapped(object sender, EventArgs e)
        {
            ////Device.BeginInvokeOnMainThread(async () => await ((MasterDetailPage)App.Current.MainPage).Detail.Navigation.PushAsync(new Views.Astrology.AstrologyVigyan(), true));
        }
        
    }
}
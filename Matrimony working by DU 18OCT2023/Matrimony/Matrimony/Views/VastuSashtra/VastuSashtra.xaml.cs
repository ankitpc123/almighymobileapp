using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.VastuSashtra
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VastuSashtra : ContentPage
    {
        public VastuSashtra()
        {
            InitializeComponent();
            BindingContext = App.AppSetup.MatrimonialViewModel;
            coverFlow.IsPanSwipeEnabled = true;
            coverFlow.IsUserInteractionEnabled = true;
        }
    }
}
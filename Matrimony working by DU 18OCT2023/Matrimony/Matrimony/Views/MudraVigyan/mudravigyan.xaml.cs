using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.MudraVigyan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class mudravigyan : ContentPage
	{
		public mudravigyan ()
		{
            InitializeComponent();
            BindingContext = App.AppSetup.MatrimonialViewModel;
            coverFlow.IsPanSwipeEnabled = true;
            coverFlow.IsUserInteractionEnabled = true;
        }
	}
}
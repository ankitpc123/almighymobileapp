using Matrimony.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroomCell : ContentView
    {
        public GroomCell()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var context = (sender as View).BindingContext as MatrimonialMember;
            if (context != null)
            {
                App.AppSetup.MatrimonialViewModel.ViewGroomDetailCommand.Execute(context.memberid);
            }
        }
    }
}
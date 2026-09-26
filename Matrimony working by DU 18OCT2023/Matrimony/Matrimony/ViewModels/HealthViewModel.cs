using Acr.UserDialogs;
using Matrimony.Models;
using Matrimony.Models.Matrimonial;
using Matrimony.Models.Response;
using Matrimony.Views;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Matrimony.ViewModels
{
    public class HealthViewModel : BaseViewModel
    {
        public HealthViewModel()
        {
            
        }

        public string HealthURL
        {
            get
            {
                return App.AppHostUrl+"archaryatulsi.png";
            }
        }
    }
}

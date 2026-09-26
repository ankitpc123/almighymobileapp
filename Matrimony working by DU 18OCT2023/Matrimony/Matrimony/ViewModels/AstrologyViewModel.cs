using Matrimony.Models;
using Matrimony.Models.Matrimonial;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Matrimony.ViewModels
{
    public class AstrologyViewModel : BaseViewModel
    {
        public AstrologyViewModel()
        {

        }

        public List<ImageModel> AstrologyImageList
        {
            get
            {
                return new List<ImageModel> {
                    new ImageModel { ImagePath="astrology",imagename="astrology1.PNG" },
                    new ImageModel { ImagePath="astrology",imagename="astrology2.PNG" } ,
                    new ImageModel { ImagePath="astrology",imagename="astrology3.PNG" },
                    new ImageModel { ImagePath="astrology",imagename="astrology4.PNG" },
                    new ImageModel { ImagePath="astrology",imagename="astrology5.PNG" },
                    new ImageModel { ImagePath="astrology",imagename="astrology6.PNG" },
                    new ImageModel { ImagePath="astrology",imagename="astrology7.PNG" },
                    new ImageModel { ImagePath="astrology",imagename="astrology8.PNG" },
                    new ImageModel { ImagePath="astrology",imagename="astrology9.PNG" },
                    new ImageModel { ImagePath="astrology",imagename="astrology10.PNG" },
                    new ImageModel { ImagePath="astrology",imagename="astrology11.PNG" }
                };
            }
        }

        public string AstrologyURL
        {
            get
            {
                return App.AppHostUrl + "archaryatulsi.png";
            }
        }
    }
}

using Matrimony.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Matrimonial
{
    public class MatrimonialMemberImage : BaseViewModel
    {
        public int id { get; set; }
        public string imagename { get; set; }
        public string ImageUrl
        {
            get
            {
                if (imagename == "" || imagename == null)
                {
                    return App.IsMemberMale ? "boy" : "girl";
                    //return "namste.png";// App.AppSetup.MatrimonialViewModel.IsMale ? "boy" :"girl";// "namste.png";// "introscreen.png";//"welcome.jpg" "welcome.jpg";// "MarriageIcon.jpg";
                }
                else
                    return $"{apiService.ImageHostName}{memberid}/{imagename}";// string.Concat(App.GetImageGalleryFolderURL, memberid, "/", image);
            }
        }
        public int memberid { get; set; }
        public int isdeleted { get; set; }
    }
}

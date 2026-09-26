using Matrimony.Managers;
using Matrimony.Models.Response;
using Matrimony.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models
{
    public class MemberImage : BaseViewModel
    {
        public int id { get; set; }
        public string imagename { get; set; }
        public int memberid { get; set; }
        public string ImageUrl1
        {
            get
            {
                //return "girl";
                //return "welcome";//
                //return "http://www.atyourservicejain.com/images/welcome.jpg";
                //return App.GetImageGalleryFolderURL + "pjksmembers/" + memberid + "/" + imagename;
                return $"{apiService.ImageHostName}" + "pjksmembers/" + $"{memberid}/{imagename}";
            }
        }
        public string ImageUrl
        {
            get
            {
                //return "namste.png";
                if (imagename == "" || imagename == null || imagename == "namste.jpg")
                {
                    return $"{apiService.ImageHostName}" + "pjksmembers/" + $"{imagename}";
                }
                else
                    return $"{apiService.ImageHostName}" + "pjksmembers/" + $"{memberid}/{imagename}";
                //if (imagename == "" || imagename == null)
                //{
                //    return App.IsMemberMale ? "boy" : "girl";
                //    //return "namste.png";// App.AppSetup.MatrimonialViewModel.IsMale ? "boy" :"girl";// "namste.png";// "introscreen.png";//"welcome.jpg" "welcome.jpg";// "MarriageIcon.jpg";
                //}
                //else
                //return apiService.AppImageHostName+ "gallery/pjksmembers/2/" +imagename;// string.Concat(App.GetImageGalleryFolderURL, memberid, "/", image);
            }
        }
    }
}

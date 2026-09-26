using Matrimony.ViewModels;

namespace Matrimony.Models
{
    public class ImageModel : BaseViewModel
    {
        public ImageModel()
        {

        }

        public ImageModel(string imagePath)
        {
            ImagePath = imagePath;
        }
        public int id { get; set; }
        public string imagename { get; set; }
        public string ImageUrl
        {
            get
            {
                //if (imagename == "" || imagename == null)
                //    return "namste.png";// "introscreen.png";//"welcome.jpg" "welcome.jpg";// "MarriageIcon.jpg";
                //else if(ImagePath!=null && ImagePath!="")
                //    return $"{apiService.ImageHostName}"+ImagePath+"/"+imagename;
                //else
                    //return $"{apiService.ImageHostName}" +"pjksmembers/" +$"{memberid}/{imagename}";// string.Concat(App.GetImageGalleryFolderURL, memberid, "/", image);
                return string.Concat(apiService.AppImageFolderPath, !string.IsNullOrEmpty(ImagePath) ? ImagePath+ "/":"", imagename);
            }
        }
        public string ImagePath { get; set; }
        public int memberid { get; set; }
        public int isdeleted { get; set; }
    }
}

using Matrimony.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Matrimonial
{
    public class CommitteeMember : BaseViewModel
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public string ImageUrl
        {
            get
            {
                if (Image == "" || Image == null)
                    return "welcome.jpg";
                else
                    return string.Concat(App.GetImageFolderURL,  "/", Image);
            }
        }
    }
}

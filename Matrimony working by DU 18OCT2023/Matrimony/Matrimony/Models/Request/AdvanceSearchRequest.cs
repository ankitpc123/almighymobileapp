using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Request
{
   public class AdvanceSearchRequest
    {
        public string minage { get; set; }
        public string maxage { get; set; }
        public string minheight { get; set; }
        public string maxheight { get; set; }
        public string minincome { get; set; }
        public string maxincome { get; set; } 
        public string maritalstatus { get; set; }
        public string religion { get; set; }
        public string mothertoungh { get; set; }
        public string gender { get; set; }
        public string wansh { get; set; }
    }
}

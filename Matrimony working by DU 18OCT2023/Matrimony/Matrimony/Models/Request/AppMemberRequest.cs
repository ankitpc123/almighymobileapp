using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Request
{
    public class AppMemberRequest
    {
        public string devicetoken { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string imageBase64String { get; set; }
        public string profession { get; set; }

    }
}

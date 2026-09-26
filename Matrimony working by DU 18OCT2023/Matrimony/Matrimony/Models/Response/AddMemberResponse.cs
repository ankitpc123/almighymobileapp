using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
    public class AddMemberRequest
    {
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string fathername { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string birthtime { get; set; }
        public string birthplace { get; set; }
        public string height { get; set; }
        public string religion { get; set; }
        public string subreligion { get; set; }
        public string mobile { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string education { get; set; }
        public decimal income { get; set; }
        public string wans { get; set; }
        public string gotra { get; set; }
        public string mangali { get; set; }
        public int brothers { get; set; }
        public int sisters { get; set; }
        public string milan { get; set; }
        public string bloodgroup { get; set; }
        public string occupation { get; set; }
        public string mobile2 { get; set; }
        public string familyoccupation { get; set; }
        public string imageBase64String { get; set; }
        public string email { get; set; }

    }
    public class AddMemberResponse:BaseResponse
    {
        public int memberid { get; set; }
    }
}

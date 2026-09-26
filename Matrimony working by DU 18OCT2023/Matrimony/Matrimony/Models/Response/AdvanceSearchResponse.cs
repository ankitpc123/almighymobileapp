using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
   public class AdvanceSearchResponse: BaseResponse
    {
        public bool success { get; set; }

        [JsonProperty(PropertyName = "list")]
        public IList<MatrimonialMember> list { get; set; }
    }
    public class SearchList
    {
        public int income { get; set; }
        public string mobile { get; set; }
        public string gotra { get; set; }
        public int memberid { get; set; }
        public string dissability { get; set; }
        public string lastname { get; set; }
        public string wans { get; set; }
        public string mangali { get; set; }
        public string middlename { get; set; }
        public string image { get; set; }
        public string education { get; set; }
        public int brothers { get; set; }
        public string zip { get; set; }
        public string email { get; set; }
        public string city { get; set; }
        public int sisters { get; set; }
        public string BloodGroup { get; set; }
        public string gender { get; set; }
        public bool milan { get; set; }
        public string complexion { get; set; }
        public int familyincome { get; set; }
        public string ResidentialStatus { get; set; }
        public string fathername { get; set; }
        public int age { get; set; }
        public string firstname { get; set; }
        public double height { get; set; }
        public string sanskarpatrikano { get; set; }
        public int isdeleted { get; set; }
        public string birthplace { get; set; }
        public object WantToMarryInterCaseOnly { get; set; }
        public string familyaddress { get; set; }
        public string birthtime { get; set; }
        public object kundaliImageName { get; set; }
        public string state { get; set; }
        public string Priority { get; set; }
        public string subreligion { get; set; }
        [JsonProperty(PropertyName = "dob")]
        public PersonDob dob { get; set; }
        public string address { get; set; }
        public string familyoccupation { get; set; }
        public string weight { get; set; }
        public string occupation { get; set; }
        public string mothername { get; set; }
        public string description { get; set; }
        public string occupationprofile { get; set; }
        public object MemberMobile { get; set; }
        public string religion { get; set; }
        public string phone { get; set; }
    }
    public class PersonDob
    {
        public int TimezoneOffset { get; set; }
        public bool IsValidDateTime { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public int Millisecond { get; set; }
        public bool IsNull { get; set; }
        public DateTime Value { get; set; }
    }
}

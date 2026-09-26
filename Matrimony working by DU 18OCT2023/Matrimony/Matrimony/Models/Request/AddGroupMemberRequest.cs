using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Request
{
    public class AddGroupMemberRequest
    {
        public string devicetoken { get; set; }
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string middlename { get; set; }
        public string LastName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOM { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string Mobile { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneOffice { get; set; }
        public string Profession { get; set; }
        public string Designation { get; set; }
        public string Age { get; set; }
        public string imageUrl { get; set; }

        public string parentRelationShip { get; set; }
        public string ParentId { get; set; }
        public string Husband { get; set; }
        public string Email { get; set; }
        public int isDeleted { get; set; }
        public string BasicAddress { get; set; }
        public string Wansh { get; set; }
        public int IsMarried { get; set; }
        public string Education { get; set; }
        public int MemberNo { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public string imageBase64String { get; set; }
    }
}

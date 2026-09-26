using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models
{
    public class DirectoryMember
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string middlename { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + middlename + " " + LastName; } }
        public string FName { get; set; }
        public string MName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOM { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string GetAddress
        {
            get
            {
                return string.Concat(city, ",", state, ",", zip);
            }
        }
        public string Mobile { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneOffice { get; set; }
        public string Profession { get; set; }
        public string Designation { get; set; }
        public string Age { get; set; }
        public string GetAge
        {
            get
            {
                return string.Concat(Age, " ", "yrs");
            }
            set
            {
                Age = value;
            }
        }
        public string ImageUrl
        {
            get
            {
                return "welcome.jpg";// "welcome.jpg";
            }
        }
        public string ImageUrl1
        {
            get
            {
                return "user.jpg";
            }
        }
        public string ParentRelationShip { get; set; }
    }
}

using Matrimony.Managers;
using Matrimony.Models.Enums;
using Matrimony.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;

namespace Matrimony.Models
{
    public class Member //: BaseViewModel
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string middlename { get; set; }
        public string LastName { get; set; }
        public string fullName { get { return FirstName + " " + middlename + " " + LastName; } }
        public string FullName { get { return FirstName + " " + middlename + " " + LastName; } }
        public string FName { get; set; }
        public string MName { get; set; }
        public string GetName
        {
            get
            {
                return string.Concat(FirstName, (!string.IsNullOrEmpty(FName)? " c/o "+ FName: ""));
            }
        }
        public string GetName1
        {
            get
            {
                return string.Concat(DOB.ToString("d").Substring(0, 5), DateTime.Today.ToString("dd/MM/yyyy").Substring(0,5));
            }
        }
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
        public string imageUrl { get; set; }

        public string AppImageHostName => App.AppHostUrl+ $"images/";
        public string ImageUrl
        {
            get
            {
                //return "welcome";
                if (MemberId == 0)
                {
                    return "norecordfound";
                }
                else if (imageUrl == "" || imageUrl == null)
                    return App.AppHostUrl + "images/welcome.jpg";
                else
                    return App.AppHostUrl+ "images/groups/1/" + imageUrl;
            }
        }
        public string GetImageUrl
        {
            get
            {
                return "welcome";
            }
        }
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
    }

}
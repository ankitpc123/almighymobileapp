using Matrimony.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models
{
    public class MatrimonialMember : BaseViewModel
    {
        public int memberid { get; set; }
        public string IncomeText => string.Format("Rs. {0} Lakh", Math.Round((decimal)(decimal.Parse(income ?? "0") / 10000), 2));
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string fullname { get { return firstname + " " + middlename + " " + lastname; } }

        public string GetNameWithMemberId { get { return firstname + " " + middlename + " " + lastname; } }

        public string age { get; set; }
        public string GetAge
        {
            get
            {
                return string.Concat(age, " ", "yrs");
            }
            set
            {
                age = value;
            }
        }

        public string GetAgeHeight
        {
            get
            {
                height = "5'6''";
                age = "16";
                string inch = height.Replace("''", "").Replace("'", ",").Split(',')[1];
                string foot = height.Replace("''", "").Replace("'", ",").Split(',')[0];
                float f = Convert.ToSingle(foot);
                float i = Convert.ToSingle(inch);
                float cm = (f * 30.48f) + (i * 2.54f);
                string rt = string.Concat("उम्र- ", age, " ", "yrs | ", foot, " Ft ", inch, " In ", " / ", cm.ToString(), " cms");
                return rt;
            }
            set
            {
                age = value;
            }
        }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string GetAddress
        {
            get
            {
                return string.Concat(city, ",", state);
            }
        }
        public string mobile { get; set; }
        public string phone { get; set; }
        public string profession { get; set; }
        public string email { get; set; }
        public string fathername { get; set; }
        public string mothername { get; set; }
        public int brothers { get; set; }
        public int sisters { get; set; }
        public Dob dob { get; set; }
        public string height { get; set; }
        public string GetHeight
        {
            get
            {
                return height.Replace("\''", " Ft ").Replace("\'", " In ");
            }
            set
            {
                height = value;
            }
        }
        public string weight { get; set; }
        public string complexion { get; set; }
        public string gotra { get; set; }
        public string wans { get; set; }
        public string income { get; set; } = "0";
        public string GetIncome
        {
            get
            {
                return string.Concat("मासिक आय ", income);
            }
        }
        public string familyincome { get; set; }
        public string familyaddress { get; set; }
        public string education { get; set; }
        public string description { get; set; }
        public string birthplace { get; set; }
        public string birthtime { get; set; }
        public string religion { get; set; }
        public string subreligion { get; set; }
        public string GetReligin
        {
            get
            {
                return string.Concat(religion, ":", subreligion);
            }
        }
        public string mangali { get; set; }
        public bool milan { get; set; }
        public bool isdeleted { get; set; }
        string iconSource;
        public string IconSource
        {
            get
            {
                if (iconSource == "" || iconSource == null)
                    return "welcome.jpg";// "MarriageIcon.jpg";
                else
                    return iconSource;
            }
            set
            {
                iconSource = value;
            }
        }
        public string image { get; set; }
        public string ImageUrl
        {
            get
            {
                if (image == "" || image == null)
                    return gender == "Female" ? "girl" : "boy";// "welcome.jpg";// "MarriageIcon.jpg";
                else
                    return $"{apiService.ImageHostName}{memberid}/{image}";// string.Concat(App.GetImageGalleryFolderURL, memberid, "/", image);
            }
        }

        public double? latitude;
        public double? longitude;
        public double Longitude { 
            get {
                return longitude == null ? 0.0 : Convert.ToDouble(longitude);
            }
            set
            {
                longitude = value;
            } 
        }
        public double Latitude {
            get
            {
                return latitude == null ? 0.0 : Convert.ToDouble(latitude);
            }
            set
            {
                latitude = value;
            }
        }
        public string BloodGroup { get; set; }
        public string gender { get; set; }
        public string ResidentialStatus { get; set; }
        public string sanskarpatrikano { get; set; }
        public object WantToMarryInterCaseOnly { get; set; }
        public string Priority { get; set; }
        public string familyoccupation { get; set; }
        public string occupation { get; set; }
        public string occupationprofile { get; set; }
        public object MemberMobile { get; set; }

        public string kundaliImageName { get; set; }
        public string kundaliImageNameUrl
        {
            get
            {
                if (kundaliImageName == "" || kundaliImageName == null)
                    return gender == "Female" ? "girl" : "boy";// "welcome.jpg";// "MarriageIcon.jpg";
                else
                    return $"{apiService.ImageHostName}{memberid}/{kundaliImageName}";// string.Concat(App.GetImageGalleryFolderURL, memberid, "/", image);
            }
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(DobConverter))]
    public class Dob
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

    /// <summary>
    /// Handles dob deserialization for both:
    ///   - PHP API (new): plain string "2020-08-02"
    ///   - .NET API (old): JSON object with Year/Month/Day/Value etc.
    /// </summary>
    public class DobConverter : Newtonsoft.Json.JsonConverter<Dob>
    {
        public override Dob ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType,
            Dob existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == Newtonsoft.Json.JsonToken.String)
            {
                var raw = reader.Value?.ToString();
                if (DateTime.TryParse(raw, out var dt))
                    return new Dob { Year = dt.Year, Month = dt.Month, Day = dt.Day, Value = dt, IsValidDateTime = true };
                return new Dob { IsNull = true };
            }

            if (reader.TokenType == Newtonsoft.Json.JsonToken.StartObject)
            {
                var dob = new Dob();
                serializer.Populate(reader, dob);
                return dob;
            }

            return new Dob { IsNull = true };
        }

        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, Dob value, Newtonsoft.Json.JsonSerializer serializer)
        {
            writer.WriteValue(value?.Value.ToString("yyyy-MM-dd"));
        }
    }
}

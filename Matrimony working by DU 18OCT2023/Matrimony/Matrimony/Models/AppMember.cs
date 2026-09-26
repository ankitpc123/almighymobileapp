using SQLite;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models
{
    public class AppMember
    {

        [SQLite.PrimaryKey]
        public int appMemberId { get; set; }
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
        public string imagename { get; set; }
        public string imagepath { get; set; }
        public string profession { get; set; }
    }
}

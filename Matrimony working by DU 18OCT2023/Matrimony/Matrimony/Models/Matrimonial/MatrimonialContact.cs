using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Matrimonial
{
    public class MatrimonialContact
    {
        public string relation { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string district { get; set; }
        public int memberid { get; set; }
        public string zip { get; set; }
        public int isdeleted { get; set; }
        public string address2 { get; set; }
        public string phone { get; set; }
        public string city { get; set; }
        public int contractid { get; set; }
        public string address1 { get; set; }
        public string state { get; set; }
        public string FullAddress => $"{address1} {city} {state}";
    }
}

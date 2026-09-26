using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
    public class NearByResponse : BaseResponse
    {
        public int statusCode { get; set; }
        public bool success { get; set; }
        public List<Member> list { get; set; }
        public string responseStatusCode { get; set; }
        public string responseMessage { get; set; }
    }
}

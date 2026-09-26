using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
   public class GroomListResponse : BaseResponse
    {
        [Newtonsoft.Json.JsonProperty("list")]
        public List<MatrimonialMember> GroomList { get; set; }
    }
}

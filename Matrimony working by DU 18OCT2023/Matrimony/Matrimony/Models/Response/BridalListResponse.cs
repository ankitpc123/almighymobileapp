using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
   public class BridalListResponse:BaseResponse
    {
        [Newtonsoft.Json.JsonProperty("list")]
        public IEnumerable<MatrimonialMember>  BridalList { get; set; }
    }
}

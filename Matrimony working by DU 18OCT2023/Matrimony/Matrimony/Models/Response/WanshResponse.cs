using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
    public class WanshResponse : BaseResponse
    {
        public bool success;
        [Newtonsoft.Json.JsonProperty("list")]
        public List<Wansh> WanshList { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
    public class SearchResponse:BaseResponse
    {
        [Newtonsoft.Json.JsonProperty("list")]
        public List<MatrimonialMember> SearchList { get; set; }
    }
}

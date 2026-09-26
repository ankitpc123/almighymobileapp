using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
    public class AddAppMemberResponse : BaseResponse
    {
        public int memberid { get; set; }
        public string message { get; set; }
        public AppMember appMember { get; set; }
    }
}

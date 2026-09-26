using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
    public class MembersResponse : BaseResponse
    {
        public bool success;
        public IEnumerable<Member> list { get; set; }
    }
}

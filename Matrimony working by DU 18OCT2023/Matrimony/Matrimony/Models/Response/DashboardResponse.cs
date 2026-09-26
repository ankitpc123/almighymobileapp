using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
   public class DashboardResponse:BaseResponse
    {
        public List<MatrimonialMember> Males { get; set; }
        public List<MatrimonialMember> Females { get; set; }
    }
}

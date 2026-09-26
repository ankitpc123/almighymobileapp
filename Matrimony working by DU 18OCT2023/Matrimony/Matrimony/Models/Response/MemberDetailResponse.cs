using Matrimony.Models.Matrimonial;
using Matrimony.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
   public class MemberDetailResponse:BaseResponse
    {
        public MatrimonialMember matrimonialMember { get; set; }
        public List<MatrimonialContact> matrimonialContactList { get; set; }
        public List<MatrimonialFamilyMember> matrimonialFamilyMemberList { get; set; }
        public List<MatrimonialMemberImage> matrimonialMemberImageList { get; set; }
        
    }
}

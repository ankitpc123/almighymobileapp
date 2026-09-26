using Matrimony.Models.Matrimonial;
using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models.Response
{
    public class GroupMemberResponse : BaseResponse
    {
        public bool success;
        public Member member { get; set; }
        public List<Member> familyMemberList { get; set; }
        public List<MemberImage> memberImageList { get; set; }

        public void ClearLists()
        {
            familyMemberList.Clear();
            memberImageList.Clear();
        }
    }
}

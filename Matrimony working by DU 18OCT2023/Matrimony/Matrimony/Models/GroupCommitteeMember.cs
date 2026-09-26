using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Matrimony.Models
{
    public  class GroupCommitteeMember
    {
        public int GroupCommitteeId { get; set; }
        public int GroupId { get; set; }
        public string Year { get; set; }

        public string PositionName { get; set; }

        public string Name { get; set; }

        public string ImageName { get; set; }

        public int MemberId { get; set; }

        public string PositionInHindi { get; set; }

    }
}

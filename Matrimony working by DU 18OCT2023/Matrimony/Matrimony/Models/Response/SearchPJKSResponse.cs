using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Matrimony.Models.Response
{
    public class SearchPJKSResponse : BaseResponse
    {
        public bool success;
        public ObservableCollection<Member> list { get; set; }
    }
}

using Matrimony.Models.Request;
using Matrimony.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Matrimony.Managers
{
   public interface IApiService
    {
        #region Global Settings
        string HostName { get; }
        string ImageHostName { get; }
        string AppImageHostName { get; }
        string AppImageFolderPath { get; }
        #endregion

        #region Response Property
        BridalListResponse BridalListResponse { get; }
        GroomListResponse GroomListResponse { get; }
        MemberDetailResponse MemberDetailResponse { get; }
        DashboardResponse DhashboardResponse { get; } 
        SearchResponse SearchResponse { get; }
        AddMemberResponse AddMemberResponse { get; }
        AdvanceSearchResponse AdvanceSearchResponse { get; }
        AddAppMemberResponse AddAppMemberResponse { get; }

        GroupMemberResponse GroupMemberResponse { get; }
        MembersResponse MembersResponse { get; }
        MembersResponse BirthdayMarriageAnniversaryMembersResponse { get; }
        WanshResponse WanshResponse { get; set; }

        SearchPJKSResponse SearchPJKSResponse { get; }

        MembersResponse PJKSGroupCommitteeMembersResponse { get; }

        NearByResponse nearByResponse { get; }
        AddGroupMemberResponse AddGroupMemberResponse { get; }
        #endregion

        #region Methods
        Task GetBridalList(int pagingnumber, Action success, Action<BaseResponse> failure);
        Task GetGroomList(int pagingnumber,Action success, Action<BaseResponse> failure);
        Task GetMemeberDetails(int memberid,Action success, Action<BaseResponse> failure);
        Task DashboardDataList(List<int> shortlistmembers, Action success, Action<BaseResponse> failure);
        Task SearchDataList(string searchtext, Action success, Action<BaseResponse> failure);
        Task AddMember(AddMemberRequest addMemberRequest , Action success, Action<BaseResponse> failure);
        Task GetAdvanceSearchList(AdvanceSearchRequest request, Action success, Action<BaseResponse> failure);
        Task AddAppMember(AppMemberRequest addAppMemberRequest, Action success, Action<BaseResponse> failure);
        Task LoginAppMember(Matrimony.Models.Request.LoginRequest loginAppMemberRequest, Action success, Action<BaseResponse> failure);
        
        Task GetWanshList(Action success, Action<BaseResponse> failure);

        #endregion

        #region "PJKS"
        Task GetMembers(Action success, Action<BaseResponse> failed);
        Task GetBirthdayMarriageAnniversaryMembers(Action success, Action<BaseResponse> failed);
        Task GetGroupMemeberDetail(int memberid, Action success, Action<BaseResponse> failure);

        Task SearchPJKSDataList(string searchtext, Action success, Action<BaseResponse> failure);
        Task GetPJKSGroupCommitteeList(int GroupId, Action success, Action<BaseResponse> failure);

        Task GetNearByList(string radius, string latitude, string longitude, Action success, Action<BaseResponse> failure);
        Task GetPJKSNearByList(string radius, string latitude, string longitude, Action success, Action<BaseResponse> failure);

        Task GetPJKSAdvanceSearchList(AdvanceSearchRequest request, Action success, Action<BaseResponse> failure);

        Task AddGroupMember(AddGroupMemberRequest addGroupMemberRequest, Action success, Action<BaseResponse> failure);
        #endregion
    }
}

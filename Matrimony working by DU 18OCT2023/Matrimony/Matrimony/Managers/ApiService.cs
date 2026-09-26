using Matrimony.ApiProvider;
using Matrimony.Models;
using Matrimony.Models.Request;
using Matrimony.Models.Response;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Matrimony.Managers
{
    public class ApiService : IApiService
    {

        #region Property
        private readonly IApiProvider apiProvider;

        #endregion
        
        #region Global Settings
        //public string BaseURLHostName => $"http://www.atyourservicejain.com";
        public string BaseURLHostName => $"https://atyourservicejain.in";
        //public string HostName => BaseURLHostName + $"/webservice.aspx?";
        public string HostName => BaseURLHostName + $"/webservice.php?";
        public string APIHostName => $"https://atyourservicejain.in/";
        public string ImageHostName => BaseURLHostName + $"/images/gallery/";
        public string AppImageHostName => BaseURLHostName+$"/images/";
        public string AppImageFolderPath => BaseURLHostName + $"/images/";
        #endregion

        public ApiService(IApiProvider _apiProvider)
        {
            apiProvider = _apiProvider;
        }

        #region Response Property
        public BridalListResponse BridalListResponse => bridalListResponse;
        BridalListResponse bridalListResponse { get; set; }
        public GroomListResponse GroomListResponse => groomListResponse;
        GroomListResponse groomListResponse { get; set; }

        public MemberDetailResponse MemberDetailResponse => memberDetailResponse;
        MemberDetailResponse memberDetailResponse { get; set; }

        public DashboardResponse DhashboardResponse => dhashboardResponse;
        DashboardResponse dhashboardResponse { get; set; }

        public SearchResponse SearchResponse => searchResponse;
        SearchResponse searchResponse { get; set; }

        

        public AddMemberResponse AddMemberResponse => addMemberResponse;
        AddMemberResponse addMemberResponse { get; set; }

        AdvanceSearchResponse advancesearchResponse { get; set; }
        public AdvanceSearchResponse AdvanceSearchResponse => advancesearchResponse;
        public AddAppMemberResponse AddAppMemberResponse => addAppMemberResponse;
        AddAppMemberResponse addAppMemberResponse { get; set; }

        
        public GroupMemberResponse GroupMemberResponse => groupMemberResponse;
        GroupMemberResponse groupMemberResponse { get; set; }

        private MembersResponse membersResponse { get; set; }
        public MembersResponse MembersResponse
        {
            get { return membersResponse; }
        }

        private MembersResponse birthdayMarriageAnniversaryMembersResponse;
        public MembersResponse BirthdayMarriageAnniversaryMembersResponse
        {
            get { return birthdayMarriageAnniversaryMembersResponse; }
        }

        public WanshResponse WanshResponse { get; set; }


        private SearchPJKSResponse searchPJKSResponse;
        public SearchPJKSResponse SearchPJKSResponse
        {
            get { return searchPJKSResponse; }
        }


        private MembersResponse pjksGroupCommitteeMembersResponse;
        public MembersResponse PJKSGroupCommitteeMembersResponse
        {
            get { return pjksGroupCommitteeMembersResponse; }
        }

        public NearByResponse nearByResponse { get; set; }

        public AddGroupMemberResponse AddGroupMemberResponse => addGroupMemberResponse;
        AddGroupMemberResponse addGroupMemberResponse { get; set; }

        #endregion

        #region Methods
        public async Task GetBridalList(int pagingnumber, Action success, Action<BaseResponse> failure)
        {
           await Task.Factory.StartNew(async() =>
           {
               //var url = $"{HostName}opr=matrimoniallist&gender=female&page=1&pageSize={pagingnumber}";
               var url = App.AppHostUrl+ $"Matrimonial.php?opr=matrimoniallist&gender=female&page=1&pageSize={pagingnumber}";
               var result = await apiProvider.Get<BridalListResponse>(url);
               if(result.IsSuccess)
               {
                   bridalListResponse = result.value;
                   success.Invoke();
               }
               else
               {
                   failure.Invoke(result.value);
               }
           });
        }
        public async Task GetGroomList(int pagingnumber, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                //var url = $"{HostName}opr=matrimoniallist&gender=male&page=1&pageSize={pagingnumber}";
                var url = App.AppHostUrl + $"Matrimonial.php?opr=matrimoniallist&gender=male&page=1&pageSize={pagingnumber}";
                var result = await apiProvider.Get<GroomListResponse>(url);
                if (result.IsSuccess)
                {
                    groomListResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }
        public async Task GetMemeberDetails(int memberid, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                var url = $"{HostName}opr=matrimonialdetail&memberId={ memberid }";
                var result = await apiProvider.Get<MemberDetailResponse>(url);
                if (result.IsSuccess)
                {
                    memberDetailResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }
        public async Task DashboardDataList(List<int> shortlistmembers, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                var members = shortlistmembers?.Count > 0 ? shortlistmembers :new List<int> {0 };
;                var url = $"{HostName}opr=sortmatrimoniallist&sortmembers={string.Join(",",members)}";
                var result = await apiProvider.Get<DashboardResponse>(url);
                if (result.IsSuccess)
                {
                    dhashboardResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }
        public async Task SearchDataList(string searchtext, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                var url = $"{HostName}opr=matrimoniallist&pageno=1&pageSize=25&search={searchtext}";
                var result = await apiProvider.Get<SearchResponse>(url);
                if (result.IsSuccess)
                {
                    searchResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }
        public async Task AddMember(AddMemberRequest addMemberRequest, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                //var url = $"{HostName}http://www.atyourservicejain.com/MatriMonialService.asmx/AddMember";
                //var url = $"http://www.atyourservicejain.com/MatriMonialService.asmx/AddMember";
                //var url = $"http://www.atyourservicejain.com/api/Matrimonial/AddMember";
                var url = APIHostName+$"/api/Matrimonial/AddMember";
                //var url = $"http://localhost:37211/api/Matrimonial/AddMember";
                var result = await apiProvider.Post<AddMemberResponse,AddMemberRequest>(url,addMemberRequest);
                if (result.IsSuccess)
                {
                    addMemberResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }
        public async Task GetAdvanceSearchList(AdvanceSearchRequest request, Action success, Action<BaseResponse> failure)
        {

            await Task.Factory.StartNew(async () =>
            {
                string url = default(string);
                //opr=advancesearch&gender=female&minage=1994-05-01&maxage=1994-6-30&minheight=155&maxheight=158
                //opr=advancesearch&gender=female&minage=1994-05-01&maxage=1994-6-30
//#if DEBUG
//                url = "http://www.atyourservicejain.com/webservice.aspx?opr=advancesearch&gender=female&minage=1994-05-01&maxage=1994-6-30&minheight=155&maxheight=158";
//#else
//if (!string.IsNullOrEmpty(request.maxheight))
//                    url = $"{HostName}opr=advancesearch&gender={request.gender}&minage={request.minage}&maxage={request.maxage}&minheight={request.minheight}&maxheight={request.maxheight}";
//                else
//                    url = $"{HostName}opr=advancesearch&gender={request.gender}&minage={request.minage}&maxage={request.maxage}";

//#endif
                url = $"{HostName}opr=advancesearch&gender={request.gender}&minage={request.minage}&maxage={request.maxage}&minheight={request.minheight}&maxheight={request.maxheight}";

                var result = await apiProvider.Get<AdvanceSearchResponse>(url);
                if (result.IsSuccess)
                {
                    advancesearchResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }

        public async Task AddAppMember(AppMemberRequest addAppMemberRequest, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                //var url = $"http://www.atyourservicejain.com/MatriMonialService.asmx/AddAppMember";
                var url = App.AppHostUrl + $"api/AppMember/AddAppMember";
                var result = await apiProvider.Post<AddAppMemberResponse, AppMemberRequest>(url, addAppMemberRequest);
                if (result.IsSuccess && result.value.memberid>0)
                {
                    addAppMemberResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    addAppMemberResponse = result.value;
                    failure.Invoke(result.value);
                }
            });
        }

        public async Task LoginAppMember(Matrimony.Models.Request.LoginRequest loginAppMemberRequest, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                var url = App.AppHostUrl + "AppMember.php";// $"http://www.atyourservicejain.com/api/AppMember/GetLogin";
                var result = await apiProvider.Post<AddAppMemberResponse, LoginRequest>(url, loginAppMemberRequest);
                if (result.IsSuccess)
                {
                    addAppMemberResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }

        public async Task GetWanshList(Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                var url = APIHostName +"Matrimonial/GetWanshList";
                var result = await apiProvider.Get<WanshResponse>(url);
                if (result.IsSuccess)
                {
                    WanshResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }


        #endregion

        #region "PJKS"
        //http://www.atyourservicejain.com/api/PJKSMember/GetPJKSList
        public async Task GetMembers(Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                string url = string.Format("{0}PJKSMember/GetPJKSList", APIHostName, "");
                var result = await apiProvider.Get<MembersResponse>(url);
                if (result.IsSuccess)
                {
                    membersResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }

        public async Task GetBirthdayMarriageAnniversaryMembers(Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                string url = string.Format("{0}PJKSMember/GetPJKSBirthdayMarriageAnniversaryList", APIHostName, "");
                var result = await apiProvider.Get<MembersResponse>(url);
                if (result.IsSuccess)
                {
                    birthdayMarriageAnniversaryMembersResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }
        public async Task GetGroupMemeberDetail(int memberid, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                string url = string.Format("{0}PJKSMember/GetGroupMemberDetail?MemberId={1}", APIHostName, memberid);
                var result = await apiProvider.Get<GroupMemberResponse>(url);
                if (result.IsSuccess)
                {
                    groupMemberResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }

        public async Task SearchPJKSDataList(string searchtext, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                string url = string.Format("{0}PJKSMember/SearchPJKSResponse?pageNo=1&pageSize=25&searchtext={1}", APIHostName, searchtext);
                var result = await apiProvider.Get<SearchPJKSResponse>(url);

                if (result.IsSuccess)
                {
                    searchPJKSResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }

        //http://www.atyourservicejain.com/api/PJKSMember/GetPJKSGroupCommitteeList?GroupId=1
        public async Task GetPJKSGroupCommitteeList(int GroupId, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                string url = string.Format("{0}PJKSMember/GetPJKSGroupCommitteeList?GroupId="+ GroupId, APIHostName, "");
                var result = await apiProvider.Get<MembersResponse>(url);
                if (result.IsSuccess)
                {
                    pjksGroupCommitteeMembersResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }

        public async Task GetNearByList(string radius, string latitude, string longitude, Action success, Action<BaseResponse> failure)
        {
            try
            {
                await Task.Factory.StartNew(async () =>
                {
                    var url = App.AppHostUrl+$"api/PJKSMember/GetNearByMattriList?radius=" + radius + "&latitude=" + latitude + "&longitude=" + longitude + "";
                    var result = await apiProvider.Get<NearByResponse>(url);
                    if (result.IsSuccess)
                    {
                        nearByResponse = result.value;
                        success.Invoke();
                    }
                    else
                    {
                        failure.Invoke(result.value);
                    }
                });
            }
            catch (Exception ex)
            {

            }
        }

        public async Task GetPJKSNearByList(string radius, string latitude, string longitude, Action success, Action<BaseResponse> failure)
        {
            try
            {
                await Task.Factory.StartNew(async () =>
                {
                    string url = string.Format("{0}PJKSMember/GetNearByMattriList?radius=" + radius + "&latitude=" + latitude + "&longitude=" + longitude, APIHostName, "");
                    var result = await apiProvider.Get<NearByResponse>(url);
                    if (result.IsSuccess)
                    {
                        nearByResponse = result.value;
                        success.Invoke();
                    }
                    else
                    {
                        failure.Invoke(result.value);
                    }
                });
            }
            catch (Exception ex)
            {

            }
        }

        public async Task GetPJKSAdvanceSearchList(AdvanceSearchRequest request, Action success, Action<BaseResponse> failure)
        {

            await Task.Factory.StartNew(async () =>
            {
                string url = default(string);
                //opr=advancesearch&gender=female&minage=1994-05-01&maxage=1994-6-30&minheight=155&maxheight=158
                //opr=advancesearch&gender=female&minage=1994-05-01&maxage=1994-6-30
                //#if DEBUG
                //                url = "http://www.atyourservicejain.com/webservice.aspx?opr=advancesearch&gender=female&minage=1994-05-01&maxage=1994-6-30&minheight=155&maxheight=158";
                //#else
                //if (!string.IsNullOrEmpty(request.maxheight))
                //                    url = $"{HostName}opr=advancesearch&gender={request.gender}&minage={request.minage}&maxage={request.maxage}&minheight={request.minheight}&maxheight={request.maxheight}";
                //                else
                //                    url = $"{HostName}opr=advancesearch&gender={request.gender}&minage={request.minage}&maxage={request.maxage}";

                //#endif
                //url = $"{HostName}opr=advancesearch&gender={request.gender}&minage={request.minage}&maxage={request.maxage}&minheight={request.minheight}&maxheight={request.maxheight}";
                url = string.Format("{0}PJKSMember/GetAdvanceSearchList?minage={1}&maxage={2}&gender={3}&wansh={4}", APIHostName, request.minage, request.maxage, request.gender, request.wansh);
                var result = await apiProvider.Get<MembersResponse>(url);
                if (result.IsSuccess)
                {
                    membersResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }

        public async Task AddGroupMember(AddGroupMemberRequest addGroupMemberRequest, Action success, Action<BaseResponse> failure)
        {
            await Task.Factory.StartNew(async () =>
            {
                //var url = $"{HostName}http://www.atyourservicejain.com/MatriMonialService.asmx/AddMember";
                //var url = $"http://www.atyourservicejain.com/MatriMonialService.asmx/AddMember";
                var url = App.AppHostUrl + $"api/Matrimonial/AddMember";
                //var url = $"http://localhost:37211/api/Matrimonial/AddMember";
                var result = await apiProvider.Post<AddGroupMemberResponse, AddGroupMemberRequest>(url, addGroupMemberRequest);
                if (result.IsSuccess)
                {
                    addGroupMemberResponse = result.value;
                    success.Invoke();
                }
                else
                {
                    failure.Invoke(result.value);
                }
            });
        }
        #endregion
    }
}

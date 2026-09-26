using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Matrimony.ApiProvider
{
    public interface IApiProvider 
    {
        Task<ApiResult<T>> Get<T>(string url, Dictionary<string, string> headers = null);
        Task<ApiResult<T>> Post<T, TR>(string url, TR body, Dictionary<string, string> headers = null);
    }
}

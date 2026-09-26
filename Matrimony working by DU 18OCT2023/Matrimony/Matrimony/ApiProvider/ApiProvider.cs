using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Matrimony.ApiProvider
{
    public class ApiProvider : IApiProvider
    {
        private readonly HttpClient httpClient;
        public ApiProvider()
        {
            HttpClientHandler handler = new HttpClientHandler();
            httpClient = new HttpClient(handler);
            TimeSpan ts = TimeSpan.FromSeconds(15);
            httpClient.Timeout = ts;

            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                return true;
            };
        }
        public async Task<ApiResult<T>> Get<T>(string url, Dictionary<string, string> headers = null)
        {
            try
            {
                /*HttpResponseMessage result = null;
                lock (httpClient)
                {
                     result =  httpClient.GetAsync(url).Result;
                }*/
                HttpResponseMessage result = await httpClient.GetAsync(url);
                System.Diagnostics.Debug.WriteLine($"\n\n\nAPI URL: {url }\n\n\n");
                var rawResult = await result.Content.ReadAsStringAsync() ;
                System.Diagnostics.Debug.WriteLine($"\n\n\nAPI Response: { rawResult }\n\n\n");
                try
                {

                    var deserialized = JsonConvert.DeserializeObject<T>(rawResult);
                    return new ApiResult<T> { value = deserialized,IsSuccess = true };// (rawResult, (int)result.StatusCode, deserialized);
                }
                catch (Exception e)
                {
                    return new ApiResult<T> { value = Activator.CreateInstance<T>() };
                }

            }
            catch (Exception ex)
            {
                string errorMessage = ex.InnerException.InnerException.Message;
                return new ApiResult<T> { value = Activator.CreateInstance<T>() };
                Debug.WriteLine("Error Message is :-" + ex.Message);

            }
        }

        public async Task<ApiResult<T>> Post<T, TR>(string url, TR body, Dictionary<string, string> headers = null)
        {
            HttpResponseMessage result = null;
            try
            {
                lock (httpClient)
                {                   
                    System.Diagnostics.Debug.WriteLine($"\n\n\nAPI URL: {url }\n\n\n");
                    var json = JsonConvert.SerializeObject(body);
                    var reqJson = Newtonsoft.Json.Linq.JObject.Parse(json.ToString());
                    var str = new StringContent(JsonConvert.SerializeObject(body));
                    result = httpClient.PostAsync(url, new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json")).Result;
                    System.Diagnostics.Debug.WriteLine($"\n\n\nAPI Request Json: {json}\n\n\n");
                }
                var rawResult = await result.Content.ReadAsStringAsync();
                var resJson = Newtonsoft.Json.Linq.JObject.Parse(rawResult.ToString());
                System.Diagnostics.Debug.WriteLine($"\n\n\nAPI Response: { resJson }\n\n\n");
                try
                {
                    var deserialized = JsonConvert.DeserializeObject<T>(rawResult);
                    return new ApiResult<T> { value = deserialized,IsSuccess = true };
                }
                catch (Exception e)
                {
                    return new ApiResult<T> { value = Activator.CreateInstance<T>(), IsSuccess = false };
                }
            }
            catch (OperationCanceledException tcex)
            {
                return new ApiResult<T> { value = Activator.CreateInstance<T>()};
                Debug.WriteLine("Error Message is :-" + tcex.Message);
            }
            catch (Exception ex)
            {
                return new ApiResult<T> { value = Activator.CreateInstance<T>() };
                Debug.WriteLine("Error Message is :-" + ex.Message);
            }
        }
    }

    public class ApiResult<T>
    {
        // private data members 
        private T data;

        public bool IsSuccess { get; set; } = false;

        // using properties 
        public T value
        {
            // using accessors 
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
    }
}

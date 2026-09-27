using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Matrimony.ApiProvider
{
    /// <summary>
    /// Handles PHP API responses where numbers and booleans are returned as strings.
    /// e.g. "milan": "0" -> false, "memberid": "768" -> 768, "brothers": "0" -> 0
    /// </summary>
    public class PhpTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            var t = Nullable.GetUnderlyingType(objectType) ?? objectType;
            return t == typeof(bool) || t == typeof(int) || t == typeof(long) || t == typeof(double) || t == typeof(float);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var underlying = Nullable.GetUnderlyingType(objectType) ?? objectType;
            var token = JToken.Load(reader);

            if (token.Type == JTokenType.Null)
                return Nullable.GetUnderlyingType(objectType) != null ? (object)null : Activator.CreateInstance(underlying);

            var raw = token.ToString().Trim();

            if (underlying == typeof(bool))
                return raw == "1" || raw.Equals("true", StringComparison.OrdinalIgnoreCase);

            if (underlying == typeof(int))
                return int.TryParse(raw, out var i) ? i : 0;

            if (underlying == typeof(long))
                return long.TryParse(raw, out var l) ? l : 0L;

            if (underlying == typeof(double))
                return double.TryParse(raw, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var d) ? d : 0.0;

            if (underlying == typeof(float))
                return float.TryParse(raw, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out var f) ? f : 0f;

            return Activator.CreateInstance(underlying);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            => writer.WriteValue(value?.ToString());
    }

    public static class PhpJsonSettings
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            Converters = { new PhpTypeConverter() },
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };
    }

    public class ApiProvider : IApiProvider
    {
        private readonly HttpClient httpClient;

        public ApiProvider(HttpMessageHandler handler = null)
        {
            if (handler == null)
            {
                var defaultHandler = new HttpClientHandler();
                defaultHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                handler = defaultHandler;
            }
            httpClient = new HttpClient(handler);
            httpClient.Timeout = TimeSpan.FromSeconds(30);
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

                    var deserialized = JsonConvert.DeserializeObject<T>(rawResult, PhpJsonSettings.Settings);
                    return new ApiResult<T> { value = deserialized, IsSuccess = true };
                }
                catch (Exception e)
                {
                    return new ApiResult<T> { value = Activator.CreateInstance<T>() };
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error Message is :-" + ex.Message);
                Debug.WriteLine("Inner Exception: " + ex.InnerException?.Message);
                Debug.WriteLine("Inner Inner Exception: " + ex.InnerException?.InnerException?.Message);
                return new ApiResult<T> { value = Activator.CreateInstance<T>() };
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
                    var deserialized = JsonConvert.DeserializeObject<T>(rawResult, PhpJsonSettings.Settings);
                    return new ApiResult<T> { value = deserialized, IsSuccess = true };
                }
                catch (Exception e)
                {
                    return new ApiResult<T> { value = Activator.CreateInstance<T>(), IsSuccess = false };
                }
            }
            catch (OperationCanceledException tcex)
            {
                Debug.WriteLine("Error Message is :-" + tcex.Message);
                return new ApiResult<T> { value = Activator.CreateInstance<T>()};
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error Message is :-" + ex.Message);
                Debug.WriteLine("Inner Exception: " + ex.InnerException?.Message);
                return new ApiResult<T> { value = Activator.CreateInstance<T>() };
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

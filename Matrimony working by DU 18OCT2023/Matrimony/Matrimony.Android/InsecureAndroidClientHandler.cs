using System;
using Javax.Net.Ssl;
using Java.Security;
using Java.Security.Cert;
using Xamarin.Android.Net;

namespace Matrimony.Droid
{
    /// <summary>
    /// AndroidClientHandler that trusts all SSL certificates.
    /// Fixes "chain validation failed" on older Android devices that don't
    /// have the Let's Encrypt / Hostinger root CA in their trust store.
    /// Keeps the native Android DNS + networking stack.
    /// </summary>
    public class InsecureAndroidClientHandler : AndroidClientHandler
    {
        protected override SSLSocketFactory ConfigureCustomSSLSocketFactory(HttpsURLConnection connection)
        {
            var context = SSLContext.GetInstance("TLS");
            context.Init(null, new ITrustManager[] { new TrustAllManager() }, null);
            return context.SocketFactory;
        }

        protected override IHostnameVerifier GetSSLHostnameVerifier(HttpsURLConnection connection)
            => new TrustAllHostnameVerifier();
    }

    internal class TrustAllManager : Java.Lang.Object, IX509TrustManager
    {
        public void CheckClientTrusted(X509Certificate[] chain, string authType) { }
        public void CheckServerTrusted(X509Certificate[] chain, string authType) { }
        public X509Certificate[] GetAcceptedIssuers() => new X509Certificate[0];
    }

    internal class TrustAllHostnameVerifier : Java.Lang.Object, IHostnameVerifier
    {
        public bool Verify(string hostname, ISSLSession session) => true;
    }
}

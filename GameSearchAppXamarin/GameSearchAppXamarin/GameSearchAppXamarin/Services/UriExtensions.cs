using System;
using System.Web;

namespace XamarinTranslator
{
    static class UriExtensions
    {
        public static Uri AddQueryParameter(this Uri uri, string key, string value)
        {
            var uriBuilder = new UriBuilder(uri);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query[key] = value;
            uriBuilder.Query = query.ToString();
            return uriBuilder.Uri;
        }
        public static Uri AddQueryParameter(this Uri uri, string key, string[] value)
        {
            var uriBuilder = new UriBuilder(uri);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            foreach (var item in value)
            {
                query[key] = item;
            }
            uriBuilder.Query = query.ToString();
            return uriBuilder.Uri;
        }
    }
}
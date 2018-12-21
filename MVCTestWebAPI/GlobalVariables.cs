using MVCTestWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Web;

namespace MVCTestWebAPI
{
    public static class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();
        static GlobalVariables()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:25068/api/");
            WebApiClient.DefaultRequestHeaders.Clear();

            var btoa = encoding("niraj:user123456");
            WebApiClient.DefaultRequestHeaders.Add("Authorization", String.Format("Basic  {0}", btoa));
            WebApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            
        }
        public static string encoding(string toEncode)
        {
            byte[] bytes = Encoding.GetEncoding(28591).GetBytes(toEncode);
            string toReturn = System.Convert.ToBase64String(bytes);
            return toReturn;
        }
    }
}
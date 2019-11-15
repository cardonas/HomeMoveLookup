using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MovieDataAccessLayer
{

    public class Apihelper
    {
        public static HttpClient ApiClient { get; set; }
        
        public static void InitializeClient()
        {
            try
            {
                ApiClient = new HttpClient();
                ApiClient.BaseAddress = new Uri("http://www.omdbapi.com/?apikey=333725e1&");
                ApiClient.DefaultRequestHeaders.Accept.Clear();
                ApiClient.DefaultRequestHeaders.Accept.Add
                (new MediaTypeWithQualityHeaderValue("application/json"));
            }
            catch(Exception)
            {
                throw;
            }
        }
     }

    
}

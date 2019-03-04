using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace RestApiTest
{
    public static class ApiHelper
    {

        //usually a proeprty is not static. 
        //httpclient once per application . it opens a TCp ipPort. it takes some time so only do it once.
        //it is designed to be thread safe and handle multiple calls. Example one browser.. multiple tabs doing stuff
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            //ApiClient.BaseAddress = new Uri("http://xkcd.com/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();

            //basically Says gives me Json and not a web page
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
                }

    }
}

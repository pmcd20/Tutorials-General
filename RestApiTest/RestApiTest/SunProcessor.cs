using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTest
{
    public class SunProcessor
    {
        //make calls asyce as dont know how long information will take to be returned
        //we look after our own appliaction so make it asynce so our application does not lock up
        public static async Task<SunModel> LoadSun()
        {
            string url = "https://api.sunrise-sunset.org/json?lat=53.50763954502314&lng=-8.881057118269383";

   

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    //read the data
                    //read as async binds properties 
                    SunResultModel result = await response.Content.ReadAsAsync<SunResultModel>();

                    return result.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTest
{
    public class ComicProcessor
    {



        //make calls asyce as dont know how long information will take to be returned
        //we look after our own appliaction so make it asynce so our application does not lock up
        public static async Task<ComicModel> LoadComic(int comicNumber = 0)
        {
            string url = "";

            if (comicNumber > 0 )
            {
                url = $"https://xkcd.com/{comicNumber}/info.0.json";

            }
            else
            {
                url = "https://xkcd.com/info.0.json";
            }

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    //read the data
                    //read as async binds properties 
                    ComicModel comic = await response.Content.ReadAsAsync<ComicModel>();

                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}

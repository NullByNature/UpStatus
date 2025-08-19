using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GrabWebsite
{
    class WebsiteGrabber
    {
        public async void GetWebsite(string url)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Website is ONLINE");
                }
                else
                {
                    Console.WriteLine("Website is OFFLINE");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

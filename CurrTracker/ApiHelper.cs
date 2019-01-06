using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CurrTracker
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }
        // only need 1 to be running in a program
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();

            //typically you may attempt to append a BaseAddress to simplify for common/ase URL structures
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //only retrieve type JSON data
        }
    }
}

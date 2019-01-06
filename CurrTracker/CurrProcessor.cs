using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrTracker
{
    public class CurrProcessor
    {
        //async for web requests because we do not want the app to be depend on the website performance
        //async allows parallel runs
        public static async Task<CurrencyModel> UpdateCurrency() 
        {   
            //insert the JSON Api with key for URL
            string url = "http://apilayer.net/api/live?access_key=15afa2b2864bf83af0aed9acaa743f08";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CurrencyModel currModel = await response.Content.ReadAsAsync<CurrencyModel>();
                    //ReadAsAsync comes with the APIclient, the NewtonSoftJSONconvertor takes the APi info
                    //and converts this into the specific type, in this case type CurrModel (and maps over)
                    //its going to ignore undeclared properties found in the source JSON (i.e. we dont care)
                    
                    return currModel;
            
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}

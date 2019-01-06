using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrTracker
{

    public class CurrencyModel
    {
        //the below also works
        //public Dictionary<string, double> Quotes { get; set; }
        //https://www.newtonsoft.com/json/help/html/DeserializeObject.htm
        //https://www.newtonsoft.com/json/help/html/DeserializeCollection.htm
        //https://app.quicktype.io/

        [Newtonsoft.Json.JsonProperty("success")]
        public bool Success { get; set; }

        [Newtonsoft.Json.JsonProperty("terms")]
        public Uri Terms { get; set; }

        [Newtonsoft.Json.JsonProperty("privacy")]
        public Uri Privacy { get; set; }

        [Newtonsoft.Json.JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [Newtonsoft.Json.JsonProperty("source")]
        public string Source { get; set; }

        [Newtonsoft.Json.JsonProperty("quotes")]
        public Dictionary<string, double> Quotes { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Calculator
{
    // Сurrency myDeserializedClass = JsonConvert.DeserializeObject<List<Currency>>(myJsonResponse);
    public class Currency
    {
        [JsonProperty("ccy")]
        public string CurrencyCode { get; set; }

        [JsonProperty("base_ccy")]
        public string NationalCurrencyCode { get; set; }

        [JsonProperty("buy")]
        public string Buy { get; set; }

        [JsonProperty("sale")]
        public string Sale { get; set; }
    }

}

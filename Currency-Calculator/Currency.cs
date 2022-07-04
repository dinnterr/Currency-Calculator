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
        public string Код { get; set; }

        [JsonProperty("base_ccy")]
        public string НацКод { get; set; }

        [JsonProperty("buy")]
        public string Купівля { get; set; }

        [JsonProperty("sale")]
        public string Продаж { get; set; }
    }

}

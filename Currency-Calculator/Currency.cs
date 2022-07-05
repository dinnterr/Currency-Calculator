using Newtonsoft.Json;

namespace Currency_Calculator
{
 
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

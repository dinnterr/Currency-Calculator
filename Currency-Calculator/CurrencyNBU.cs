using Newtonsoft.Json;

namespace Currency_Calculator
{
    
    public class CurrencyNBU
    {
        [JsonProperty("r030")]
        public int НомерКоду { get; set; }

        [JsonProperty("txt")]
        public string Найменування { get; set; }

        [JsonProperty("rate")]
        public double Курс { get; set; }

        [JsonProperty("cc")]
        public string Код { get; set; }

        [JsonProperty("exchangedate")]
        public string ПоточнаДата { get; set; }
    }


}

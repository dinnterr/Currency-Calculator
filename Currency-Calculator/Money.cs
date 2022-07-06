
namespace Currency_Calculator
{
    class Money
    {
        
        private double sum;
        private double usd;
        private double uah;
        private double eur;
        private double btc;
        private double usdSale;
        private double eurSale;
        private double btcSale;
        private double actualCurrency;
        private string currency;
        private string currency1;
        public Money(string currency, string currency1, double sum, double usd, double uah, double eur, double btc, double usdSale, double eurSale, double btcSale)
        {
            this.currency = currency;
            this.currency1 = currency1;
            this.sum = sum;
            this.usd = usd;
            this.uah = uah;
            this.eur = eur;
            this.btc = btc;
            this.usdSale = usdSale;
            this.eurSale = eurSale;
            this.btcSale = btcSale;
        }
        public double Transfer()
        {
            if (currency == "USD" && currency1 == "UAH")
            {
                actualCurrency = usd;
            }
            else if (currency == "USD" && currency1 == "EUR")
            {
                actualCurrency = usd / eurSale;
            }
            else if (currency == "USD" && currency1 == "BTC")
            {
                actualCurrency = 1 / btcSale;
            }
            else if (currency == "USD" && currency1 == "USD")
            {
                actualCurrency = 1;
            }
            else if (currency == "UAH" && currency1 == "USD")
            {
                actualCurrency = uah / usdSale;
            }
            else if (currency == "UAH" && currency1 == "EUR")
            {
                actualCurrency = uah / eurSale;
            }
            else if (currency == "UAH" && currency1 == "BTC")
            {
                double dollar;
                dollar = uah / usdSale;
                actualCurrency = dollar / btcSale;
            }
            else if (currency == "UAH" && currency1 == "UAH")
            {
                actualCurrency = 1;
            }
            else if (currency == "EUR" && currency1 == "UAH")
            {
                actualCurrency = eur;
            }
            else if (currency == "EUR" && currency1 == "USD")
            {
                actualCurrency = eur / usdSale;
            }
            else if (currency == "EUR" && currency1 == "BTC")
            {
                double dollar;
                dollar = eur / usdSale;
                actualCurrency = dollar / btcSale;
            }
            else if (currency == "EUR" && currency1 == "EUR")
            {
                actualCurrency = 1;
            }
            else if (currency == "BTC" && currency1 == "USD")
            {
                actualCurrency = btc;
            }
            else if (currency == "BTC" && currency1 == "EUR")
            {
                double dollar;
                dollar = eurSale / usd;
                actualCurrency = btc / dollar;
            }
            else if (currency == "BTC" && currency1 == "UAH")
            {
                actualCurrency = usd * btc;
            }
            else if (currency == "BTC" && currency1 == "BTC")
            {
                actualCurrency = 1;
            }

            double result = sum * actualCurrency;
            return result;
        }
        
    }
}

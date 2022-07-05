using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Currency_Calculator
{

    public partial class CurrencyCalculator : Form
    {
        public CurrencyCalculator()
        {
            InitializeComponent();

            sum1.Text = "Введіть суму (в форматі 0.00)";
            sum1.ForeColor = Color.Gray;
            sum2.Text = "0.00";
            sum2.ForeColor = Color.Black;
            sum3.Text = "0.00";
            sum3.ForeColor = Color.Black;
        }



        private async void button1_Click(object sender, EventArgs e)
        {
            string url = "https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5";

            HttpClient httpClient = new HttpClient();

            try
            {
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",

                };

                var httpResponseMessage = await httpClient.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

                var currencies = JsonConvert.DeserializeObject<Currency[]>(jsonResponse);
                eurBuy.DataSource = currencies;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                httpClient.Dispose();
            }
        }

        private void sum1_Enter(object sender, EventArgs e)
        {
            if (sum1.Text == "Введіть суму (в форматі 0.00)")
            {
                sum1.Text = "";
                sum1.ForeColor = Color.Black;
            }       
        }

        private void sum1_Leave(object sender, EventArgs e)
        {
            if (sum1.Text == "")
            {
                sum1.Text = "Введіть суму (в форматі 0.00)";
                sum1.ForeColor = Color.Gray;
            }
        }

        private async void count_Click(object sender, EventArgs e)
        {
            const int USD = 0;
            const int EUR = 1;
            const int BTC = 2;

            HttpClient client = new HttpClient();
            try
            {
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };

                string responce = await client.GetStringAsync("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
                List<Currency> currencies = JsonConvert.DeserializeObject<List<Currency>>(responce);
                
                double sum = Convert.ToDouble(sum1.Text);

                if(sum < 0)
                {
                    throw new Exception("Сума не може бути від`ємна.");
                }

                if (choose1.Text != "" && choose2.Text != "")
                {
                    string currency1 = choose1.Text;
                    string currency2 = choose2.Text;
                    double usd = Convert.ToDouble(currencies[USD].Купівля, numberFormatInfo);
                    double uah = 1;
                    double eur = Convert.ToDouble(currencies[EUR].Купівля, numberFormatInfo);
                    double btc = Convert.ToDouble(currencies[BTC].Купівля, numberFormatInfo);
                    double usdSale = Convert.ToDouble(currencies[USD].Продаж, numberFormatInfo);
                    double eurSale = Convert.ToDouble(currencies[EUR].Продаж, numberFormatInfo);
                    double btcSale = Convert.ToDouble(currencies[BTC].Продаж, numberFormatInfo);

                    Money money = new Money(currency1, currency2, sum, usd, uah, eur, btc, usdSale, eurSale, btcSale);

                    double result = money.Transfer();
                    sum2.Text = Convert.ToString(result);
                }
                else
                    throw new Exception("Оберіть валюти для конвертації.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Dispose();
            }  
        }
        
        private void CurrencyCalculator_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(571, 574);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

     
    }
}


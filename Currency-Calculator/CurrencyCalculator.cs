using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
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
            sum3.Text = "0.00";
            sum3.ForeColor = Color.Black;
            sum2.Text = "0.00";
            sum2.ForeColor = Color.Black;
            privatBank.Visible = false;
            NBU.Visible = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            const int USD = 0;
            const int EUR = 1;
            const int BTC = 2;
            const int USDnbu = 25;
            const int EURnbu = 32;

            HttpClient client = new HttpClient();

            try
            {
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };
                switch (bank.Text)
                {
                    case "НБУ":
                        {
                            NBU.Visible = true;
                            privatBank.Visible = false;
                            string responce = await client.GetStringAsync("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");
                            List<CurrencyNBU> currenciesNBU = JsonConvert.DeserializeObject<List<CurrencyNBU>>(responce);
                            nbuusd.Text = Convert.ToString(currenciesNBU[USDnbu].Курс);
                            nbueur.Text = Convert.ToString(currenciesNBU[EURnbu].Курс);
                            break;
                        }
                    case "ПриватБанк":
                        {
                            privatBank.Visible = true;
                            NBU.Visible = false;
                            string responce = await client.GetStringAsync("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
                            List<Currency> currencies = JsonConvert.DeserializeObject<List<Currency>>(responce);
                            usdbuy.Text = currencies[USD].Купівля;
                            usdsale.Text = currencies[USD].Продаж;
                            eurobuy.Text = currencies[EUR].Купівля;
                            eurosale.Text = currencies[EUR].Продаж;
                            btcbuy.Text = currencies[BTC].Купівля;
                            btcsale.Text = currencies[BTC].Продаж;
                            break;
                        }
                    case "":
                        throw new Exception("Оберіть банк.");
                }
                
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
            const int USDnbu = 25;
            const int EURnbu = 32;

            HttpClient client1 = new HttpClient();
            HttpClient client2 = new HttpClient();
            try
            {
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };

                string responce1 = await client1.GetStringAsync("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
                List<Currency> currencies = JsonConvert.DeserializeObject<List<Currency>>(responce1);

                string responce2 = await client2.GetStringAsync("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");
                List<CurrencyNBU> currenciesNBU = JsonConvert.DeserializeObject<List<CurrencyNBU>>(responce2);

                double sum = Convert.ToDouble(sum1.Text, numberFormatInfo);

                if(sum < 0)
                {
                    throw new Exception("Сума не може бути від`ємна.");
                }

                if (choose1.Text != "" && choose2.Text != "")
                {
                    string currency01 = choose1.Text;
                    string currency02 = choose2.Text;
                    double usd = Convert.ToDouble(currencies[USD].Купівля, numberFormatInfo);
                    double uah = 1;
                    double eur = Convert.ToDouble(currencies[EUR].Купівля, numberFormatInfo);
                    double btc = Convert.ToDouble(currencies[BTC].Купівля, numberFormatInfo);
                    double usdSale = Convert.ToDouble(currencies[USD].Продаж, numberFormatInfo);
                    double eurSale = Convert.ToDouble(currencies[EUR].Продаж, numberFormatInfo);
                    double btcSale = Convert.ToDouble(currencies[BTC].Продаж, numberFormatInfo);

                    string currency11 = choose1.Text;
                    string currency12 = choose2.Text;
                    double usd2 = Convert.ToDouble(currenciesNBU[USDnbu].Курс, numberFormatInfo);
                    double eur2 = Convert.ToDouble(currenciesNBU[EURnbu].Курс, numberFormatInfo);
                    double usdSale2 = Convert.ToDouble(currenciesNBU[USDnbu].Курс, numberFormatInfo);
                    double eurSale2 = Convert.ToDouble(currenciesNBU[EURnbu].Курс, numberFormatInfo);

                    //НБУ
                    Money money2 = new Money(currency11, currency12, sum, usd2, uah, eur2, 0, usdSale2, eurSale2, 0);
                    double result2 = money2.Transfer();
                    sum2.Text = Convert.ToString(Math.Round(result2, 2));
                    if (choose1.Text == "BTC" || choose2.Text == "BTC")
                    {
                        sum2.Text = "Немає даних";
                    }

                    //ПриватБанк
                    Money money1 = new Money(currency01, currency02, sum, usd, uah, eur, btc, usdSale, eurSale, btcSale);
                    double result1 = money1.Transfer();
                    sum3.Text = Convert.ToString(Math.Round(result1, 2));  
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
                client1.Dispose();
                client2.Dispose();
            }  
        }
        
        private void CurrencyCalculator_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(571, 574);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string first = choose1.Text;
            choose1.Text = choose2.Text;
            choose2.Text = first;
        }
    }
}


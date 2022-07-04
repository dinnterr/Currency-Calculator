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
            sum2.ForeColor = Color.Gray;
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
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",

            };

            string url = "https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5";

            HttpClient httpClient = new HttpClient();

            double sum = 0;
            double currency = 0;
            //double result;
            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

                var currencies = JsonConvert.DeserializeObject<Currency[]>(jsonResponse);

                sum = Convert.ToDouble(sum1.Text);

                
                //проба
                currency = Convert.ToDouble(currencies[0].Купівля, numberFormatInfo);
                sum2.Text = Convert.ToString(sum*currency);
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
        
        private void CurrencyCalculator_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(571, 574);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherChencker
{
    public partial class WeatherChenkerFrom : Form
    {
        Dictionary<string, string> citynames;

        public WeatherChenkerFrom()
        {
            InitializeComponent();
            this.citynames = new Dictionary<string, string>();
            this.citynames.Add("東京都", "3");
            this.citynames.Add("大阪府", "1");
            this.citynames.Add("愛知県", "2");
            this.citynames.Add("福岡県", "10");
            foreach (KeyValuePair<string, string> data in this.citynames)
            {
                areaBox.Items.Add (data.Key);
            } 

        }

        private void CitySelected(object sender, EventArgs e)
        {
            //天気予報サービスにアクセスする
            string citycode = citynames[areaBox.Text];
            string url =
                "https://and-idea.sbcr.jp/sp/90261/weatherCheck.php?city=" +
                citycode;
            HttpClient client = new HttpClient();
            string result = client.GetStringAsync(url).Result;

            //天気予報からアイコンのURLを取り出す
            JObject jobj = JObject.Parse(result);
            string todayWeatherIcon = (string)((jobj["url"] as JValue).Value);
            weatherIcon.ImageLocation = todayWeatherIcon;

        }

        private void ExitMenuClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

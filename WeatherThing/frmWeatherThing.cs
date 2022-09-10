using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherThinhg
{
    public partial class frmWeatherThing : Form
    {
        public frmWeatherThing()
        {
            InitializeComponent();
        }

        private string getEpochDate(long epochSeconds, long offset)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(epochSeconds + offset);

            return dateTimeOffset.DateTime.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var url = "https://api.myptv.com/geocoding/v1/locations/by-text?searchText=" + txtAddress.Text + "&apiKey=NDcyNzBmMDU5OWRjNDJmYTk1NTZhOGFhZTEyYmMxMTA6ZmFiYTE1ZTktODA5MS00NDFjLTk4ZTMtYjFiNzhlYTUyMDQ3";
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string responseText = reader.ReadToEnd();

            dynamic x = JObject.Parse(responseText);
            string lat = ((float)x.locations[0].referencePosition.latitude).ToString();
            string lon = ((float)x.locations[0].referencePosition.longitude).ToString();
            string quality = ((int)x.locations[0].quality.totalScore).ToString() + "%";
            Latitude.Text = lat;
            Longitude.Text = lon;
            lblMatchQuality.Text = quality;

            url = "https://api.openweathermap.org/data/3.0/onecall?lat=" + lat + "&lon=" + lon + "&units=metric&appid=022fdee9694e4e665ed0d23a1de0c78b";
            request = HttpWebRequest.Create(url);
            response = request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            responseText = reader.ReadToEnd();

            x = JObject.Parse(responseText);

            Currenttime.Text = getEpochDate((long)x.current.dt, (long)x.timezone_offset);
            Sunrise.Text = getEpochDate((long)x.current.sunrise, (long)x.timezone_offset);
            Sunset.Text = getEpochDate((long)x.current.sunset, (long)x.timezone_offset);
            Temperature.Text = ((float)(x.current.temp)).ToString() + "C";
            Feelslike.Text = ((float)(x.current.feels_like)).ToString() + "C";
            Pressure.Text = ((float)(x.current.pressure)).ToString() + "hPa";
            Humidity.Text = ((float)(x.current.humidity)).ToString() + "%";
            Clouds.Text = ((float)(x.current.clouds)).ToString() + "%";
            Dewpoint.Text = ((float)(x.current.dew_point)).ToString() + "C";
            //MessageBox.Show(((float)(x.current.temp)).ToString() + " " + getEpochDate((long)x.current.dt));

            url = "http://openweathermap.org/img/wn/" + x.current.weather[0].icon + ".png";
            request = HttpWebRequest.Create(url);
            response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            BinaryReader br = new BinaryReader(response.GetResponseStream());
            Bitmap bm = new Bitmap(stream);
            pbIcon.Image = bm;
        }

        private void frmWeatherThing_Load(object sender, EventArgs e)
        {

        }

        private void Humidity_Click(object sender, EventArgs e)
        {

        }
    }
}

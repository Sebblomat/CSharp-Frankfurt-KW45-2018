using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatzenWetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wc = new WebClient();
            textBox1.Text = wc.DownloadString("https://www.metaweather.com/api/location/650272/");

            WetterResult wr = Newtonsoft.Json.JsonConvert.DeserializeObject<WetterResult>(textBox1.Text);

            label1.Text = $"Sonnenaufgang: {wr.sun_rise:t} Sonnenabgang: {wr.sun_set:t}";
            dataGridView1.DataSource = wr.consolidated_weather;
        }
    }
}

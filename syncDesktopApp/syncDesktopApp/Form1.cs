using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace syncDesktopApp
{
    public partial class Form1 : Form
    {
        public int inputVal { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private async Task<WebResponse> pushResp()
        {
            WebRequest request = HttpWebRequest.Create($"http://127.0.0.1:5000/push/{ this.inputVal }");
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            return response;
        }

        private async Task<WebResponse> pullResp()
        {
            WebRequest request = HttpWebRequest.Create($"http://127.0.0.1:5000/pull");
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            return response;
        }

        private WebResponse GetResp()
        {
            WebRequest request = HttpWebRequest.Create($"http://127.0.0.1:5000/update/{ this.inputVal }");
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            System.Threading.Thread.Sleep(1000);
            return response;
        }

        private async Task<string> updateVal()
        {
            
            while (true)
            {

                
                this.inputVal++;

                WebResponse response = await Task.Run(() => GetResp());

                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseJson = reader.ReadToEnd();
                receiver.Clear();
                receiver.AppendText(responseJson.ToString());

                if (this.inputVal == 6)
                {
                    break;
                }
            }
            return "sucess!";
        }

        private async void button_Click(object something, EventArgs e)
        {
            string intput = sender.Text;
            this.inputVal = Int32.Parse(intput);
            await updateVal();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void receiver_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            puller.Clear();
            WebResponse resp = await pullResp();
            StreamReader reader = new StreamReader(resp.GetResponseStream());
            string responseJson = reader.ReadToEnd();
            puller.AppendText(responseJson);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void pusher_Click(object sender, EventArgs e)
        {
            pusherText.Clear();
            WebResponse resp = await pushResp();
            StreamReader reader = new StreamReader(resp.GetResponseStream());
            string responseJson = reader.ReadToEnd();
            pusherText.AppendText(responseJson);

        }
    }
}

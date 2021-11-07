﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object something, EventArgs e)
        {
            string input = sender.Text;
            int intput = Int32.Parse(input);
            while (true)
            {
                intput++;
                WebRequest request = HttpWebRequest.Create($"http://127.0.0.1:5000/update/{ intput.ToString() }");
                request.ContentType = "application/json";
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseJson = reader.ReadToEnd();
                receiver.Clear();
                receiver.AppendText(responseJson.ToString());
                System.Threading.Thread.Sleep(1000);

                if (intput == 6)
                {
                    break;
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void receiver_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

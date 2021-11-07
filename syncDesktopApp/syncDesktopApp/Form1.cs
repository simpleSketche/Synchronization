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
using ETABSv1;
using static ETABS_Globals;

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

        private WebResponse initialize(string etabJson)
        {
            WebRequest request = HttpWebRequest.Create($"http://127.0.0.1:5000/update/{ etabJson }");
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            return response;
        }


        private class BeamStorageGUID
        {
            private Dictionary<string, BeamStorageProperties> beamProperties = new Dictionary<string, BeamStorageProperties>();

            public BeamStorageGUID()
            {}

            public void BeamStorageGUIDAdd(string GUID, BeamStorageProperties beamProp)
            {
                beamProperties.Add(GUID, beamProp);
            }

        }

        private class BeamStorageProperties
        {
            private string uniqueName;
            private string startPt;
            private string endPt;
            private string section;
            private bool status;

            public BeamStorageProperties(string UniqueName, string StartPt, string EndPt, string Section, bool Status)
            {
                uniqueName = UniqueName;
                startPt = StartPt;
                endPt = EndPt;
                section = Section;
                status = Status;
            }
        }

        private async Task<string> updateVal()
        {
            // Attach to ETABS COM object
            cSapModel mySapModel;
            //cPluginCallback ISapPlugin;
            cOAPI myETABSObject;
            cHelper myHelper;
            myHelper = new Helper();
            myETABSObject = myHelper.GetObject("CSI.ETABS.API.ETABSObject");
            mySapModel = myETABSObject.SapModel;

            // 0 -- Initialize JSON File and Post to web
            //{GUID: {	UniqueName: ?, Start Point:	?, End Point:		?, Section:        ?, Status:         ?}}
            string GUID = "";

            mySapModel.FrameObj.GetAllFrames(ref NumberofFrames, ref MyName, ref PropName, ref StoryName, ref PointName1, ref PointName2, ref Point1X, ref Point1Y, ref Point1Z, ref Point2X, ref Point2Y, ref Point2Z, ref Angle, ref Offset1X, ref Offset2X, ref Offset1Y, ref Offset2Y, ref Offset1Z, ref Offset2Z, ref CardinalPoint);
            BeamStorageGUID bmStore = new BeamStorageGUID();
            for (int i = 0; i < NumberofFrames; i++)
            {
                mySapModel.FrameObj.GetGUID(MyName[i], ref GUID);
                BeamStorageProperties beamProp = new BeamStorageProperties(MyName[i], PointName1[i], PointName2[i], PropName[i], false);
                bmStore.BeamStorageGUIDAdd(GUID, beamProp);
            }

            string jsonData = JsonConvert.DeserializeObject<string>(bmStore.ToString());

            initialize(jsonData);

            while (true)
            {

                //GET REQUEST to get JSON

                // 1 -- Search for most recent locked items
                //int masterFrames = 0;
                //BeamStorageGUID[] beamJSON_master = new BeamStorageGUID[masterFrames]; ;
                //for (int i = 0; i < masterFrames; i++)
                //{
                    //mySapModel.FrameObj.GetGUID(MyName[i], ref GUID);
                    //BeamStorageProperties beamProp = new BeamStorageProperties(MyName[i], PointName1[i], PointName2[i], PropName[i], false);
                    //beamJSON[i] = new BeamStorageGUID(GUID, beamProp);
                //}


                // 2 -- Search through locked items list
                // 3 -- Search for changes to ETABS model


                // 4 -- Sleep for 10 seconds

                this.inputVal++;

                WebResponse response = await Task.Run(() => GetResp());

                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseJson = reader.ReadToEnd();
                receiver.Clear();
                receiver.AppendText(responseJson.ToString());

                if (this.inputVal == 100)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CSiAPIv1;
using static Globals;

namespace ETABS_Listener
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startRecord(object sender, RoutedEventArgs e)
        {
            myHelper = new Helper();
            myETABSObject = myHelper.GetObject("CSI.ETABS.API.ETABSObject");
            mySapModel = myETABSObject.SapModel;

            while (true)
            {
                // listening to the ETABS
                mySapModel.FrameObj.GetAllFrames(ref NumberofFrames, ref MyName, ref PropName, ref StoryName, ref PointName1, ref PointName2, ref Point1X, ref Point1Y, ref Point1Z, ref Point2X, ref Point2Y, ref Point2Z, ref Angle, ref Offset1X, ref Offset2X, ref Offset1Y, ref Offset2Y, ref Offset1Z, ref Offset2Z, ref CardinalPoint);
                changeLog.AppendText(String.Format("Number of beams {0}", NumberofFrames));
                Console.WriteLine(String.Format("Number of beams {0}", NumberofFrames));
                // if we got changes
                // then we sending the request to update

                // listening to the flask server


                System.Threading.Thread.Sleep(3000);
            }
    }
}   
}

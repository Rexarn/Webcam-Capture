using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CamCap
{
    public partial class Form1 : Form
    {

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public Form1()
        {
            InitializeComponent();
        }


        //make sure that you know which cameras are avalible when you start up the program..
        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                camchoose.Items.Add(Device.Name);
            camchoose.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        //show the cam feed in the picture box when you revv up them fryers.

        private void Camstrt_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[camchoose.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += pornhub_cam;
            videoCaptureDevice.Start();
        }

        //send camera footage into the picturebox motherfucker.
        private void pornhub_cam(object sender, NewFrameEventArgs eventArgs)
        {
            pornhub.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        //when program closes kill the FUCKIN' CAMERA DUDE?!..

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        //when you click the pic button the motherfucker takes a pic and asks where the actual fuck you want it to be..
        private void Capturebtn_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog savefilediag = new SaveFileDialog();
                savefilediag.Filter = "Ugly Picc|.png";
                if (savefilediag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    if (pornhub.Image != null)
                {
                    //Save First
                    Bitmap varBmp = new Bitmap(pornhub.Image);
                    Bitmap newBitmap = new Bitmap(varBmp);
                    varBmp.Save(savefilediag.FileName, ImageFormat.Png);
                    //Now Dispose to free the memory
                    varBmp.Dispose();
                    varBmp = null;
                }
                else
                { MessageBox.Show("null exception"); }


            }
        }
    }
}

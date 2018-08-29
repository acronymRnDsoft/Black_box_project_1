using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

namespace Black_Box
{
    public partial class BlackBox : Form
    {
        private FilterInfoCollection VideoDevices; //List of source video devices
        private VideoCaptureDevice WebCamSourceDevice; //Choosen source video device4
        private Point PreviousMousePosition;

        public BlackBox()
        {
            InitializeComponent();
            PreviousMousePosition = MousePosition;
        }

        private void BlackBox_Load(object sender, EventArgs e)
        {
            VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in VideoDevices)
            {
                ChooseVideoDevice.Items.Add(device.Name); //Fill the combo box with video devices
            }
            ChooseVideoDevice.SelectedIndex = 0;

            WebCamSourceDevice = new VideoCaptureDevice(VideoDevices[ChooseVideoDevice.SelectedIndex].MonikerString);
            WebCamSourceDevice.NewFrame += new NewFrameEventHandler(WebCamSourceDevice_NewFrame);
            WebCamSourceDevice.Start();

        }

        private void WebCamSourceDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap picture = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = picture;
        }

        private void BlackBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            WebCamSourceDevice.Stop();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point CurrentMousePosition = MousePosition;
            int DeltaX = CurrentMousePosition.X - PreviousMousePosition.X;
            int DeltaY = CurrentMousePosition.Y - PreviousMousePosition.Y;
            if (CurrentMousePosition == PreviousMousePosition)
            {
                DeltaX = 0;
                DeltaY = 0;
            }



            ShowDeltaX.Text = "X: " + DeltaX.ToString();
            ShowDeltaY.Text = "Y: " + DeltaY.ToString();

            PreviousMousePosition = MousePosition;
        }
    }
}

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
using Gma.System.MouseKeyHook;

namespace Black_Box
{
    public partial class BlackBox : Form
    {
        private FilterInfoCollection VideoDevices; //List of source video devices
        private VideoCaptureDevice WebCamSourceDevice; //Choosen source video device
        private Rectangle ScreenBounds = Screen.PrimaryScreen.Bounds;



        public BlackBox()
        {
            InitializeComponent();
        }

        private void BlackBox_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
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
            if (ModifierKeys == Keys.Control)
            {
                int MiddleX = ScreenBounds.Right / 2;
                int MiddleY = ScreenBounds.Bottom / 2;
                Cursor.Position = new Point(MiddleX, MiddleY);
                int DeltaX = e.X - MiddleX;
                int DeltaY = e.Y - MiddleY;

                ShowDeltaX.Text = "X: " + DeltaX.ToString();
                ShowDeltaY.Text = "Y: " + DeltaY.ToString();
            }
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ClassLibrary_CameraManipulating
{
    public class Camera_Class
    {
        public static FilterInfoCollection filterInfoCollection;
        public static VideoCaptureDevice VideoCaptureDevice;

        System.Windows.Forms.PictureBox CapturedVideo;
        System.Windows.Forms.PictureBox CapturedPicture;



        public void SetFrames(System.Windows.Forms.PictureBox capturedVideo, System.Windows.Forms.PictureBox capturedPicture)
        {
            CapturedVideo = capturedVideo;
            CapturedPicture = capturedPicture;
        }

        public void StartVideo(ComboBox ComboBox_Camera)
        {
            //adding all cameras to combo box
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(filterInfoCollection.Count<1)
            {
                MessageBox.Show("No camera detected, please connect it and try running the program again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    ComboBox_Camera.Items.Add(filterInfo.Name);
                    ComboBox_Camera.SelectedIndex = 0;
                    VideoCaptureDevice = new VideoCaptureDevice();
                }
                // \\

                // this starts the camera ( can convert to btn or whatever event)
                VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[ComboBox_Camera.SelectedIndex].MonikerString);
                VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                VideoCaptureDevice.Start();

                // \\
            }

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            System.GC.Collect();

            CapturedVideo.Image = Filter.ImageToFilter((Bitmap)eventArgs.Frame.Clone());
        }
    }
}

using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ClassLibrary_CameraManipulating
{
    public class Camera_Class
    {
        public static FilterInfoCollection filterInfoCollection;
        public static VideoCaptureDevice VideoCaptureDevice;
        System.Windows.Forms.PictureBox CapturedVideo;


        // Set the PictureBox to get the Captured Video
        public void SetFrames(System.Windows.Forms.PictureBox capturedVideo)
        {
            CapturedVideo = capturedVideo;
        }

        // Input the Captured Video into the PictureBox
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            System.GC.Collect();
            CapturedVideo.Image = Filter.ImageToFilter((Bitmap)eventArgs.Frame.Clone());
        }

        // Gets Cameras and starts the default one, if exists
        public void StartVideo(ComboBox ComboBox_Camera)
        {
            
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // If no camera detected, show message
            if(filterInfoCollection.Count<1)
            {
                MessageBox.Show("No camera detected, please connect it and try running the program again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Else, Add all cameras to combo box & Start the camera
            else
            {
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    ComboBox_Camera.Items.Add(filterInfo.Name);
                    ComboBox_Camera.SelectedIndex = 0;
                    VideoCaptureDevice = new VideoCaptureDevice();
                }

                // Starts the camera
                VideoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[ComboBox_Camera.SelectedIndex].MonikerString);
                VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                VideoCaptureDevice.Start();
            }

        }

    }
}

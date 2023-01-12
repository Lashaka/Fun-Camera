using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary_CameraManipulating
{
    public static class Sizing_Class 
    {
        // Setting sizes to CapturedPicture & CapturedVideo PictureBoxes
        public static void SetSize(PictureBox CapturedVideo, PictureBox CapturedPicture,Form ThisForm)
        {
            int ScreenHeight = ThisForm.Size.Height; //Gets user screen Height
            int ScreenWidth = ThisForm.Size.Width; //Gets user screen Width

            //setting size of both image boxes
            CapturedPicture.Width = ScreenWidth / 3;
            CapturedPicture.Height = ScreenHeight / 2;

            CapturedVideo.Width = ScreenWidth / 3;
            CapturedVideo.Height = ScreenHeight / 2;

            //setting location of both image boxes
            Point point1 = new Point(ScreenWidth/2 , ScreenHeight /4);
            CapturedPicture.Location = point1;
            Point point2 = new Point(ScreenWidth / 8, ScreenHeight / 4);
            CapturedVideo.Location = point2;

        }
    }
}

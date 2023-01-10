using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using ClassLibrary_CameraManipulating;
using static ClassLibrary_CameraManipulating.Filter;
using MessageBox = System.Windows.Forms.MessageBox;
namespace SpyWare
{

    public partial class Form1_Window : Form
    {
        Camera_Class camera_Class = new Camera_Class();

        public Form1_Window()
        {
            InitializeComponent();
            ComboBox_Effect.SelectedIndex = 0;

            MakeACircle(Button_IncreaseTra, 4);
            MakeACircle(Button_DecreaseTran, 4);
            MakeACircle(Button_DecreaseTran, 4);



        }

        public static void MakeACircle(Button btn, int value)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, btn.Width - value, btn.Height - value);
            btn.Region = new Region(p);
        }

        public static void MakeACircle(Label btn, int value)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, btn.Width - value, btn.Height - value);
            btn.Region = new Region(p);
        }

        private void Button_Capture_Click(object sender, EventArgs e)
        {
            if (Filter.FilterValue != (int)Filter.Effects.NoEffect) //if diffrent value than no color
            {
                CapturedPicture.Image = CapturedVideo.Image;   //applies filter if exists.
            }
            else //if no filter, skips the filter search and immidently prints result
            {
                CapturedPicture.Image = CapturedVideo.Image;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            camera_Class.SetFrames(CapturedVideo, CapturedPicture);

            Sizing_Class.SetSize(CapturedVideo, CapturedPicture, this);

            camera_Class.StartVideo(ComboBox_Camera);
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Camera_Class.VideoCaptureDevice != null)
            {
                if (Camera_Class.VideoCaptureDevice.IsRunning == true)
                {
                    Camera_Class.VideoCaptureDevice.Stop();
                }
            }

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            // CapturedPicture.Image.Save(@"Path", ImageFormat.Jpeg);
            // Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = ".Jpeg";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save an Image File";

            if (CapturedPicture.Image != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (saveFileDialog1.FileName != "" && saveFileDialog1.FileName != ".Jpeg")
                    {
                        // Saves the Image via a FileStream created by the OpenFile method.
                        System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                        // Saves the Image in the appropriate ImageFormat based upon the
                        // File type selected in the dialog box.
                        // NOTE that the FilterIndex property is one-based.
                        switch (saveFileDialog1.FilterIndex)
                        {
                            case 1:
                                this.CapturedPicture.Image.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;

                            case 2:
                                this.CapturedPicture.Image.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Png);
                                break;

                            case 3:
                                this.CapturedPicture.Image.Save(fs,
                                  System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                        }

                        // Code to write the stream goes here.
                        fs.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Please take a screenshot first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBox_Effect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox_Effect.SelectedIndex)
            {
                case (int)Effects.NoEffect:
                    Filter.FilterValue = (int)Effects.NoEffect;
                    break;

                case (int)Effects.Blue:
                    Filter.FilterValue = (int)Effects.Blue;
                    break;

                case (int)Effects.Red:
                    Filter.FilterValue = (int)Effects.Red;
                    break;

                case (int)Effects.Green:
                    Filter.FilterValue = (int)Effects.Green;
                    break;

                case (int)Effects.Yellow:
                    Filter.FilterValue = (int)Effects.Yellow;
                    break;

                case (int)Effects.Orange:
                    Filter.FilterValue = (int)Effects.Orange;
                    break;

                case (int)Effects.Pink:
                    Filter.FilterValue = (int)Effects.Pink;
                    break;

                case (int)Effects.Purple:
                    Filter.FilterValue = (int)Effects.Purple;
                    break;

                case (int)Effects.Black:
                    Filter.FilterValue = (int)Effects.Black;
                    break;

                case (int)Effects.White:
                    Filter.FilterValue = (int)Effects.White;
                    break;

                case (int)Effects.Brown:
                    Filter.FilterValue = (int)Effects.Brown;
                    break;

                case (int)Effects.DiscoParty:
                    Filter.FilterValue = (int)Effects.DiscoParty;
                    break;

                case (int)Effects.Rainbow:
                    Filter.FilterValue = (int)Effects.Rainbow;
                    break;

                case (int)Effects.Chess:
                    Filter.FilterValue = (int)Effects.Chess;
                    break;

                case (int)Effects.FlipX:
                    Filter.FilterValue = (int)Effects.FlipX;
                    break;

                case (int)Effects.FlipY:
                    Filter.FilterValue = (int)Effects.FlipY;
                    break;

            }

        }

        //last row cells are the same colour as the background, asked by the UI/UX designer 
        private void tableLayoutPanel4_CellPaint_1(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 2 )
            {
                e.Graphics.FillRectangle(Brushes.DimGray, e.CellBounds);
            }
        }

        //When user rezises all controls adapt accordingly
        private void Form1_Window_ResizeEnd(object sender, EventArgs e)
        {
            ResizeAll();
        }

        //Function that resizes every control invidually 
        void ResizeControl(Control control)
        {
            int originalFormWidth = 1500;
            int originalFormHeight = 800;

            // Get the current size of the screen
            Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            float widthRatio = (float)screenSize.Width / (float)originalFormWidth;
            float heightRatio = (float)screenSize.Height / (float)originalFormHeight;

            int textRatio = 1;

            if (control.GetType() == typeof(Button)) 
            {
                int ButtonWidth = 250;
                int ButtonHeight = 120;
                int TextSize = 22;

                control.Width = (int)(ButtonWidth * (Convert.ToDouble(this.Width) / Convert.ToDouble(originalFormWidth)));
                control.Height = (int)(ButtonHeight * (Convert.ToDouble(this.Height) / Convert.ToDouble(originalFormHeight)));

                control.Font= new Font("Roboto", (int)(TextSize * (textRatio * (Convert.ToDouble(this.Width) / Convert.ToDouble(originalFormWidth)))), FontStyle.Bold);
            }
            else if (control.GetType() == typeof(Label) && (control.Name== "Label_Screenshot" || control.Name == "Label_LiveCamera"))
            {
                int TextSize = 32;

                control.Font = new Font("Roboto", (int)(TextSize * (Convert.ToDouble(this.Width) / Convert.ToDouble(originalFormWidth))), FontStyle.Bold);

            }
            else if (control.GetType() == typeof(Label))
            {
                int TextSize = 22;

                control.Font = new Font("Roboto", (int)(TextSize * (textRatio * (Convert.ToDouble(this.Width) / Convert.ToDouble(originalFormWidth)))), FontStyle.Bold);

            }


        }

        //Selecting the resizable controls
        void ResizeAll()
        {
            ResizeControl(Button_Save);
            ResizeControl(Button_Capture);

            ResizeControl(Label_ChooseCamera);
            ResizeControl(Label_Effect);
            ResizeControl(Label_LiveCamera);
            ResizeControl(Label_Screenshot);
            ResizeControl(Label_TranValue);
            ResizeControl(Label_Transparency);
        }


        //to save latest window state
        FormWindowState LastWindowState = FormWindowState.Minimized;

        //Function that applies when window is maximized/minimized because ResizeEnd wont detect the change
        private void Form1_Window_Resize(object sender, EventArgs e)
        {
            // When window state changes
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {
                    ResizeAll();
                    // Maximized!
                }
                if (WindowState == FormWindowState.Normal)
                {
                    ResizeAll();
                    // Restored!
                }
            }
        }

        private void Button_IncreaseTra_Click_1(object sender, EventArgs e)
        {
            if (Filter.Transparency <= 90)
            {
                Transparency += 10;
                Label_TranValue.Text = Transparency.ToString();
            }
        }

        private void Button_DecreaseTran_Click_1(object sender, EventArgs e)
        {
            if (Filter.Transparency >= 10)
            {
                Transparency -= 10;
                Label_TranValue.Text = Transparency.ToString();
            }
        }
    }
}
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
            this.MaximumSize = new System.Drawing.Size(1485, 825);


            MakeACircle(Button_IncreaseTra, 4);
            MakeACircle(Button_DecreaseTran, 4);
            MakeACircle(Button_DecreaseTran, 4);
        }

        public static void MakeACircle(Button btn,int value)
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
                MessageBox.Show("Please take a screenshot first.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    Sizing_Class.SetSize(CapturedVideo, CapturedPicture, this);

        //}

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

                case (int)Effects.Holy:
                    Filter.FilterValue = (int)Effects.Holy;
                    break;

                case (int)Effects.FlipX:
                    Filter.FilterValue = (int)Effects.FlipX;
                    break;

                case (int)Effects.FlipY:
                    Filter.FilterValue = (int)Effects.FlipY;
                    break;

            }

        }

        private void Button_IncreaseTra_Click(object sender, EventArgs e)
        {
            if (Filter.Transparency <= 90)
            {
                Transparency += 10;
                Label_TranValue.Text = Transparency.ToString();
            }
            else
            {
                MessageBox.Show("100 is the maximum transparency value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_DecreaseTran_Click(object sender, EventArgs e)
        {
            if (Filter.Transparency >= 10)
            {
                Transparency -= 10;
                Label_TranValue.Text = Transparency.ToString();
            }
            else
            {
                MessageBox.Show("0 is the minimum transparency value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
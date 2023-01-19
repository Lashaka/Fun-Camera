using System;
using System.Drawing;
using System.Windows.Forms;
using ClassLibrary_CameraManipulating;
using Microsoft.Win32;
using static ClassLibrary_CameraManipulating.Filter;
using MessageBox = System.Windows.Forms.MessageBox;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;
using SystemColors = System.Drawing.SystemColors;

namespace Smart_Camera
{

    public partial class Form1_Window : Form
    {
        Camera_Class camera_Class = new Camera_Class();

        public Form1_Window()
        {
            InitializeComponent();
        }


        ///  Form Load & Close

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make The Transperency related buttons circle shaped
            CircleMaking_Class.MakeACircle(Button_IncreaseTra, 4);
            CircleMaking_Class.MakeACircle(Button_DecreaseTran, 4);

            // Start Capturing Video
            camera_Class.SetFrames(CapturedVideo);
            ///////////////   Sizing_Class.SetSize(CapturedVideo, CapturedPicture, this);
            camera_Class.StartVideo(ComboBox_Camera);

            // Selecting first index of effects
            ComboBox_Effect.SelectedIndex = 0;

            // ComboBox_Camera.DropDownStyle = ComboBoxStyle.DropDownList;
            // ComboBox_Effect.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // When Form stops, make sure to turn off the camera
            if (Camera_Class.VideoCaptureDevice != null)
            {
                if (Camera_Class.VideoCaptureDevice.IsRunning == true)
                {
                    Camera_Class.VideoCaptureDevice.Stop();
                }
            }
        }




        ///  Capture & Save buttons

        private void Button_Capture_Click(object sender, EventArgs e)
        {
            CapturedPicture.Image = CapturedVideo.Image;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            // Setting Save File Dialog settings
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = "MyScreenShot";
            saveFileDialog1.DefaultExt = ".Jpeg";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save an Image File";

            if (CapturedPicture.Image != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName != "" && saveFileDialog1.FileName != ".Jpeg")
                    {
                        // Saves the Image via a FileStream created by the OpenFile method
                        System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                        // Saves the Image in the appropriate ImageFormat based upon the ile type selected in the dialog box
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

                        // Code to write the stream goes here
                        fs.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please take a screenshot first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        ///  Form Resize

        // When user rezises all controls adapt accordingly
        private void Form1_Window_ResizeEnd(object sender, EventArgs e)
        {
            ResizeAll();
        }

        // Selecting the resizable controls
        void ResizeAll()
        {
            //buttons
            ResizeControl(Button_Save);
            ResizeControl(Button_Capture);

            //labels
            ResizeControl(Label_ChooseCamera);
            ResizeControl(Label_Effect);
            ResizeControl(Label_LiveCamera);
            ResizeControl(Label_Screenshot);
            ResizeControl(Label_TranValue);
            ResizeControl(Label_Transparency);
        }

        // Function that resizes every control invidually 
        void ResizeControl(Control control)
        {
            int originalFormWidth = 1500;
            int originalFormHeight = 800;

            // Get the current size of the screen
            Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            float widthRatio = (float)screenSize.Width / (float)originalFormWidth;
            float heightRatio = (float)screenSize.Height / (float)originalFormHeight;

            // if type button
            if (control.GetType() == typeof(Button))
            {
                int ButtonWidth = 250;
                int ButtonHeight = 110;
                int TextSize = 22;

                control.Width = (int)(ButtonWidth * (Convert.ToDouble(this.Width) / Convert.ToDouble(originalFormWidth)));
                control.Height = (int)(ButtonHeight * (Convert.ToDouble(this.Height) / Convert.ToDouble(originalFormHeight)));

                control.Font = new Font("Roboto", (int)(TextSize * (Convert.ToDouble(this.Width) / Convert.ToDouble(originalFormWidth))), FontStyle.Bold);
            }
            //if type label && specific control names
            else if (control.GetType() == typeof(Label) && (control.Name == "Label_Screenshot" || control.Name == "Label_LiveCamera"))
            {
                int TextSize = 32;

                control.Font = new Font("Roboto", (int)(TextSize * (Convert.ToDouble(this.Width) / Convert.ToDouble(originalFormWidth))), FontStyle.Bold);

            }
            //all leftover labels
            else if (control.GetType() == typeof(Label))
            {
                int TextSize = 22;

                control.Font = new Font("Roboto", (int)(TextSize * (Convert.ToDouble(this.Width) / Convert.ToDouble(originalFormWidth))), FontStyle.Bold);

            }


        }

        // To save latest window state
        FormWindowState LastWindowState = FormWindowState.Minimized;

        // Function that applies when window is maximized/minimized because ResizeEnd wont detect the change
        private void Form1_Window_Resize(object sender, EventArgs e)
        {
            // When window state changes
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;


                if (WindowState == FormWindowState.Maximized)
                {
                    // Maximized
                    ResizeAll();
                }
                if (WindowState == FormWindowState.Normal)
                {
                    // Restored
                    ResizeAll();
                }
            }
        }




        ///  Transparency control

        // Increases transparency % to filter
        private void Button_IncreaseTra_Click_1(object sender, EventArgs e)
        {
            if (Filter.Transparency <= 90)
            {
                Transparency += 10;
                Label_TranValue.Text = Transparency.ToString();
            }
        }

        // Decreases transparency % to filter
        private void Button_DecreaseTran_Click_1(object sender, EventArgs e)
        {
            if (Filter.Transparency >= 10)
            {
                Transparency -= 10;
                Label_TranValue.Text = Transparency.ToString();
            }
        }




        ///  Others

        // last row cells are the same colour as the background
        private void tableLayoutPanel4_CellPaint_1(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 2)
            {
                e.Graphics.FillRectangle(Brushes.DimGray, e.CellBounds);
            }
        }

        // Switch Case through all available filters
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



        /// Highlight for combobox

        // Setting the new wanted highlited colors
        Color cbxBackColor = Color.MediumTurquoise;
        Color cbxFontColor = Color.White;

        // Setting highlighted color to combobox in order to remove default blue
        void SetHighLightColor(object sender, DrawItemEventArgs e, Color BackColor, Color FontColor)
        {
            if (e.Index < 0)
            {
                return;
            }

            ComboBox combo = sender as ComboBox;

            // If selected fill in the wanted color
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(BackColor), e.Bounds);
                e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.White), e.Bounds);
            }
            //If other fill with default color
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(FontColor), e.Bounds);
                e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font, new SolidBrush(combo.ForeColor), new Point(e.Bounds.X, e.Bounds.Y));

            }

            e.DrawFocusRectangle();
        }

        // Applying new colors to combobox
        private void ComboBox_Camera_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetHighLightColor(sender, e, cbxBackColor, cbxFontColor);
        }

        // Applying new colors to combobox
        private void ComboBox_Effect_DrawItem(object sender, DrawItemEventArgs e)
        {
            SetHighLightColor(sender, e, cbxBackColor, cbxFontColor);
        }



        /// Button design

        // Setting border
        void SetButtonBorder(Button btn, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Button_Capture.ClientRectangle,
            SystemColors.ActiveBorder, 4, ButtonBorderStyle.Inset,
            SystemColors.ActiveBorder, 4, ButtonBorderStyle.Inset,
            SystemColors.ActiveBorder, 4, ButtonBorderStyle.Inset,
            SystemColors.ActiveBorder, 4, ButtonBorderStyle.Inset);
        }

        // Applying border
        private void Button_Capture_Paint(object sender, PaintEventArgs e)
        {
            SetButtonBorder(Button_Capture,e);
        }

        // Applying border
        private void Button_Save_Paint(object sender, PaintEventArgs e)
        {
            SetButtonBorder(Button_Save, e);
        }
    }
}
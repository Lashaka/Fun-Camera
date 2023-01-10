using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2013.Excel;
using DocumentFormat.OpenXml.Vml;
using ImageProcessor;
using ImageProcessor.Imaging.Formats;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using ImageBrush = System.Windows.Media.ImageBrush;
using Rectangle = System.Drawing.Rectangle;

namespace ClassLibrary_CameraManipulating
{
    public static class Filter
    {
        public static int FilterValue = 0;
        public static Bitmap OutputImage;
        public static Graphics ImageGraphics;
        public static int Transparency = 100; //lets user control filter transparency

        public enum Effects
        {
            NoEffect,
            Blue,
            Red,
            Green,
            Yellow,
            Orange,
            Pink,
            Purple,
            Black,
            White,
            Brown,
            DiscoParty,
            Rainbow,
            Chess,
            FlipX,
            FlipY
        }

        public static void ApplyColor(ref Graphics ImageGraphics, Bitmap OutputImage, Color color)
        {
            ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.Blue)), 0, 0, OutputImage.Width, OutputImage.Height);
            ImageGraphics.Dispose();
        }

        public static Image ImageToFilter(this Image inputImage) //uses enum values for better understanding of code
        {
            if (ImageGraphics != null)
            {
                ImageGraphics.Dispose();

            }

            int InputImageWidth = inputImage.Width;
            int InputImageHeight = inputImage.Height;

            OutputImage = new Bitmap(inputImage.Width, inputImage.Height);
            ImageGraphics = Graphics.FromImage(OutputImage);
            ImageGraphics.DrawImage(inputImage, 0, 0);

            inputImage.Dispose(); // disposing after usage to prevent memory leak


            //select the color
            switch (FilterValue)
            {
                case (int)Effects.NoEffect:
                    break;

                case (int)Effects.Blue:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Blue)), 0, 0, OutputImage.Width, OutputImage.Height);
                    //   ApplyColor(ref ImageGraphics, OutputImage, Color.Blue);
                    break;

                case (int)Effects.Red:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Red)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.Green:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Green)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.Yellow:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Yellow)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.Orange:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Orange)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.Pink:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Pink)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.Purple:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Purple)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.Black:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Black)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.White:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.White)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.Brown:
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Brown)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.DiscoParty: //random color
                    Random random = new Random();
                    int RandomNum = random.Next(-1, 10);
                    string str = ((Effects)RandomNum).ToString();
                    Color RandomColor = Color.FromName(str);

                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, RandomColor)), 0, 0, OutputImage.Width, OutputImage.Height);
                    break;

                case (int)Effects.Rainbow: //all rainbow colors
                    int RainbowPortion = OutputImage.Height / 7; // to calculate heigth easier for heigth

                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Red)), 0, 0, OutputImage.Width, RainbowPortion);
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Orange)), 0, RainbowPortion, OutputImage.Width, RainbowPortion);
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Yellow)), 0, RainbowPortion * 2, OutputImage.Width, RainbowPortion);
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Green)), 0, RainbowPortion * 3, OutputImage.Width, RainbowPortion);
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.SkyBlue)), 0, RainbowPortion * 4, OutputImage.Width, RainbowPortion);
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Blue)), 0, RainbowPortion * 5, OutputImage.Width, RainbowPortion);
                    ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Violet)), 0, RainbowPortion * 6, OutputImage.Width, RainbowPortion);
                    break;

                case (int)Effects.Chess: //all rainbow colors
                    int ChessPortionHeight = OutputImage.Height / 10; // to calculate heigth easier for heigth
                    int ChessPortionWidth = OutputImage.Width / 10; // to calculate heigth easier for Width

                    bool BlackOrWhite = true; //true = white, false = black
                    for (int i = 0; i < 10; i++)
                    {
                        if (BlackOrWhite == false)
                        {
                            BlackOrWhite = true;
                        }
                        else
                        {
                            BlackOrWhite = false;
                        }
                        for (int j = 0; j < 10; j++)
                        {
                            if (BlackOrWhite == true)
                            {
                                ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.White)), ChessPortionWidth * i, ChessPortionHeight * j, ChessPortionWidth, ChessPortionHeight);
                                BlackOrWhite = false;
                            }
                            else
                            {
                                ImageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(Transparency, Color.Black)), ChessPortionWidth * i, ChessPortionHeight * j, ChessPortionWidth, ChessPortionHeight);
                                BlackOrWhite = true;
                            }
                        }
                    }
                    break;


                case (int)Effects.FlipX: //random color        //BUGGED           

                    OutputImage.RotateFlip(RotateFlipType.Rotate180FlipX);


                    break;

                case (int)Effects.FlipY: //random color        //BUGGED              


                    OutputImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                    break;
            }

            string Path = AppDomain.CurrentDomain.BaseDirectory + @"tempImages/temp.png";


            return OutputImage;

        }       
      
    }
}

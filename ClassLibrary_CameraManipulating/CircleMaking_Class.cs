using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Camera
{
    public class CircleMaking_Class
    {

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
    }
}

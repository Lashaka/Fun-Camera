using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenXmlPowerTools;

namespace Smart_Camera
{
    public class CircleMaking_Class
    {
        // Make button a circle
        public static void MakeACircle(Button btn, int value)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, btn.Width - value, btn.Height - value);
            btn.Region = new Region(p);

        }
    }
}

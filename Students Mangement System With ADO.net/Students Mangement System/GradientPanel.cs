using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Students_Mangement_System
{
    class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorButtom { get; set; }
        public float Angel { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush LGB = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorButtom, this.Angel);
            Graphics g = e.Graphics;
            g.FillRectangle(LGB, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}

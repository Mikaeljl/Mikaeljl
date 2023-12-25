using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AVI.Properties
{
    internal class lbl_class
    {

        public class RoundedLabel : Label
        {
            public RoundedLabel()
            {
                this.BackColor = System.Drawing.Color.Transparent;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                GraphicsPath gp = new GraphicsPath();
                Rectangle r = this.ClientRectangle;
                int d = 20; 
                gp.AddArc(r.X, r.Y, d, d, 180, 90);
                gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
                gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
                gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
                gp.CloseFigure();
                this.Region = new Region(gp);
                base.OnPaint(e);
            }
        }
    }
}



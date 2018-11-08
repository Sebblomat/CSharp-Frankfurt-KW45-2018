using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDScreensaver
{
    class MeinButton : Button
    {
        int count = 0;
        protected override void OnPaint(PaintEventArgs pevent)
        {

            pevent.Graphics.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.FillEllipse(new LinearGradientBrush(ClientRectangle, BackColor, Parent.BackColor, 90),
                ClientRectangle);


            if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                pevent.Graphics.DrawEllipse(new Pen(Color.Silver, 4), ClientRectangle);

            StringFormat sf = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            pevent.Graphics.DrawString($"DVD {count++}", new Font("Ink Free", 26, FontStyle.Bold),
                Brushes.OrangeRed, ClientRectangle, sf);
        }
    }
}

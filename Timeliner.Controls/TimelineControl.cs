using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Timeliner.Controls
{
    public partial class TimelineControl : UserControl
    {
        public TimelineControl()
        {
            InitializeComponent();
        }

        Pen _pen;

        private void TimelineControl_Paint(object sender, PaintEventArgs e)
        {
            _pen = new Pen(Color.Red);
            PaintCanvas(e.Graphics);
            _pen.Dispose();
        }

        private void PaintCanvas(Graphics g)
        {
            int l = 0;
            int t = 0;
            int r = Size.Width - 1;
            int b = Size.Height - 1;
            //g.FillRectangle(Brushes.White, l, t, r, b);
            g.DrawLine(_pen, l, t, r, b);
            g.DrawLine(_pen, l, b, r, t);
        }
    }
}

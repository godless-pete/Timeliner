using System;
using System.Drawing;
using Timeliner.StorageClasses;

namespace Timeliner.Controls
{
    class TimelinePainter : IDisposable
    {
        Pen _pen;
        Font _font;

        public TimelinePainter()
        {
            // Create pens/brushes/fonts
            _pen = new Pen(Color.Red, 3f);
            _font = new Font(FontFamily.GenericMonospace, 30f);
        }

        public void Dispose()
        {
            // Dispose of pens/brushes/fonts
            _pen.Dispose();
            _font.Dispose();
        }

        public void PaintCanvas(Graphics canvas, TimelinePaintParams tpp)
        {
            var rec = tpp.CanvasRect;

            // Draw full-canvas cross
            canvas.DrawLine(_pen, rec.Left, rec.Top, rec.Right, rec.Bottom);
            canvas.DrawLine(_pen, rec.Left, rec.Bottom, rec.Right, rec.Top);

            // Draw number
            canvas.DrawString(tpp.EventCount.ToString(), _font, Brushes.Black, 5f, 40f);
        }

    }
}

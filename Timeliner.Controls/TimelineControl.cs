using System.Windows.Forms;
using Timeliner.StorageClasses;
using Timeliner.Logic;

namespace Timeliner.Controls
{
    public partial class TimelineControl : UserControl
    {
        public TimelineControl()
        {
            InitializeComponent();
            _timeline = null;
        }

        public void SetTimeline(Timeline timeline)
        {
            _timeline = timeline;
            var pp = PaintParamsCalculator.GetParams(_timeline, ClientRectangle);
            Invalidate();
        }

        Timeline _timeline;

        private void TimelineControl_Paint(object sender, PaintEventArgs e)
        {
            var pp = PaintParamsCalculator.GetParams(_timeline, ClientRectangle);
            using (var painter = new TimelinePainter())
            {
                painter.PaintCanvas(e.Graphics, pp);
            }
        }

    }
}

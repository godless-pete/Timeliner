using System.Drawing;
using Timeliner.StorageClasses;

namespace Timeliner.Logic
{
    public class PaintParamsCalculator
    {
        public static TimelinePaintParams GetParams(Timeline timeline, RectangleF canvasRect)
        {
            return new TimelinePaintParams()
            {
                CanvasRect = canvasRect,
                EventCount = ComputeEventCount(timeline)
            };
        }

        public static int ComputeEventCount(Timeline timeline) => 
            timeline?.Events?.Count ?? 0;
    }
}

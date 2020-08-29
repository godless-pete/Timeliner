using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Timeliner.StorageClasses;

namespace Timeliner.Logic.Tests
{

    [TestClass]
    public class TimelineParamsCalculatorTests
    {
        [TestMethod]
        public void EmptyTimeline()
        {
            RectangleF canvasRect = new RectangleF(0f, 0f, 320f, 240f);
            Timeline timeline = null;

            var  pp = PaintParamsCalculator.GetParams(timeline, canvasRect);

            Assert.AreEqual(320f, pp.CanvasRect.Width);
            Assert.AreEqual(240f, pp.CanvasRect.Height);
            Assert.AreEqual(0, pp.EventCount);
        }

        [TestMethod]
        public void ThreeEventTimeline()
        {
            RectangleF canvasRect = new RectangleF(0f, 0f, 800f, 600f);
            Timeline timeline = new Timeline();
            timeline.Events.Add(new TimelineEvent("2000-01-01", "first"));
            timeline.Events.Add(new TimelineEvent("2000-01-02", "second"));
            timeline.Events.Add(new TimelineEvent("2000-01-03", "third"));

            var pp = PaintParamsCalculator.GetParams(timeline, canvasRect);

            Assert.AreEqual(800f, pp.CanvasRect.Width);
            Assert.AreEqual(600f, pp.CanvasRect.Height);
            Assert.AreEqual(3, pp.EventCount);
        }

    }
}

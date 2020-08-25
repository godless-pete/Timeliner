using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Timeliner.StorageClasses.Tests
{
    [TestClass]
    public class TimelineTests
    {
        [TestMethod]
        public void TimelineConstructor()
        {
            var timeline = new Timeline();
            timeline.Events.Add(new TimelineEvent("1910-01-01", "Testing..1"));
            timeline.Events.Add(new TimelineEvent("2020-12-31", "Testing..2"));

            // Test that the two objects were added, and we accessor contains what it should
            Assert.AreEqual(2, timeline.Events.Count);
            Assert.AreEqual(typeof(TimelineEvent), actual: timeline.Events[0].GetType());
            Assert.AreEqual(typeof(TimelineEvent), actual: timeline.Events[1].GetType());
        }
    }
}

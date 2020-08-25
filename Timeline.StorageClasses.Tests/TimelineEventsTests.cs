using Microsoft.VisualStudio.TestTools.UnitTesting;
using Timeliner.StorageClasses;

namespace Timeline.StorageClasses.Tests
{
    [TestClass]
    public class TimelineEventsTests
    {
        [TestMethod]
        public void TimelineEventConstructor_Wartime()
        {
            var te = new TimelineEvent("1910-01-13", "Wartime date");

            Assert.AreEqual("Wartime date", te.Title);
            Assert.AreEqual(1910, te.Date.Year);
            Assert.AreEqual(1, te.Date.Month);
            Assert.AreEqual(13, te.Date.Day);
        }

        [TestMethod]
        public void TimelineEventConstructor_NYE2020()
        {
            var te = new TimelineEvent("2020-12-31", "New Years Eve 2020");

            Assert.AreEqual("New Years Eve 2020", te.Title);
            Assert.AreEqual(2020, te.Date.Year);
            Assert.AreEqual(12, te.Date.Month);
            Assert.AreEqual(31, te.Date.Day);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoogleAnalytics.Core;

namespace GoogleAnalyticsUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TrackerConfig config = new TrackerConfig();
            config.AppVersion = "1";
            config.TrackingId = "2";
            config.Debug = true;


            var x = new GoogleAnalytics.Core.EasyTracker(config);

            var y = x.GetTracker();
            y.SendView("Main");
        }
    }
}
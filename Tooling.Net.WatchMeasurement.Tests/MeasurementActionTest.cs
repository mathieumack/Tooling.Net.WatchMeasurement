using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Tooling.Net.WatchMeasurement.Tests
{
    [TestClass]
    public class MeasurementActionTest
    {
        [TestMethod]
        public void TimeEqualZero_Enabled()
        {
            MeasurementAction.IsEnabled = true;
            using (var measure = MeasurementAction.StartMeasure(watch =>
            {
                Assert.IsTrue(watch.ElapsedTicks.Equals(0));
            }, false))
            {
                Thread.Sleep(1000);
            }
        }

        [TestMethod]
        public void TimeEqualZero_Disabled()
        {
            MeasurementAction.IsEnabled = false;
            using (var measure = MeasurementAction.StartMeasure(watch =>
            {
                Assert.IsTrue(watch.ElapsedTicks.Equals(0));
            }, false))
            {
                Thread.Sleep(1000);
            }
        }

        [TestMethod]
        public void TimeEqual1500_Enabled()
        {
            MeasurementAction.IsEnabled = true;
            using (var measure = MeasurementAction.StartMeasure(watch =>
            {
                Assert.IsTrue(watch.ElapsedMilliseconds >= 1500 && watch.ElapsedMilliseconds <= 1502);
            }, true))
            {
                Thread.Sleep(1500);
            }
        }


        [TestMethod]
        public void TimeEqual1500_Disabled()
        {
            MeasurementAction.IsEnabled = false;
            using (var measure = MeasurementAction.StartMeasure(watch =>
            {
                Assert.IsTrue(watch.ElapsedMilliseconds.Equals(0));
            }, true))
            {
                Thread.Sleep(1500);
            }
        }
    }
}

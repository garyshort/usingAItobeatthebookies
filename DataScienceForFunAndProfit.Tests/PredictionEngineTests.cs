using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataScienceForFunAndProfit.Tests
{
    [TestClass]
    public class PredictionEngineTests
    {
        [TestMethod]
        public void ConditionedOnRunners()
        {
            var runnersAndRiders = Horse.GetRunnersAndRiders();
            var engine = new PredictionEngine(runnersAndRiders);

            Assert.AreEqual(
                0.12d,
                engine.ConditionedOnRunners().First().Value);
        }

        [TestMethod]
        public void ConditionedOnMileTimes()
        {
            var runnersAndRiders = Horse.GetRunnersAndRiders();
            var engine = new PredictionEngine(runnersAndRiders);

            Assert.AreEqual(
                0.94d,
                engine.ConditionedOnMileTimes().First().Value);
        }
    }
}

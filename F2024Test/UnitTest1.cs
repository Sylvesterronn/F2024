using NUnit.Framework;
using System;
using Classes; // Ensure this is included

namespace ShareTradeAdvisorTests
{
    public class TradeAdvisorTests
    {
        private TradeAdvisor _tradeAdvisor;
        private Share _share;

        [SetUp]
        public void Setup()
        {
            _tradeAdvisor = new TradeAdvisor();
            _share = new Share("AAPL", 150.00f); // Create a sample Share object for tests
        }

        [Test]
        public void SetAdvisorStrategy_ShouldSetStrategyCorrectly()
        {
            // Arrange
            string strategy = "Buy and Hold";
            float[] parameters = { 0.5f, 1.5f };

            // Act
            _tradeAdvisor.SetAdvisorStrategy(strategy, parameters);

            // Assert
            Assert.That(_tradeAdvisor.strategy, Is.EqualTo(strategy));  // Corrected here
            Assert.That(_tradeAdvisor.parameters, Is.EqualTo(parameters));  // Corrected here
        }
    }
}

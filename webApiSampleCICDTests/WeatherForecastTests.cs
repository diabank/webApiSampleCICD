using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using webApiSampleCICD;

namespace webApiSampleCICDTests
{
    [TestClass]
    public class WeatherForecastTests
    {
        [TestMethod]
        public void test_ToString()
        {
            DateTime date = new DateTime(2022, 1, 1);
            WeatherForecast test = new WeatherForecast(date, 50);

            Assert.AreEqual("Day: 01012022 - Temp: 121F", test.ToString());

        }

        [TestMethod]
        public void test_Celsius_TO_Fahrenheit()
        {
            DateTime date = new DateTime(2022, 1, 1);
            WeatherForecast test = new WeatherForecast(date, 50);

            Assert.AreEqual(121, test.TemperatureF);
        }
    }
}

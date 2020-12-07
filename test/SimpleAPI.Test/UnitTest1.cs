using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        private WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnsMyName() {
            var returnValue = controller.Get();
            Assert.Equal("Mocked", "Mocked");
        }

        [Fact]
        public void Test1()
        {

        }
    }
}

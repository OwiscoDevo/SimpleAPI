using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController wController = new WeatherForecastController();
        
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = wController.Get(1);

        }
        
        [Fact]
        public void Test1()
        {

        }
    }
}

using System;
using Xunit;
using BlazorApp.Server.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Server.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new WeatherForecastController(null);

            var result = controller.GetFoo();

            Assert.Null(result);
        }
    }
}

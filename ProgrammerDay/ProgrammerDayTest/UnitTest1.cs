using System;
using Xunit;
using ProgrammerDay;

namespace ProgrammerDayTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new ProgrammerDayGetDay();
            var result = controller.getDate(2016);
            // Assert.Equal("12.09.2016", result);
        }
    }
}

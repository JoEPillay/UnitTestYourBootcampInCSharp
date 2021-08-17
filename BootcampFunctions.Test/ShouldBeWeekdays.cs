using System;
using Xunit;

namespace BootcampFunctions.Test
{
    public class ShouldBeWeekdays
    {
        [Fact]
        public void ShouldBetrue()
        {
            var actual =BootcampFunctions.IsWeekDay.WhatDay("Monday");
            var expected =true;
            Assert.Equal(expected,actual);

        }
         [Fact]
        public void ShouldBetrueAgain()
        {
            var actual =BootcampFunctions.IsWeekDay.WhatDay("Thursday");
            var expected =true;
            Assert.Equal(expected,actual);

        }

        [Fact]
          public void ShouldBeFalse()
        {
            var actual =BootcampFunctions.IsWeekDay.WhatDay("Saturday").ToString();
            var expected =false;
            Assert.False(expected,actual);

        }
    }
}

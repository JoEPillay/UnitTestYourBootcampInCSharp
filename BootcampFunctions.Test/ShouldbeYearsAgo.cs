using System;
using Xunit;

namespace BootcampFunctions.Test
{
    public class ShouldbeYesrsago
    {

        [Fact]
        public void ShouldreturnYearsAgo()
        {
            
            var actual =BootcampFunctions.YearsAgo.Yearsago(1998);
            var expected = 23;
            Assert.Equal(expected,actual);
            

            

        }
           [Fact]
        public void ShouldreturnYearsAgoAgain()
        {
            
            var actual =BootcampFunctions.YearsAgo.Yearsago(1999);
            var expected = 22;
            Assert.Equal(expected,actual);
            

            

        }
    }
}

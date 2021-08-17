using System;
using Xunit;

namespace BootcampFunctions.Test
{
    public class ShouldBeFromBellville
    {
        [Fact]
        public void ShouldOnlyBe_Bellville()
        {
            var actual=BootcampFunctions.IsFrom_Bellville.Isfrom("CY 655 954");
            var expected = true;
            Assert.Equal(actual,expected);

        }
            [Fact]
        public void ShouldOnlyBe_BellvilleAgain()
        {
            var actual=BootcampFunctions.IsFrom_Bellville.Isfrom("CY 998 952");
            var expected = true;
            Assert.Equal(actual,expected);

        }
    }
}

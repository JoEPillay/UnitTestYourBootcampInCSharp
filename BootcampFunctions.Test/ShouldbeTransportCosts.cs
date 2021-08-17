using System;
using Xunit;

namespace BootcampFunctions.Test
{
    public class ShouldbeTransportCosts
    {
        [Fact]
        public void ShouldCostToTravel()
        {
            var actual = BootcampFunctions.TransportFees.transportFee("morning");
            var expected = "R20";
        Assert.Equal(expected,actual);
            
            
        }
    }
}

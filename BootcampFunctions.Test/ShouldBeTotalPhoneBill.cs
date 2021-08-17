using System;
using Xunit;

namespace BootcampFunctions.Test
{
    public class ShouldbeTotalPhoneBill
    {
        [Fact]
        public void ShouldReturnTotalBill()
        {
            var actual = BootcampFunctions.TotalPhoneBill.PhoneBill("call, sms, call, sms, sms");
            var expected = "R7,45";
            Assert.Equal(expected,actual);

        }
    }
}

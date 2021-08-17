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
            var expected = "R7.45";
            Assert.Equal(expected,actual);

        }
          [Fact]
        public void ShouldReturnTotalBillAgain()
        {
            var actual = BootcampFunctions.TotalPhoneBill.PhoneBill("call, sms");
            var expected = "R3.40";
            Assert.Equal(expected,actual);

        }
    }
}

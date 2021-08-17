using System;
using Xunit;

namespace BootcampFunctions.Test
{
    public class ShouldbeAllForPaarl
    {
        [Fact]
        public void ShouldReturnJustPaarl()
        {
            var actual=BootcampFunctions.AllForPaarl.AllPaarl("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864",1);
            var expected ="CJ 67890";
            Assert.Equal(expected,actual);

        }
           [Fact]
        public void ShouldReturnJustPaarlAgain()
        {
            var actual=BootcampFunctions.AllForPaarl.AllPaarl("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864",0);
            var expected ="CJ 678 543";
            Assert.Equal(expected,actual);

        }
    }
    }


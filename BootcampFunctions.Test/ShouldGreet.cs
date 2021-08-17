using System;
using Xunit;

namespace BootcampFunctions.Test
{
    public class ShouldGreet 
    {

        [Fact]
        public void shouldSayHi()
        {
            
            var actual = BootcampFunctions.Greet.SayHi("Josh");
            var expected = "hello, Josh!";
            Assert.Equal(expected,actual);


        }
         [Fact]
        public void shouldSayHiAgain()
        {
            var actual = BootcampFunctions.Greet.SayHi("Jack");
            var expected = "hello, Jack!";
            Assert.Equal(expected,actual);


        }

    }
}

using System;
using Xunit;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace BootcampFunctions.Test
{
    //git token "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"
    public class ShouldbeMostProfitableDepartment
    {
        [Fact]
        public void ShouldreturnMostProfitableDepartment()
        {
            var obj =new List<Departments>()
            {
                new Departments(){department="electronics",sales=200,day="Monday"},
                new Departments(){department="outdoor",sales=150,day="Tuesday"},
                new Departments(){department="carpentry",sales=360,day="Wednesday"},
                new Departments(){department="steelwork",sales=740,day="Thursday"},
                new Departments(){department="outdoor",sales=450,day="Friday"},
                new Departments(){department="hardware",sales=874,day="Tuesday"},
                new Departments(){department="electronics",sales=123,day="Thursday"},
                new Departments(){department="electronics",sales=652,day="Friday"},
                new Departments(){department="outdoor",sales=360,day="Monday"},
                new Departments(){department="carpentry",sales=525,day="Friday"},
                new Departments(){department="steelwork",sales=546,day="Tuesday"},
                new Departments(){department="outdoor",sales=152,day="Saturday"},
                new Departments(){department="hardware",sales=745,day="Wednesday"},
                new Departments(){department="electronics",sales=320,day="Thursday"},
                
            };
            MostProfitableDepartment sut = new MostProfitableDepartment();
            var x = sut.MostProfit(obj);
            
            var expected = "hardware";
            Assert.Equal(expected,x);




        }
           [Fact]
        public void ShouldreturnMostProfitableDepartmentAgain()
        {
            var obj =new List<Departments>()
            {
                new Departments(){department="electronics",sales=200,day="Monday"},
                new Departments(){department="outdoor",sales=150,day="Tuesday"},
                new Departments(){department="carpentry",sales=360,day="Wednesday"},
                new Departments(){department="steelwork",sales=740,day="Thursday"},
                new Departments(){department="outdoor",sales=450,day="Friday"},
                new Departments(){department="electronics",sales=874,day="Tuesday"},
                new Departments(){department="electronics",sales=123,day="Thursday"},
                new Departments(){department="electronics",sales=652,day="Friday"},
                new Departments(){department="outdoor",sales=360,day="Monday"},
                new Departments(){department="carpentry",sales=525,day="Friday"},
                new Departments(){department="steelwork",sales=546,day="Tuesday"},
                new Departments(){department="outdoor",sales=152,day="Saturday"},
                new Departments(){department="hardware",sales=745,day="Wednesday"},
                new Departments(){department="electronics",sales=320,day="Thursday"},
                
            };
            MostProfitableDepartment sut = new MostProfitableDepartment();
            var x = sut.MostProfit(obj);
            
            var expected = "electronics";
            Assert.Equal(expected,x);




        }
    }
}

using System;
using Xunit;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace BootcampFunctions.Test
{
    public class ShouldbeOver20
    {
        [Fact]
        public void ShouldReturnItemsOver20()
        {
            var items = new List<Fruit>()
            {
                new Fruit(){qty=25,name="Apple"},
                new Fruit(){qty=21,name="Pineapple"},
                new Fruit(){qty=16,name="jackfruit"},
            


            };
            var ItemsExpected = new List<Fruit>()
            {
                new Fruit(){qty=25,name="Apple"},
                new Fruit(){qty=21,name="Pineapple"},

            };
          ItemsOver20 sut = new ItemsOver20();
        
          var obj2Str = JsonConvert.SerializeObject(ItemsExpected);
        var x = sut.itemsOver20(items);
         var obj1Str = JsonConvert.SerializeObject(x);
         Assert.Equal(obj1Str,obj1Str);


            
        

        }
             [Fact]
        public void ShouldReturnItemsOver20Again()
        {
            var items = new List<Fruit>()
            {
                new Fruit(){qty=25,name="Apple"},
                new Fruit(){qty=19,name="Pineapple"},
                new Fruit(){qty=16,name="Jackfruit"},
                new Fruit(){qty=36,name ="Strawberry"},
            


            };
            var ItemsExpected = new List<Fruit>();
            
                foreach (var item in items)
            {
                if(item.qty>20)
                {
                    ItemsExpected.Add(item);

                }
            }


            
            //{
            //    new Fruit(){qty=25,name="Apple"},
            //    new Fruit(){qty=36,name="Strawberry"},

            //};
            
          ItemsOver20 sut = new ItemsOver20();
        
          var obj2Str = JsonConvert.SerializeObject(ItemsExpected);
        var x = sut.itemsOver20(items);
         var obj1Str = JsonConvert.SerializeObject(x);
         Assert.Equal(obj1Str,obj1Str);


            
        

        }
    }
}

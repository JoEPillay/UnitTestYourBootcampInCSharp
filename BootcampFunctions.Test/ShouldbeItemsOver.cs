using System;
using Xunit;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace BootcampFunctions.Test
{
    public class ShouldbeItemsOver
    {
        [Fact]
        public void ShouldReturnItemsOverInput()
        {
             ItemsOver sut =new ItemsOver();
        var items1 = new List<Fruit>()
            {
                new Fruit(){qty=27,name="Apple"},
                new Fruit(){qty=21,name="Pineapple"},
                new Fruit(){qty=16,name="Jackfruit"},
                new Fruit(){qty=36,name="Johnfruit"},
                new Fruit(){qty=41,name="Pear"},
            


            };
            var ExpectedItems = new List<Fruit>();
            
                foreach (var item in items1)
                {
                    if (item.qty>25)
                    {
                        ExpectedItems.Add(item);
                    }
                    
                }
                
       
        var x = sut.itemsOver(items1,25);
        var obj1Str = JsonConvert.SerializeObject(x);
        var obj3Str = JsonConvert.SerializeObject(ExpectedItems);
        Assert.Equal(obj3Str,obj1Str);
        Console.WriteLine(obj1Str);

           
        }
         [Fact]
        public void ShouldReturnItemsOverInputAgain()
        {
             ItemsOver sut =new ItemsOver();
        var items1 = new List<Fruit>()
            {
                new Fruit(){qty=35,name="Orange"},
                new Fruit(){qty=20,name="Apple"},
                new Fruit(){qty=21,name="Pineapple"},
                new Fruit(){qty=16,name="Jackfruit"},
                new Fruit(){qty=3,name="Johnfruit"},
                new Fruit(){qty=41,name="Pear"},
            


            };
            var ExpectedItems = new List<Fruit>();
            
                foreach (var item in items1)
                {
                    if (item.qty>20)
                    {
                        ExpectedItems.Add(item);
                    }
                    
                }
                
       
        var x = sut.itemsOver(items1,20);
        var obj1Str = JsonConvert.SerializeObject(x);
        var obj3Str = JsonConvert.SerializeObject(ExpectedItems);
        Assert.Equal(obj3Str,obj1Str);
        Console.WriteLine(obj1Str);

           
        }

        }
    }


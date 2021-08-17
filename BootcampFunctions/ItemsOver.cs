using System;
using System.Collections.Generic;

namespace BootcampFunctions
{
    public class ItemsOver
    {
        
        public List<Fruit>itemsOver(List<Fruit> ObjList, int quan)
        {
            
            
            var NewobjList= new List<Fruit>();
            foreach (var fruit in ObjList)
            {
                if (fruit.qty>quan)
                {
                    NewobjList.Add(fruit);
                }
            }
            return NewobjList;
        }

    }
}

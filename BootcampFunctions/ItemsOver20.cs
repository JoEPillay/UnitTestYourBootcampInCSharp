using System;
using System.Collections.Generic;
namespace BootcampFunctions
{
    public class ItemsOver20
    {
        public List<Fruit>itemsOver20(List<Fruit> ObjList )
        {
            
            
            var NewobjList= new List<Fruit>();
            foreach (var fruit in ObjList)
            {
                if (fruit.qty>20)
                {
                    NewobjList.Add(fruit);
                }
            }
            return NewobjList;
        }
    }
}

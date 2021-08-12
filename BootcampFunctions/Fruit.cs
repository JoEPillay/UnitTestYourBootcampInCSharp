using System;

namespace BootcampFunctions
{
    public class Fruit
    {

        public Fruit(int qty, string name)
        {
            this.qty = qty;
            this.name = name;

        }
      
        public int qty { get; set; }
        public string name { get; set; }

    }

}

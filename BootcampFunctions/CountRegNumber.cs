using System;

namespace BootcampFunctions
{ 
    public class CountRegNumber
    {
        public int RegCount(string reg)
        {
        int result = reg.Split(",").Length;

            return result;

            
        }

    }
}

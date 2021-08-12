using System;

namespace BootcampFunctions
{
     public class RegCheck
    {
        public static bool Reg_check(string reg,string area)
        {
            bool result = reg.StartsWith(area);
            
            return result;

        }
    }
}

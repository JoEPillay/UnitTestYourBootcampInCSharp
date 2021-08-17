using System;

namespace BootcampFunctions
{
    public class IsFrom_Bellville
    {
          public static bool Isfrom(string reg)
        {
            bool result= reg.StartsWith("CY");

            return result;

        }
    }
}

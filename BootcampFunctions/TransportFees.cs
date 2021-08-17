using System;

namespace BootcampFunctions
{ 
    public class TransportFees
    {
         public static string transportFee(string time)
        {
            if (time == "morning")
            {
                return "R20";

            }
            else if (time == "afternoon")
            {
                return "R10";

            }
            else if (time == "nightshift")
            {
                return "free";

            }
            else 
            {
                return "enter valid input";
            }

        }


    }
}

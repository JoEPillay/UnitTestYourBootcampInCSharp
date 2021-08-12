using System;

namespace BootcampFunctions
{ 
    public class YearsAgo
    {
        public static int Yearsago(int past)
        { 
            int current= int.Parse(DateTime.Now.ToString("yyyy"));
            return (past-current);

        }
    }
}

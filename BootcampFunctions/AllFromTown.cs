using System;
using System.Collections;

namespace BootcampFunctions
{
       public class AllFromTown
    {
          public static string CountAllFromTown(string reg, string area)
        {
            
           ArrayList newList = new ArrayList();
            string [] splitlist = reg.Split(',');

           foreach( string word in splitlist )
            {
               string final= word.Trim();
                if (final.StartsWith(area))
                {
                    newList.Add(final);
                    

                }
            }

           //Console.WriteLine(newList[0].ToString());
           // Console.ReadKey();
            return newList.ToString();
            
           // return splitlist.ToString();

        }
    }
}

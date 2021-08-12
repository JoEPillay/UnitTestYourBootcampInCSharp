using System;
using System.Collections;

namespace BootcampFunctions
{
    public class AllForPaarl
    {
 public static string AllPaarl(string reg)
        {
            
           ArrayList newList = new ArrayList();
            string [] splitlist = reg.Split(',');

           foreach( string word in splitlist )
            {
               string final= word.Trim();
                if (final.StartsWith("CJ"))
                {
                    newList.Add(final);
                    

                }
            }

            Console.WriteLine(newList[0].ToString());
            Console.ReadKey();
            return newList.ToString();
    }

    }
}

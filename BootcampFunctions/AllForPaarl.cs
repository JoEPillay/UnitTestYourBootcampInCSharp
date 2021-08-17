using System;
using System.Collections;

namespace BootcampFunctions
{
    public class AllForPaarl
    {
 public static string AllPaarl(string reg,int pos)
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

            return newList[pos].ToString();
    }

    }
}

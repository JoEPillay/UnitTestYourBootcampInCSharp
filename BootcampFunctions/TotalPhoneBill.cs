using System;

namespace BootcampFunctions
{
    public class TotalPhoneBill
    {
        		public static string PhoneBill(string bill)
		{
		  //ArrayList newList = new ArrayList();
            string [] splitlist = bill.Split(',');
            double count=0;
   var i=0;
   while(i<splitlist.Length)
   {
     string final= splitlist[i].Trim();
     if(final=="call")
     {
       
       count+= 2.75;
       i++;
     }
     
     else if(final=="sms")
     {
       count+=0.65;
     i++;
     }
     
     
     
     
   }
  var x= count;
  
  return ($"R{x}");
		  
		}
    }
}

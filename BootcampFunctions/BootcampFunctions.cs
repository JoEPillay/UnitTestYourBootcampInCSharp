using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;

namespace BootcampFunctions
{
    public class Greet
    {
        public static string SayHi(string name)
        { 
            return ($"hello, {name}!");
            

        }

    }
    public class IsFrom_Bellville
    {
        public static bool Isfrom(string reg)
        {
            bool result= reg.StartsWith("CY");

            return result;

        }
    }
    public class RegCheck
    {
        public static bool Reg_check(string reg,string area)
        {
            bool result = reg.StartsWith(area);
            
            return result;

        }
    }
    public class CountRegNumber
    {
        public int RegCount(string reg)
        {
        int result = reg.Split(",").Length;

            return result;

            
        }

    }
    public class IsWeekDay
    {
        public static bool WhatDay(string day)
        {
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                return true;     
            }
            return false;
        }
    }
    public class YearsAgo
    {
        public static int Yearsago(int past)
        { 
            int current= int.Parse(DateTime.Now.ToString("yyyy"));
            return (past-current);

        }
    }
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
    public class FromWhere
    {
    public static string fromWhere(string area)

        {
        if(area=="CY")
   {
   
   return "Bellville";
   }
        else if(area== "CJ")
   {
   
   return "Paarl";
   }
        else if(area=="CA")
   {
   
   return "Cape Town";
   }
        else
  {
  
  return "Some other place!";
  }

        }
    }

    public class FindItemsOver20
    {
        public int qty {get;set;}
        public string name { get; set; }
      
      public static void ItemsOver20()
      {
          string JsonString = 
    ;

      }


    }
    
}


    




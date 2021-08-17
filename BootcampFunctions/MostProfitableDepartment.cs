using System;
using System.Collections.Generic;
namespace BootcampFunctions
{
    public class MostProfitableDepartment
    {
        public string MostProfit(List<Departments>ObjList)
        {
            int highestSale =0;
            string ProDepartment ="";
            foreach (var item in ObjList)
            {
                if(item.sales>=highestSale)
                {
                    highestSale=item.sales;
                    ProDepartment =item.department;
                }
                
            }
  
  return ProDepartment;
  
}



        }
    }

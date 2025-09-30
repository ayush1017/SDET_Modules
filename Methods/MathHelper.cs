using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class MathHelper
    {
        public static int Square(int number)
        {
            return number * number;
        }

        //Method Overlosding 
        public string PayType(string title)
        {
            if (title == "Manager")
            {
                return "Salary";
            }
            else if (title == "Staff")
            {
                return "Hourly";
            }
            return "Hourly";
            
            
        }
        public string PayType(int id)
        {
            if (id == 123455)
            {
                return "Salary";
            }
            else if (id == 40071)
            {
                return "Hourly";
            }
            return "Hourly";


        }


    }
}

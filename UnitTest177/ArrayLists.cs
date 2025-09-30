using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest177
{
    internal class ArrayLists
    {
        
       
        public static int Summation()
        {
            int[] arr = { 1, 2, 3, 4 };
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }

        public static int List_Ops()
        {
            ArrayList list = new ArrayList();
            list.Add("Someday");
            list.Add(2);
            list.Add(3);
            list.Add(13.5);
            list.Add("red");
            list.Add(99);
            list.Add(8);
            list.Add("6");
            list.Add("MeatBalls");
            list.Add(18M);
            list.Add("pieces");
            list.Add("14");

            List<int> ls = new List<int>();
            int sum=0;
            foreach (var item in list)
            {
                if (item is string)
                {
                    continue;


                }
                else if (item is int i)
                {
                    {
                        ls.Add(i);
                    }
                }
               
                
              
               
            }
            foreach (int i in ls)
            {
                sum += i;
            }
            return sum;
        }
        
    }
}

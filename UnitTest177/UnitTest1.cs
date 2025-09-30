using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections;
namespace UnitTest177
{
    
    [TestClass]
    [TestCategory("Testing_ArrayList")]
    public class UnitTest1
    {
      
        [TestMethod]
        public void TestMethod1()
        {
            int sum = UnitTest177.ArrayLists.Summation();
            Assert.AreEqual(10, sum);
            Console.WriteLine($"Yes this is the main thing and the answer is {sum}");

        }
        [TestMethod]
        public void TestMethod2()
        {
            int num;
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Check(num));

        }

        public int Check(int num)
        {
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (num == i)
                {
                    count++;
                }
                else
                {
                    count= -1;
                }
            }
            return count;
        }
        [TestMethod]
        public void TestMethod3()
        {
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add(4);
            list.Add(7);
            list.Add(9);

            Console.WriteLine("Capacity {0}", list.Capacity);
            Console.WriteLine("Count: {0}", list.Count);

            Console.Write("Content: ");
            foreach(int i in list)
            {
                Console.Write(i+ " ");

            }
            Console.WriteLine();
            list.Sort();
            Console.Write("Sorted List :");
            foreach(int i in list)
            {
                Console.Write(i+ " ");
            }

        }
        [TestMethod]
        public void List_Exam()
        {
            int sum = UnitTest177.ArrayLists.List_Ops();
            Assert.AreEqual(sum, sum);
            Console.WriteLine(sum);
        }
      


    }
}

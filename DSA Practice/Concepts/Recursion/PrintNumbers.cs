using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Concepts.Recursion
{
    class PrintNumbers
    {
        public static void PrintData(int n)
        {
           if(n==0)
            {
                return;
            }
            Console.WriteLine(n);
            PrintData(n - 1);
            
        }

        public static int Sum(int n)
        {
            if (n==0)
            {
                return 0;
            }
            return n + Sum(n - 1);
        }
        //public static void Main()
        //{
        //   // PrintData(5);
        //    int result = Sum(5);
        //    Console.WriteLine(result);
        //}
    }
}

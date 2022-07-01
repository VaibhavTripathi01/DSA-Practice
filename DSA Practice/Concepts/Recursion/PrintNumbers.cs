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

        public static int PrinttNumbers(int n,int sum)
        {
            if(n==0)
            {
                return sum;
            }          
            sum += n;
           return PrinttNumbers(n - 1,sum);
             
        }

        //public static void Main()
        //{
        //    // PrintData(5);
        //    //int result = Sum(5);
        //    //Console.WriteLine(result);
        //    int sum=PrinttNumbers(4,0);
        //    Console.WriteLine(sum);
        //}                                                                

              

    }
}

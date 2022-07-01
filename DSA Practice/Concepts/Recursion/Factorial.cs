using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Concepts.Recursion
{
     class Factorial
    {
        public static void Fact(int n,int result=1)
        {
            if(n==1)
            {
                Console.WriteLine(result);
                return;
            }
            result = result * n;
            Fact(n - 1, result);
        }

        public static int Factorials(int n)
        {
            if(n==1 || n==0)
            {
                return 1;
            }
            int nm=Factorials(n-1);
            n = n * nm;
            return n;
        }

        //public static void Main()
        //{
        //    int a=Factorials(5);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Concepts.Recursion
{
    class Fibbonacci
    {
        //Iterative approach
        public static void Fibb(int n=10)
        {
            int first = 1;
            int second = 1;
            int third = 0;
            Console.Write(first+","+ second);
            for(int i=2; i<n; i++)
            {
                third = first + second;
                first = second;
                second= third;
                Console.Write(","+third);
            }
        }
        //Recursive Approach
        public static void RecursiveFibb(int n=10)
        {

        }

        //public static void Main()
        //{
        //    Fibb(15);
        //}
    }
}

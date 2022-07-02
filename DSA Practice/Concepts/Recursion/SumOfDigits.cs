using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Concepts.Recursion
{
    class SumOfDigits
    {
        public static void Digits(int digits,int sum=0)
        {
            if(digits == 0)
            {
                Console.WriteLine(sum);
                return;

            }
            int num = digits % 10;
            digits /= 10;
            sum += num;
            Digits(digits,sum);

        }

        public static int SumDigits(int n)
        {
            if (n==0)
            {
                return 0;
            }
              return SumDigits(n / 10) + (n % 10);
        }


        //public static void Main ()
        //{
        //    //Digits(1111);
        //    int sum=SumDigits(1234);
        //}
    }
}

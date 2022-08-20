using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions_Array
{
     class HappyNumber
    {
        public static int HappyNumbers(int num,int squareSum=0)
        {
            int square = 0;
            if(squareSum==1)
            {
                return 1;
            }
            //123
            //12
            while(num!=0)
            {
                square =square+( (num % 10)* (num % 10));
                num=num/10;
            }
            int sum = 0;
            int test = square;
            while (test != 0)
            {
                sum =sum+ (test % 10);
                test = test / 10;
            }
            return HappyNumbers(square, sum);
        }
        //public static void Main()
        //{
        //    int result=HappyNumbers(19);
        //}
    }
}

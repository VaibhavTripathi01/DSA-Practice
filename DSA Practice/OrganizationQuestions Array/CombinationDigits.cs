using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class CombinationDigits
    {
        static int CountInfo(char[] array,int len)
        {
            if(len==0 || len==1)
            {
                return 1;
            }
            int count = 0;
            if (array[array.Length-1]>'0')
            {
                count = CountInfo(array, len - 1);
            }
            if (array[len-1]=='1'|| array[len-2]=='2'&& array[len-1]<'7')
            {
                count+=CountInfo(array, len-2);
            }
            return count;
        }
        static int checker(char[] array,int n)
        {
          
            if (n==0 || ( n == 1 && array[0]=='0'))
            {
                return 0;
            }
            return CountInfo(array, n);
        }
    }
}

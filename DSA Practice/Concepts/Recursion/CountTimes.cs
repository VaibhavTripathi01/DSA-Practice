using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Concepts.Recursion
{
    class CountTimes
    {
        public static int Times(int[] arr, int count = 0, int length = 0)
        {
            if (arr.Length - 1 == length)
            {
                return count;
            }
            if (arr[length] == 1)
            {
                count++;
            }
            return Times(arr, count, length + 1);
        }

        //public static void Main()
        //{
        //    int [] arr = { 2, 3, 4, 5, 6, 1, 1, 1, 1, 1, 4 };
        //    int times = Times(arr);
        //}
    }
}

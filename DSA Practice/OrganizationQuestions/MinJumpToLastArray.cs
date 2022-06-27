using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class MinJumpToLastArray
    {

        public static int JumptoLast(int[] arr)
        {
            int count = 0;
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int jumpValue = arr[i];
                if (arr[i] < arr.Length)
                {
                    i = jumpValue;
                    
                    count++;
                }
            }
           
            return count;
        }
        //public static void Main()
        //{
        //    int[] arr = { 1, 4, 3, 2, 6, 7 };
        //    JumptoLast(arr);
        //}
    }
}

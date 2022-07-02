using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions_Array
{
    internal class ReverseArray
    {
        public static int [] ReverseOurArray(int[] array)
        {
            int last=array.Length-1;
            for(int i=0; i<array.Length/2; i++)
            {
                int temp = array[last];
                array[last] = array[i];
                array[i] = temp;
                last--;
            }
            return array;
        }
        //public static void Main()
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6 };
        //    ReverseOurArray(arr);
        //}
    }
}

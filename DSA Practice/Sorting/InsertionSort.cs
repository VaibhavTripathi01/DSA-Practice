using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Sorting
{
    class InsertionSort
    {
        public static int[] InsertionSorting(int[] array)
        {
           for(int i=1;i<array.Length;i++)
            {
                //1st elem sorted
                int j = i - 1;
                int value = array[i];
                while(j>=0 && array[j]>value)
                {
                    array[j+1]=array[j];
                    j--;
                }
                array[j + 1] = value;
            }
            

            return array;
        }
        //public static void Main()
        //{
        //    int[] arr = { 7, 8, 99, 5, 8, 1, 0, 7 };
        //    InsertionSorting(arr);
        //}
        
    }
}

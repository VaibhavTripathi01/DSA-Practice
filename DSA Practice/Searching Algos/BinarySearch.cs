using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Searching_Algos
{
    class BinarySearch
    {
        public static int BinarySearchAlgo(int[] array,int key)
        {
            //int middle = array.Length / 2;
            int min = 0;
            int max = array.Length - 1;

            while(min<=max)
            {
                int mid = (min + max) / 2;
                if (key == array[mid])
                {
                    return mid+1;
                }
               // else if (key < array[])

            }

            return 0;
        }





    }
}

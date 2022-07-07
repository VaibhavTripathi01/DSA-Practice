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
            int start = 0;
            int high = array.Length- 1;
            while(start<=high)
            {
                int middle = (high+start) / 2;
                if (array[middle]==key)
                {
                    return middle;
                }
                if (key < array[middle])
                {
                    high = middle-1;
                }
                else if(array[middle]<key)
                {
                    start = middle+1;
                }
            }

            return -1;


        }

        public static int BinarySearchRecursive(int[] arr, int key,int low,int high)
        {
            int middle = (low + high) / 2;
            if (arr[middle] ==key)
            {
                return (middle);
            }
            if(arr[middle] >key)
            {
                high = (middle) - 1;
            }
            else if(arr[middle] < key)
            {
                low = (middle) + 1;
            }
            return BinarySearchRecursive(arr, key, low, high);
        }


        //public static void Main()
        //{
        //    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    //BinarySearchAlgo(array, 13);
        //    int result=BinarySearchRecursive(array, 3, 0, array.Length-1);
        //}





    }
}

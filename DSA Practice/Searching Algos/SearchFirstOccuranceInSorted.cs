using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Searching_Algos
{
    class SearchFirstOccuranceInSorted
    {
        //SearchFirst Oc
        public static int BinarySearching(int[] array,int start,int end,int key)
        {
            int middle = (start + end) / 2;
            if(start>end)
            {
                return -1;
            }
            if (array[middle]==key && array[middle - 1] != key)
            {
                return middle;
            }
            if (array[middle] == key && array[middle - 1] == key)
            {
                return BinarySearching(array, start, middle-1, key);
            }

            if (array[middle]>key)
            {
                return BinarySearching(array, start, middle, key);
            }
           

           return BinarySearching(array, middle + 1, end, key);
            
        }



        public static void Main(string[] args)
        {
            int[] array = { 1, 2,2 ,3, 3, 3, 3, 3, 4, 4,4,4,4,4,4,5, 6, 7 };
            int result=BinarySearching(array, 0, array.Length-1, 40);
        }
    }
}

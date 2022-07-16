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
        public static int BinaryS(int[] array,int start,int end,int key)
        {
            int middle = (start + end) / 2;
            if(start>end)
            {
                return -1;
            }
            if (array[middle]==key)
            {
                return middle;
            }
            if (array[middle]>key)
            {
                
                return BinaryS(array, start, middle-1, key);
            }
           
             return BinaryS(array, middle+1, end, key);
            


        }
        //Binary last occurance of the digit

        public static int BinaryLast(int [] arr,int start,int end,int key)
        {
            int middle = (start + end) / 2;
            if(start>end)
            {
                return -1;
            }
            if (arr[middle]==key && arr[middle+1]!=key)
            {
                return middle;
            }
            else if (arr[middle]>key)
            {
                return BinaryLast(arr, start, middle - 1,key);
            }
            else
            {
                return BinaryLast(arr, middle + 1, end, key);
            }
            
        }

        //public static void Main(string[] args)
        //{
        //    int[] array = { 1,2,3,4,5,677,888 };
        //    int[] array2 = { 1,1,1,1,2,3,4,5,6,6,6,6,6,7,8,8,8,9 };
        //    //int result= BinaryS(array, 0, array.Length-1, 5);
        //    int result2 = BinaryLast(array2, 0, array2.Length - 1, 8);
        //}
    }
}

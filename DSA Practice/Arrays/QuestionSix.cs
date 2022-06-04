using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Arrays
{
    public class QuestionSix
    {
        //Pivoted means array is sorted but distorted sequence
        //Input  : arr[] = {5, 6, 7, 8, 9, 10, 1, 2, 3};
        //key = 3
        //Output : Found at index 8

        //Input  : arr[] = {5, 6, 7, 3, 4};
        // key = 30
        //Output : Not found

      

        public int BinarySearch(int[] arr,int low,int high,int key)
        {
           
            if(high<low)
            {
                return -1;
            }
            int middle=(low+high)/2;

            if (key == arr[middle])
            {
                return middle;
            }
            if (key > arr[middle])
            {
                BinarySearch(arr, (middle + 1), high, key);
            }

            return BinarySearch(arr, low,(middle - 1), key); ;
        }

        public int pivotElementIndex(int[] arr, int low,int high)
        {
            if(high<low)
            {
                return -1;
            }
            if(high==low)
            {
                return low;
            }
            int mid=(low+high)/2;
            if (mid<high && arr[mid] > arr[mid+1])
            {
                return mid;
            }
            if(mid>low && arr[mid] < arr[mid-1])
            {
                return mid - 1;
            }
            if (arr[low] >= arr[mid])
            {
                return pivotElementIndex(arr, low, mid - 1);
            }
            return pivotElementIndex(arr,mid+1,high);

        }
        public int SearchIndex(int[] arr,int n,int key)
        {
            int pivot = pivotElementIndex(arr, 0, n - 1);
            if(pivot==-1)
            {
                //Means array is sorted
                return BinarySearch(arr, 0, n - 1, key);
            }
            if (arr[pivot]==key)
            {
                //pivot is searched index
                return pivot;
            }
            if (arr[pivot]<=key)
            {
                return BinarySearch(arr, 0, pivot-1, key);
            }
            return BinarySearch(arr, pivot + 1, n - 1, key);
        }

        public static void Main()
        {
            QuestionSix obj = new QuestionSix();

            // Let us search 3 in below array
            int[] arr1 = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            int n = arr1.Length;
            int key = 2;
            Console.Write("Index of the element is : "
                          + obj.SearchIndex(arr1, n, key));
        }

    }
}

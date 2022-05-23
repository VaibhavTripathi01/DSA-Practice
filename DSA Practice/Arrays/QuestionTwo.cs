using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Arrays
{
    class QuestionTwo
    {
        public static int[] ReverseArray(int[] array)
        {
            //Initial Approach 
            //Reersed Array
            int[] reversedArray = new int[array.Length];
            int index = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {

                reversedArray[index] = array[i];
                index += 1;

            }
            return reversedArray;
        }
        public static int[] ReverseSameArray(int[] Array)
        {
            //Revese within same array
            int start = 0;
            int end = Array.Length - 1;
            int middle = end / 2;

            for (int i = start; i <= middle; i++)
            {
                int temp = Array[i];
                Array[i] = Array[end];
                Array[end] = temp;
                end--;
            }


            return Array;
        }



        //public static void Main(string[] args)
        //{
        //    int[] inputArray = { 0, 1 };
        //    ReverseSameArray(inputArray);
        //    foreach (int item in ReverseArray(inputArray))
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}

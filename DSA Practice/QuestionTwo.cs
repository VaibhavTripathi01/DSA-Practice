using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice
{
    class QuestionTwo
    {
        public static int[] ReverseArray(int[] array)
        {
            //Initial Approach 
            //Reersed Array
            int[] reversedArray = new int[array.Length];
            int index = 0;
            for(int i=array.Length-1;i>=0;i--)
            {

                reversedArray[index] = array[i];
                index += 1;
                

            }
            return reversedArray;
        }
        //public static void Main(string[] args)
        //{
        //    int[] inputArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        //    foreach (int item in ReverseArray(inputArray))
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}

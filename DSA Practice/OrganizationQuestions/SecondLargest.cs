using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class SecondLargest
    {
        public  int SecondLarge(int[] array)
        {
            Array.Sort(array);
            int second = array[array.Length - 2];

            return second;
        }
        public  int second(int[] array)
        {
            int max = array[0];
            for(int i=0;i<array.Length;i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            int secondLargest = 0;
            //Till we found second largest
            for(int i=0;i<array.Length;i++)
            {
                if (secondLargest < array[i] && array[i] != max)
                {
                    secondLargest= array[i];
                }

            }
            return secondLargest;
        }


        //public static void Main()
        //{
        //    int[] array = { 1, 4, 2, 66, 77, 88, 4, 3, 1, 99, 43, 0 };
        //    Console.Write(second(array));
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    public class RemoveDuplicateFromSortedArray
    {
        //Theta n is TC and O(n) is SC
        public static int [] FilteredArray(int[] array)
        {
            int[] tempArray = new int[array.Length];
            tempArray[0] = array[0];
            int count = 1;
            for (int i=1;i<array.Length;i++)
            {
                if(tempArray[count-1] != array[i])
                {
                    
                    tempArray[count] = array[i];
                    count++;
                    
                }
            }

            return tempArray;
        }

        public static int[] EasyCompare(int[] array)
        {
            int count = 1;
            for(int i = 1;i<array.Length;i++)
            {
                if (array[count - 1] != array[i])
                {
                    array[count] = array[i];
                    count++;
                }
                
            }

            return array;
        }

        //public static void Main()
        //{
        //    int[] array = { 1,1,1, 2, 3, 4, 4, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7,7 };
        //    EasyCompare(array);
        //}
    }
}

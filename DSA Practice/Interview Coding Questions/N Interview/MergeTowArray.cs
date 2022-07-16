using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Interview_Coding_Questions.N_Interview
{
    class MergeTowArray
    {
        public static int [] MergeTowArrays(int[] arr1,int[] arr2)
        {
            int total_length = arr1.Length + arr2.Length;
            int[] result = new int[total_length];

            //0,1,2,3,4    0,1,2,3,4,
            //0,1,2,3,4,
            int times = 0;
            int k = 0;
            for(int i=0;i< total_length; i++)
            {
                if(times<arr1.Length)
                {
                    result[i] = arr1[i];
                }
                else
                {
                    result[i]=arr2[k];
                    k++;
                }
                times++;
            }
            return result;
        }

        public static int[] MergeSortedArray(int[] array1,int[] array2)
        {
            int totalLength=array1.Length+ array2.Length;
            int[] result = new int[totalLength];
            int i = 0, j = 0, k = 0;
            while(i<array1.Length && j<array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    result[k]=array1[i];
                    k++;
                    i++;
                }
                else
                {
                    result[k] = array2[j];
                    k++;
                    j++;
                }
            }
            while(i<array1.Length)
            {
                result[k++]=array1[i++];
            }
            while (j < array2.Length)
            {
                result[k++] = array2[j++];
            }
            return result;
        }

        //public static void Main()
        //{
        //    int[] s1 = { 1, 2, 3, 4, 5,89,98 };
        //    int[] s2 = { 2, 3, 4, 5,6,7,8,9,9,9,99,999};
        //    int[] s = { 1, 2, 3, 4, 5, 6, 8, 0, 6, 88, 7, 22, 6, 888 };
        //    MergeSortedArray(s1,s2);
        //    Array.Sort(s);

        //}
    }
}

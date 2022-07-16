using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Sorting
{
    class SelectioSorting
    {
        public static int[] Sel(int[] array)
        {
            int subArea = -1;
            int n = array.Length;
            int start = 0;
            for(int i=0;i<n;i++)
            {
                
                int minIndex = i;
                for(int j=i+1;j<n-1;j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp=array[start];
                array[start] = array[minIndex];
                array[minIndex] = temp;
                start++;

            }
            




            return array;
        }
        //public static void Main()
        //{
        //    int[] s1 = { 100, 200, 4, 5, 89, 98,300,500 };
        //    Sel(s1);
        //}
    }
}

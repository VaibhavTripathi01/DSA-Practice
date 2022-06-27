using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class MissingNumber
    {
        //ArraySort
        public static int[] InsertSorting(int[] array)
        {

            
            int n=array.Length;
            for(int i=1;i<n;i++)
            {
                int j = i - 1;
                int key=array[i];
                while(j>0 && array[j]>key)
                {
                    array[j+1] = array[j];
                    j--;
                }
                array[j+1]=key;
            }

            return array;
        }

        public static int[] duplicates(int[] arr, int n)
        {
            int[] Dup;
            
            HashSet<int> MySet = new HashSet<int>();
            Array.Sort(arr);
            int index = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    MySet.Add(arr[i]);

                }
            }
            //Find length of HashSet
            int c = 0;
            int[] DuplicateList = new int[MySet.Count];
            foreach (int i in MySet)
            {

                DuplicateList[c] = i;
                c++;
            }


            if (c == 0)
            {
                DuplicateList[c] = -1;
                return DuplicateList;
            }
            return DuplicateList;
            //Your code here
        }
        //public static void Main()
        //{
        //    int[] array = { 1,2,3,4,3,3,3,3,3};
        //    duplicates(array,9);
        //}

    }
}

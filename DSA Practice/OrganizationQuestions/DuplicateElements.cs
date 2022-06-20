using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
     class DuplicateElements
    {
        public static void PrintDupl(int[] array)
        {
            HashSet<int> odd = new HashSet<int>();
            for (int i=0;i<array.Length-1;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if (array[i] == array[j])
                    {
                        odd.Add(array[i]);
                       
                    }
                }

            }
            foreach (int i in odd)
            {
                Console.WriteLine(i);
            }
        }

        //public static void Main()
        //{
        //    int[] array = { 1, 2, 3, 2, 3, 2, 3, 2, 3 };
        //    PrintDupl(array);
        //}
    }
}
//HashSet<int> set=new HashSet<int>();
// HashSet<int> odd = new HashSet<int>();
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class MaxConsecutive
    {
        public static int MaxConsecutives(int[] array, int number)
            {
            int maxones = 0;
            int times = 0;
            for (int i=0;i<array.Length;i++)
            {
                if (array[i] == number)
                {
                    maxones++;
                    if (maxones > times && maxones>1)
                    {
                        times = maxones;

                    }
                }
                else
                {
                    maxones = 0;
                }
            }
               return times;
            }

        //public static void Main()
        //{
        //    int[] array = { 1, 2, 3, 4, 1, 1, 1, 1, 1, 2, 3, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,23,2,2,1,1,1 };
        //    MaxConsecutives(array, 1);
        //}

    }
}

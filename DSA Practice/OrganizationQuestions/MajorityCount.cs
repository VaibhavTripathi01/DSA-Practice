using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
     class MajorityCount
    {
        public int majorityElement(int[] a, int size)
        {
            //code here
            int majorityElement = 0;
            int majorityElemCount = 0;
            for (int i = 0; i < size; i++)
            {
                int initialNumber = a[i];
                int count = 0;
                for (int j = 0; j < size; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;

                    }
                }
                if (count > majorityElemCount)
                {
                    majorityElemCount = count;
                    majorityElement = a[i];
                }
            }

            if (majorityElemCount > size / 2)
            {
                return majorityElement;
            }

            else
            {
                return -1;
            }

        }

        //public static void Main()
        //{
        //    int[] array = { 0, 1, 2, 3, 4, 3, 2, 3 };
        //    int count = Majority(array);
        //    Console.WriteLine(count);
        //}
    }
}

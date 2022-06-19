using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
     class MajorityCount
    {
        public static int Majority(int[] array)
        {
            int n = array.Length;
            int maxCount = 0;
            int value = 0;
            for(int i=0;i<n;i++)
            {
                int checkElement = array[i];
                int elementCount = 0;
                for(int j=0;j<n;j++)
                {
                    if (checkElement == array[j])
                    {
                        elementCount++;
                    }
                }
                if(elementCount>n/2)
                {
                    maxCount = elementCount;
                    value = checkElement;
                }
            }
            if(maxCount>0)
            {
                Console.WriteLine("Max Count is",maxCount);
            }


            return value;
        }
        //public static void Main()
        //{
        //    int[] array = { 0, 1, 2, 3, 4, 3, 2, 3 };
        //    int count = Majority(array);
        //    Console.WriteLine(count);
        //}
     }
}

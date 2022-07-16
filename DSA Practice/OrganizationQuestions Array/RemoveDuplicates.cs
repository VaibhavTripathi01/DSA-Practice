using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions_Array
{
    class RemoveDuplicates
    {
        public static int Remover(int[] array)
        {
            int times = 1;
            int firstElem = array[0];
            int firstIndex = -1;
            for(int i=1;i<array.Length;i++)
            {
                if (array[i] != array[i+1])
                {
                    times++;
                }
                else
                {

                }
            }

            return 0;
        }
    }
}

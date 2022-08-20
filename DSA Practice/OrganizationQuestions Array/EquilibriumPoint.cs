using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions_Array
{
     class EquilibriumPoint
    {
        public static int PivotIndex(int[] nums)
        {
            //pivot or equilibrium point
            int sum = 0, subSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                subSum = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    subSum += nums[j];

                }
                if (subSum == sum)
                {
                    return i + 1;
                }
            }
            return -1;

        }

    //    public static void Main()
    //    {
    //        int[] array = { 1, 7, 3, 6, 5, 6 };
    //        int index=PivotIndex(array);
    //}
    }
}

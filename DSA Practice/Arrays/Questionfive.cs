using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Arrays
{
    public class Questionfive
    {
//        Input : arr[] = {7, 3, 2, 4, 9, 12, 56} , m = 3 
//        Output: Minimum Difference is 2 
//        Explanation:
//        We have seven packets of chocolates and
//        we need to pick three packets for 3 students
//        If we pick 2, 3 and 4, we get the minimum
//        difference between maximum and minimum packet
//        sizes.
        public static int ChocolateDistributionProblem(int[] nums, int students)
        {
            //Initial Condition
           


            int min_diff = 0;
            for(int i=0;i<nums.Length;i++)
            {
                int first = nums[i];
                for(int j=0;j<nums.Length;j++)
                {
                    int temp;
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            min_diff = nums[nums.Length-1];
            //Array is sorted Now
            if (nums.Length == students)
            {
                return nums[nums.Length - 1] - nums[0];
            }
            else
            {
                //Search index of students
                for (int i = 0; i < nums.Length-students+1; i++)
                {
                    int currentDiff = nums[i + students-1] - nums[i];
                    if(currentDiff<min_diff)
                    {
                        min_diff = currentDiff;
                    }
                }
            }


            return min_diff;
        }

        //public static void Main(string[] args)
        //{
        //int[] array = {12, 4, 7, 9, 2, 23, 25, 41,30, 40, 28, 42, 30, 44, 48,43, 50};
        //    int[] array2 = { 7, 3, 2, 4, 9, 12, 56 };
        //ChocolateDistributionProblem(array2, 3);

        //}
    }
}

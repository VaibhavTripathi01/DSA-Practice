using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Arrays
{
    public class QuestionThree
    {
        //Kadane Algorithm
        //SubArray is contiguous array
        //Run a loop for i from 0 to n – 1, where n is the size of the array.
        //Now, we will run a nested loop for j from i to n – 1 and add the value of the element at index j to a variable currentMax.
        //Lastly, for every subarray, we will check if the currentMax is the maximum sum of all contiguous subarrays
        public static int MaxSubArray(int[] nums)
        {
          int maxValue = nums[0];
          if(nums.Length==1)
            {
                return nums[0];
            }
            else
            {
                for(int i=0;i<nums.Length;i++)
                {
                    int currentmax = 0;
                    for(int j=i;j<nums.Length;j++)
                    {
                        currentmax += nums[j];
                        if(maxValue<currentmax)
                        {
                            maxValue = currentmax;
                           
                        }
                    }
                }
            }


            return maxValue;
        }
        //public static void Main(string[] Args)
        //{
        //    int[] inputArray = {-2,-1,3,100};
        //    Console.Write(MaxSubArray(inputArray));
        //}

    }
}

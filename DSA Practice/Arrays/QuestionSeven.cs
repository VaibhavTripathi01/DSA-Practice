using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Arrays
{
    public class QuestionSeven
    {
        public static int [] permutations(int[] nums)
        {
            int totalCombinations=1;
            for(int i=nums.Length;i>0;i--)
            {
                totalCombinations = totalCombinations * i;
            }
            
            return nums;
        }

        //public static void Main()
        //{
        //    int[] array = { 3, 2, 1 };
        //    permutations(array);
        //}
    }
}

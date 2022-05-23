using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Arrays
{
    class QuestionFour
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 1)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    int initialValue = nums[i];
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (initialValue == nums[j])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //public static void Main()
        //{
        //    int[] array = { 0, 2, 3, 4, 5, 6, 5, 6 };
        //    Console.WriteLine( ContainsDuplicate(array));
        //}
    }
}

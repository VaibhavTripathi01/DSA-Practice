using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.HackerRank
{
    internal class DiagonalDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDiagonalSum = 0;
            int rightDiagonalSum = 0;
            int leftTravers = arr.Count;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if (i == j)
                    {
                        leftDiagonalSum += arr[i][j];
                    }
                    if (i + j == arr.Count - 1)
                    {
                        rightDiagonalSum += arr[i][j];

                    }
                }
            }
            int result = rightDiagonalSum - leftDiagonalSum;
            if (result < 0)
            {
                return result * -1;
            }
            else
            {
                return result;
            }
        }
        //public static void Main()
        //{
        //    //diagonalDifference({1,2,3 },{ 1,2,3});
        //}
    }
}

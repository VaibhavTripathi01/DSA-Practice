﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Arrays
{
    public  class QuestionOne
    {
        public static int dataVal(int[] inputArray, int condition = 0)
        {
            int data = inputArray[0];

            switch (condition)
            {
                case 0:
                    for (int i = 1; i < inputArray.Length; i++)
                    {
                        if (data < inputArray[i])
                        {
                            data = inputArray[i];
                        }
                    }
                    break;

                case 1:
                    for (int i = 1; i < inputArray.Length; i++)
                    {
                        if (data > inputArray[i])
                        {
                            data = inputArray[i];
                        }
                    }
                    break;
                default:
                    break;

            }
            return data;

        }

        //public static void Main(String[] Args)
        //{
        //    int[] inputArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        //    int maxVal = dataVal(inputArray);
        //    int minVal = dataVal(inputArray,1);
        //    Console.WriteLine("Max Value in array is {0} and min value is {1}", maxVal,min);
        //}
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Sorting
{
    class InsertionSort
    {
        public static int[] InsertionSorting(int[] array)
        {
            for(int i=1;i<array.Length;i++)
            {
                int key=array[i];
                int j = i - 1;
                while(j>0 && array[j]>key)
                {
                    array[j+1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            return array;
        }
        
    }
}

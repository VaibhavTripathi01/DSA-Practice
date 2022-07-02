using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class ShiftZeros
    {
        public static int[] Swap(int[] array,int from , int to)
        {
            int temp = array[from];
            array[from] = to;
            array[to] = temp;

            return array;
        }
        //O(n)
        public static int [] Shifter(int[]array)
        {
            int countNonZero = 0;
            for (int i=0;i<array.Length;i++)
            {
               
                if (array[i]==0)
                {
                    countNonZero++;
                    int temp = array[countNonZero];
                    array[i] = 0;
                    array[countNonZero] = temp;
                    
                }
               
            }
            return array;
        }

        //testing with O(n2)
        public static int[] ShiftZero(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                
                if(array[i]==0)
                {
                    for(int j=i+1;j<array.Length;j++)
                    {
                        if(array[j]!=0)
                        {
                            //Swap with zero
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                            break;

                        }
                        
                    }
                }
            }
            return array;

            
        }

        //public static void Main()
        //{
        //    int[] array = { 1, 3, 4, 0, 7, 5, 0, 8 ,0};
        //    ShiftZero(array);
        //    Shifter(array);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class LeftRotation
    {
        public static int[] LeftRotator(int[] array,int times)
        {
            for(int i=0;i<times;i++)
            {
               
                for(int j=1;j<array.Length;j++)
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;    
                }
            }

            return array;
        }

        public static int[] LetsRotate(int[] array,int times)
        {
            for(int i=0;i<times;i++)
            {
                for(int j=0;j<array.Length-1;j++)
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1]= temp;

                }
            }
            
            return array;
        }



        //public static void Main()
        //{
        //    int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        //    LetsRotate(array, 4);

        //}
    }
}

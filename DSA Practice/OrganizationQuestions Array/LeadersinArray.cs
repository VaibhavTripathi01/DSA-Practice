using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions_Array
{
    internal class LeadersinArray
    {
        public static string Leaders(int[] array)
        {
            int maxNumber = array[0];
            int maxIndex = -1;
            for(int i=1;i<array.Length;i++)
            {
                if (maxNumber < array[i])
                {
                    maxNumber = array[i];
                    maxIndex = i;
                }
            }
            string result = maxNumber.ToString();
            for(int i=maxIndex+1;i<array.Length;i++)
            {
                int submax = array[i];
                int subindex =-1;
                for(int j=i+1;j<array.Length;j++)
                {
                    if (submax < array[j])
                    {
                        submax = array[j];
                        subindex = j;
                    }
                }
                result += submax.ToString();
                if (subindex > -1)
                {
                    i = subindex;
                }
            }
            return result; 


        }


      


        public static void Main()
        {
           // int [] arr = {7,10,4,3,6,5,2};
           // int[] arr = { 10,20,30 };
            int[] arr = { 30,20,10 };
            Leaders(arr);
        }


    }
}

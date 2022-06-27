using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class Sum_Subsets
    {
        public static bool Subsets(int[] array,int k)
        {
            int requiredSum=0;
            int resultValue = 0;
            for(int i = 0; i < array.Length; i++)
            {
                requiredSum = requiredSum+ array[i];
            }
            resultValue = requiredSum / k;
            if(requiredSum!=resultValue*k)
            {
                return false;
            }
            else
            {
                for(int i=0;i<array.Length;i++)
                {
                    int initial = array[i];
                    int sum = 0;
                    for(int j=i;j<array.Length;j++)
                    {
                        sum += array[j];
                    }
                }
            }


            return true;
        }
        //public static void Main()
        //{

        //}
    }
}

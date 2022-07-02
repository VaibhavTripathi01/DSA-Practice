using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
     class Frequency
    {
        public static string CheckFrequency(string str)
        {
            //Sort String
            char[] strArray = str.ToCharArray();
            Array.Sort(strArray);
            string result = "";
            for(int i=0;i<strArray.Length;i++)
            {
                int countOccurance = 0;
                char check=strArray[i]; 
                for(int j=0;j<strArray.Length;j++)
                {
                    if(check==strArray[j])
                    {
                        countOccurance++;
                        i++;
                    }
                   
                }
                i--;
               
               
                result+=strArray[i].ToString()+countOccurance.ToString();
               
            }


            return result;
        }

        //public static void Main()
        //{
        //    string result=CheckFrequency("abbbbccccddddfffghj");
        //}
    }
}

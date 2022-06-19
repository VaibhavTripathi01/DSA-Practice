using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Strings
{
    public class Question2Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            //Sort both string
            string convertedSortFirst = SortStrings(s);
            string convertedSecond = SortStrings(t);
            if (convertedSortFirst == convertedSecond)
            {
                return true;
            }
            return false;
        }


        public string SortStrings(string str)
        {
            //Can take help of ascii codes
            //Applied Bubble sort
            char[] strArray = str.ToLower().ToCharArray();
            for (int i = 0; i < strArray.Length; i++)
            {
                for (int j = 0; j < strArray.Length; j++)
                {
                    if ((int)strArray[i] > (int)strArray[j])
                    {
                        char temp = strArray[j];
                        strArray[j] = strArray[i];
                        strArray[i] = temp;
                    }
                }
            }

            string output = "";
            for (int k = 0; k < strArray.Length; k++)
            {
                output += strArray[k];
            }
            return output;
        }
        //public static void Main()
        //{
        //    Question2Anagram obj=new Question2Anagram();
        //    Console.WriteLine("Check is anagram: "+obj.IsAnagram("kjsdbnf", "sdfsdf"));
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class BiggestPalindrome
    {
        public static string LongestPalindromes(string s)
        {
            int maxLength = 0;
            string result = "";
            int lastIndex = s.Length - 1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = lastIndex; j > i; j--)
                {
                    string strr = PalindromeCheck(s, i, j);
                    if (strr != "")
                    {
                        if (maxLength < strr.Length)
                        {
                            maxLength = strr.Length;
                            result = strr;
                        }

                    }
                }
               
            }
            return result;

        }
        public static string PalindromeCheck(string str, int start, int end)
        {
            char[] array = str.ToCharArray();
            int last = end;
            int count = 0;
            string subString = "";
            for (int i = start; i< (end - start) / 2; i++)
            {
                if (array[i] == array[last])
                {
                    count++;
                }
            }
            if (count == (end - start) / 2 && count!=0)
            {
                subString = str.Substring(start, end + 1);
                return subString;
            }
            return "";
        }
        //public static void Main()
        //{
        //    LongestPalindromes("ffffffffffffffffgfghhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh");
        //}
    }
}

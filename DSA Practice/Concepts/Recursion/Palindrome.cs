using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Concepts.Recursion
{
     class Palindrome
    {
        public static bool CheckPalindromes(string str,int start,int end)
        {
            if(start>=end)
            {
                return true;
            }
            
            return (str[start]==str[end] && CheckPalindromes(str, start + 1, end - 1));

        }

        //public static void Main()
        //{
        //    bool test = Recurspal("abccca", 0, 5);
        //    Console.WriteLine(test);
        //}

        public static bool Recurspal(string s,int start,int end)
        {
            if(start>=end)
            {
                return true;
            }
            return ((s[start] == s[end]) && Recurspal(s, start + 1, end - 1));
        }
    }
}

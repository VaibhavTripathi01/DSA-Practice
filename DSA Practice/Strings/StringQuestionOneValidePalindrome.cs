using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Strings
{
    public class StringQuestionOneValidePalindrome
    {
        public static string FilteredString(string str)
        {
            string filteredString = "";
            int asciiCode = 0;
            foreach (var data in str)
            {
               
                asciiCode = (int)data;
                if ((asciiCode >= 97 && asciiCode <= 122) || (asciiCode >= 65 && asciiCode <= 90) || (asciiCode>=48 && asciiCode<=57))
                {
                    filteredString = filteredString + data;
                }
            }
            return filteredString;
        }

        public static bool palindromeChecker(string str)
        {
            string filtered = FilteredString(str.ToLower());
            int totalStringLength=filtered.Length;
            int middle = totalStringLength / 2;
            int count = 0;
            for(int i=0; i < middle; i++)
            {
                totalStringLength -= 1;
                if(filtered[i] == filtered[totalStringLength])
                {
                    count++;
                }
            }
            if(count==middle)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        //public static void Main(string[] args)
        //{
        //    string info = "00A man, a plan, a canal:00 Panama";
        //    Console.WriteLine("Is string {0} palindrome {1}", info, palindromeChecker(info));
            
            
        //}
    }
}

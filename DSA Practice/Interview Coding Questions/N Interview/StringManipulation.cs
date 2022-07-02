using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Interview_Coding_Questions.N_Interview
{
    class StringManipulation
    {
       public static string StringReplace(string strr)
        {
            
            char [] chars = strr.ToCharArray();
            string result = "";
            if (strr.Contains("_"))
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == '_')
                    {

                        if (chars[i + 1] != '_')
                        {
                            result += chars[i + 1].ToString().ToUpper();
                            i++;
                        }
                    }
                    else
                    {
                        result += chars[i].ToString();
                    }
                }
            }
            else
            {

            }
            return result;
        }
        //public static void Main()
        //{
        //    string data=StringReplace("jklhjhkl________variable");
        //    Console.Write(data);
        //}

    }
}

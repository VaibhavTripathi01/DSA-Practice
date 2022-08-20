using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Strings
{
     class Q3ValidParenthesis
    {
        public  bool IsSequentialValid(string s)
        {
            char[] ourArray = s.ToCharArray();
            bool checker = false;
            for (int i = 0; i < ourArray.Length - 1; i++)
            {
                int a = (int)ourArray[i];
                int b = (int)ourArray[i + 1];
                if ((int)ourArray[i] == (int)ourArray[i + 1]-2 || (((int)ourArray[i]==40)&& (int)ourArray[i+1] == 41))
                {
                    checker = true;
                    i++;
                }
                else
                { 
                    return false;
                }

            }
            return checker;
        }
      

        public bool CheckBalanced(string str)
        {
            int smallBracketsCount = 0;
            int middleBracketsCount = 0;
            int squareBracketCount = 0;

            char[] strArr = str.ToCharArray();
            int checkIndex = -1;
            for(int i=0;i<strArr.Length;i++)
            {
                if (strArr[i]==')' || strArr[i]==']' || strArr[i]=='}')
                {
                    if(i==0)
                    {
                        return false;
                    }
                    else
                    {
                        checkIndex = i;
                    }
                }
                if(checkIndex>0)
                {

                }
            }
            
           

            return false;
        }

        //public static void Main()
        //{
        //    Console.WriteLine(IsValidClose("[{{}}]"));
        //}
    }
}

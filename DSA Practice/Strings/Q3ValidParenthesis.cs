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
        public  bool IsValidClose(string str)
        {
            char[] pushfilter = { '{', '(', '[' };
            char [] popfilter = { ')', ']', '}' };
            //Create a stack and pop
            Stack ourStack = new Stack();
            int count = 0;
            foreach (var data in str)
            {
                if (pushfilter.Contains(data))
                {
                    count++;
                    ourStack.Push(data);

                }
                else if(popfilter.Contains(data))
                {
                    count--;
                    ourStack.Pop();
                }
            }
            if(count == 0)
            {
                return true;
            }
            return false;
        }
        //public static void Main()
        //{
        //    Console.WriteLine(IsValidClose("[{{}}]"));
        //}
    }
}

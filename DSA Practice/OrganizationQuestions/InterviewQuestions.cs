using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
     class InterviewQuestions
    {
        public int CheckOccurance(string str, char word)
        {
            char[] strarray = str.ToCharArray();
            int count = 0;
            for(int i=0;i<strarray.Length;i++)
            {
                if (strarray[i]==word)
                {
                    count++;
                }
            }

            return count;
        }

        public static void maxTimes(string str)
        {
            int times = 0;
            int maxCount = 0;

            string maxChar="";
            char[] array = str.ToCharArray();
            HashSet<char> ourUniqueSet = new HashSet<char>();
            for(int i=0;i<array.Length;i++)
            {
                ourUniqueSet.Add(array[i]);
            }
            foreach(char c in ourUniqueSet)
            {
                int counter = 0;
                for(int i=0;i<array.Length;i++)
                {
                    if(c==array[i])
                    {
                        counter++;
                    }
                    if(maxCount<counter && counter>1)
                    {
                        maxCount = counter;
                        maxChar=array[i].ToString();
                    }
                }
            }
            Console.Write(maxCount);
            Console.WriteLine(maxChar);
        }

        public static int perfectSquare(int number)
        {
            for(int i=number;i>0;i--)
            {
                int num = (int)Math.Sqrt(i);
                if(num*num==i)
                {
                    return num;
                }
            }
            return 0;
        }

        public static int sumofmax(int[] array)
        {
            int firstmax = array[0];
            int firstIndex = 0;
            for(int i=1;i< array.Length;i++)
            {
                if (firstmax < array[i])
                {
                    firstmax = array[i];
                    firstIndex = i;
                }
            }
            int secondMax = array[firstIndex-1];
            for(int i=0;i<array.Length;i++)
            {
                if (i!=firstIndex && secondMax < array[i] && secondMax!=firstmax)
                {
                    secondMax = array[i];
                }
            }
            return firstmax + secondMax;

        }
        //Needs optimization
        public static void majorityElement(int[] array)
        {
            Dictionary<int, int> Majority = new Dictionary<int, int>();
            for(int i=0;i<array.Length;i++)
            {
                Majority.Add(array[i], 0);
            }
            
        }

        public static string ConvertUpper(string str)
        {
            
            char [] charArr = str.ToCharArray();
            string result = Transform(charArr[0].ToString());
            for(int i=1;i<charArr.Length;i++)
            {
                if (charArr[i]==' ')
                {
                    result += " "+Transform(charArr[i+1].ToString());
                    i++;
                }
                else 
                {
                    result += charArr[i].ToString();
                }

            }
            return result;
        }

        public static string Transform(string str)
        {
            return str.ToUpper();
        }

        public static void Main()
        {
            int[] array = { 1, 2, 3, 44, 100, 21, 32, 200 };
            //maxTimes("jksdhkjsKkkkkk");
            //perfectSquare(55);
            //sumofmax(array);
            ConvertUpper("i want to stay at a safe distance from KK");

        }


    }
}

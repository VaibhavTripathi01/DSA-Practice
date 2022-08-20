using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Stack
{
    class ArrayStack
    {
        public static int[] PushData(int[] data,int value)
        {
            int [] array = new int[data.Length+1];
            Array.Copy(data,array,data.Length);
            array[data.Length] = value;
            return array;
        }
        public static void PrintStack(int[] data)
        {
            for(int i = data.Length-1;i>=0;i--)
            {
                Console.WriteLine(data[i]);
            }
        }
        public static int[] PopElem(int[] data)
        {
            int[] array = new int[data.Length - 1];
            Array.Copy(data,array,array.Length);
            return array;
        }
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            array=PushData(array, 6);
            PrintStack(array);
            array=PopElem(array);
            PrintStack(array);
            array = PopElem(array);
            PrintStack(array);
        }
    }
}

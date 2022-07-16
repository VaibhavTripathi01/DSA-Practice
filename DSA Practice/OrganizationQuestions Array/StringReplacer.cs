using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class StringReplacer
    {
        public static string StringRelacer(string data)
        {
            //convert string to char array
            //jksd_data_slkdjfh
            char[] arr = data.ToCharArray();
            //Array.Copy(arr);
            int[] locations=new int[arr.Length];
            string result = "";
            int count = 0;
            
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == '_')
                {
                    locations[count] = i;
                    count++;
                }
            }
            int traverse = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (i < locations[traverse] )
                {
                    result += arr[i];
                }
                else if(i > locations[traverse + 1])
                {
                    result += arr[i];
                }
               
               
                //if(i> locations[traverse+1])
                //{
                //    traverse++;
                //}
            }

            return result;
        }
        //public static void Main()
        //{
        //    string str = "Helo_jh_oWorld_jhsgdf_kello";
        //    string data= StringRelacer(str);
        
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    //https://practice.geeksforgeeks.org/problems/subarray-with-given-sum-1587115621/0/?page=1&company[]=Amazon&category[]=Arrays&sortBy=submissions*/
    class DesiredSumSubsetArray
    {
        public static int SumArray(int[] array,int n,int s)
        {
            List<int> ourList = new List<int>();
            int firstLocation = -1;
            int secondLocation = -1;
            ourList.Remove(0);
            for(int i=0;i<n-1;i++)
            {
                if (firstLocation == -1 && secondLocation == -1)
                {
                    int sum = 0;
                    for (int j = i; j < n; j++)
                    {
                        sum += array[j];
                        if (sum == s)
                        {
                            firstLocation = i;
                            secondLocation = j;
                            break;
                        }

                    }
                }
                else
                {
                    break;
                }
                
            }

            Console.WriteLine(firstLocation.ToString()+"  "+secondLocation.ToString());
            return -1;
        }
        //GFG
        public List<int> subarraySum(int[] arr, int n, int s)
        {
            List<int> ourList = new List<int>();
            ourList.Add(-1);
            int firstLocation = -1;
            int secondLocation = -1;

            for (int i = 0; i < n - 1; i++)
            {
                if (firstLocation == -1 && secondLocation == -1)
                {
                    int sum = 0;
                    for (int j = i; j < n; j++)
                    {
                        sum += arr[j];
                        if (sum == s)
                        {
                            firstLocation = i;
                            secondLocation = j;
                            ourList.Remove(-1);
                            ourList.Add(firstLocation + 1);
                            ourList.Add(secondLocation + 1);
                            return ourList;
                        }

                    }
                }
                else
                {
                    break;
                }

            }
            return ourList;
            //code here
        }


        //public static void Main()
        //{
        //    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //    SumArray(arr, 10, 15);
        //}
    }
}

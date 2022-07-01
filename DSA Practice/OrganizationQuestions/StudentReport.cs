using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.OrganizationQuestions
{
    class StudentReport
    {
        public static int [] Report(int students,int subjects,int[,] marks)
        {
            //input1 subject
            //input2 
            int[] avg = new int[students];
            int[] result=new int[students];
            int min = -1;
            int bypassIndex = -1;
            for(int i=0;i<subjects;i++)
            {
                for (int j = 0; j <students;j++)
                {
                    avg[i] += marks[j, i];
                }
                avg[i]=avg[i]/students;
                if(i==0)
                {
                    min = avg[i];
                }
                else
                {
                    if (min > avg[i])
                    {
                        min=avg[i];
                        bypassIndex = i;
                    }
                }
            }
            for(int i=0;i<students;i++)
            {
                for(int j=0;j<subjects;j++)
                {
                    if(j!=bypassIndex)
                    {
                        result[i] += marks[i, j];
                    }
                }
            }
            return result;



           
        }

        public static int[] BestMarksAverage(int students,int subjects,int[,] marks)
        {
            int[] avg=new int[subjects];
            int [] result = new int[subjects];
            int count = 0;
            int min = -1;
            int skipIndex = -1;

            for(int row=0;row<subjects;row++)
            {
                for(int col=0;col<students;col++)
                {
                    avg[row] += marks[col, row];
                }
                avg[row]=avg[row]/students;

                if (row == 0)
                {
                    min = avg[0];
                    skipIndex = 0;
                }
                else if (min > avg[row])
                {
                    min = avg[row];
                    skipIndex = row;
                }
            }
            for(int i=0;i<subjects;i++)
            {
                for(int j = 0;j < students;j++)
                {
                    if(i!=skipIndex)
                    {
                        result[i] += marks[j, i];
                        
                    }
                }
                
                
            }
            int[] total = new int[subjects-1];
            for(int i=0;i<subjects;i++)
            {
                if (i != skipIndex)
                {
                    total[count] = result[i];
                    count++;
                }
            }



             return total;
        }
        //public static void Main()
        //{
        //    int[,] marks = { { 2, 1, 10, 8 }, { 3, 2, 1, 9 }, { 2, 1, 0, 8 } };
        //    BestMarksAverage(3, 4, marks);
        //}

    }
}

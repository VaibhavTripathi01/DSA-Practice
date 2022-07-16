using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Hashing
{
    class Chaining
    {
        //We need to create keys for hash table first
        //
        int bucketSize;
        
        

        ArrayList table;
        public Chaining(int size) 
        {
            bucketSize = size;
            table = new ArrayList();
            for(int i = 0; i < size; i++)
            {
                table.Add(new LinkedList<int>());
            }
        }
        public void Insert(int key)
        {
            int index = key % this.bucketSize;
            //this.table.GetEnumerator
        }

        public bool Search(int key)
        {
            return false;
        }
        public void Delete(int key)
        {

        }
        //public static void Main()
        //{
        //    Chaining obj = new Chaining(7);
        //}



    } 
}

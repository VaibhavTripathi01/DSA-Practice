using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.Concepts
{
    class Abstraction
    {
        public abstract class AbstractionClass
        {
            //public void Display()
            //{
            //    Console.Write("Hi");
            //}
            public int a;
            public abstract void Test();
        }

            public interface CHeck
            {
                public void testing();
                public abstract void Test();

               
               
            }

            class Hi : CHeck
            {
                public void testing()
                {
                    Console.Write("Test");
                }
                public void Test()
                {
                    Console.Write("Hi");
                }
            }
            
        class B: AbstractionClass
        {
            public override void Test()
            {
                Console.Write("Test");
            }
            int a = 23;
        }
    }
}

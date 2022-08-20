using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.LinkedList
{
    class OurNode
    {
        public int data;
        public OurNode next;

        public OurNode(int data)
        {
            this.data = data;
            this.next = null;
        }

        public static void PrintNodes(OurNode head)
        {
            if (head != null)
            {
                OurNode curr = head;
                while (curr.next != null)
                {
                    Console.Write(curr.data);
                    curr = curr.next;
                }
                if (curr.next == null)
                {
                    Console.Write(curr.data);
                }
            }
        }

        public static OurNode DeleteHead(OurNode head)
        {
            OurNode temp ;
            temp = head.next;
            return temp;
        }

        public static OurNode DeleteFromlast(OurNode head)
        {
            OurNode curr = head;
            while (curr.next.next != null)
            {
                curr= curr.next;
            }
            curr.next = null;
            return head; ;
        }

        public static OurNode InsertBeginning(OurNode head,int data)
        {
            OurNode temp = new OurNode(data);
            temp.next = head;
            return temp;
        }

        //Check Palindrome in 
        public static OurNode InsertAtSpecificIndex(OurNode head,int location,int data)
        {
            OurNode temp = new OurNode(data);
            if (location==1)
            {
               
                temp.next = head;
                return temp;
            }
            else
            {
               
                OurNode curr = head;

               for(int i=0;i<location-1;i++)
                {
                    curr = curr.next;
                }
                
                temp.next = curr.next;
                curr.next = temp;
                return head;
            }
        }

        public static OurNode Insertlast(OurNode head,int data)
        {
           OurNode temp=new OurNode(data);
           if(head.next==null)
            {
                head.data = data;
               
            }
            else
            {
                OurNode curr = head;
                while(curr.next!=null)
                {
                    curr = curr.next;
                }
                curr.next = temp;
               
            }
            return head;
        }
        //public static void Main()
        //{
        //    OurNode head = null;
        //    head = InsertBeginning(head, 12);
        //    head = InsertBeginning(head, 20);
        //    head = InsertBeginning(head, 30);
        //    head = Insertlast(head, 1000);
        //    head = InsertAtSpecificIndex(head, 2, 300);
        //    PrintNodes(head);
        //    //head=DeleteHead(head);
        //    //Console.Write("Post delete");
        //    //PrintNodes(head);
        //    //head =DeleteFromlast(head);

        //}

    }
   
}

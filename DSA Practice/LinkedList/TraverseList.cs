using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        //Created Node 
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }


    }
    public class PerformOperations
    {
        public static Node InsertAtBeginning(Node head,int data)
        {
            Node tempNode=new Node(data);
            tempNode.next = head;
            return tempNode;
        }
        public static Node InsertAtLast(Node head,int data)
        {
            Node temp = new Node(data);
            if (head==null)
            {
                return temp;
            }
            else
            {
                Node curr = head;
                while(curr.next!=null)
                {
                    curr=curr.next;
                }
                curr.next = temp;
            }
            return head;
        }

        public static Node DeleteFirstNode(Node head)
        {
            return head.next;
        }

        public static Node DeleteLastNode(Node head)
        {
            if(head==null)
            {
                return head;
            }
            else
            {
                Node curr = head;
                while(curr.next.next!=null)
                {
                    curr= curr.next;
                }
                curr.next = null;
            }
            return head;
        }



        //public static void Main()
        //{
        //    Node head = null;
           
        //    head= InsertAtBeginning(head,40);
        //    head = InsertAtBeginning(head, 30);
        //    head = InsertAtLast(head, 1000);
        //    head = InsertAtBeginning(head, 20);
        //    head = InsertAtBeginning(head, 10);
        //    head = DeleteLastNode(head);
        //    Console.Write(head);
        //}

    }

}

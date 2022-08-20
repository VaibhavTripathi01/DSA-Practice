using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Practice.LinkedList
{
    class DoublyNode
    {
        public int data;
        public DoublyNode preNode;
        public DoublyNode nextNode;

        public DoublyNode(int data)
        {
            this.data = data;
            this.preNode = null;
            this.nextNode = null;
        }

        public static DoublyNode InsertAtLast(DoublyNode head, int data)
        {
            DoublyNode temp = new DoublyNode(data);
            if (head != null)
            {
                if (head.nextNode == null)
                {
                    return temp;
                }
                //Check corner case
                else
                {
                    DoublyNode curr = head;
                    while (curr.nextNode != null)
                    {
                        curr = curr.nextNode;
                    }
                    curr.nextNode = temp;
                    temp.preNode = curr;
                    return head;
                }
            }
            return temp;

        }


    }
    class DoublyLinkedList
    {
        //public static void Main()
        //{
        //    DoublyNode head = null;
        //    head = DoublyNode.InsertAtLast(head, 20);
        //    head = DoublyNode.InsertAtLast(head, 30);
        //    head = DoublyNode.InsertAtLast(head, 40);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        public Node head; 
       
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastnode = GetLastNode();
                lastnode.next = new_node;
            }
            Console.WriteLine($"Inserted into List {new_node.data}");
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine($" {temp.data} ");
                    temp = temp.next;
                }
            }

        }
    }
}
   


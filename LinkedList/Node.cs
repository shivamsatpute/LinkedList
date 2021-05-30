using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node //node class
    {
        public int data; // integer value store data
        public Node next; //Public Node head; data type is Node holding the address of the next node
        public Node(int d) // parameter constructor
        {
            data = d;
            next = null;
        }

    }
}

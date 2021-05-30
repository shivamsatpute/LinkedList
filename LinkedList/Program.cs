using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            Console.WriteLine("The list before inserting 30 is : ");
            list.Display();
            list.InsertAtParticularPosition(3, 30);
            Console.WriteLine("The list after inserting 30 is : ");
            list.Display();
            list.RemoveFirstNode();
            Console.WriteLine("The list after removing first node is : ");
            list.Display();
            Console.ReadLine();

        }
    }
}

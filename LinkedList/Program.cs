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
            LinkedList Run = new LinkedList();
            Run.InsertLast(56);
            Run.InsertLast(30);
            Run.InsertLast(70);
            Run.Display();
            Console.ReadLine();
        }
    }
}

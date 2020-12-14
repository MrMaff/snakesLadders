using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            myLinkedList myNums = new myLinkedList();

            myNums.AddFirst(6);
            myNums.AddFirst(5);
            myNums.AddLast(7);
            myNums.AddLast(8);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(myNums.ElementAt(i));
            }

            Console.ReadKey();
        }
    }
}

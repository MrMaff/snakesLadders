using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    class myLinkedList
    {
        public myListNode first;
        public myListNode last;
        public int count;

        public void AddFirst(int _data)
        {
            myListNode newNode = new myListNode();
            newNode.data = _data;

            if (first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                newNode.nextNode = first;
                first = newNode;
            }
        }

        public void AddLast(int _data)
        {
            myListNode newNode = new myListNode();
            newNode.data = _data;

            if (first == null)
            {
                first = newNode;    
            }
            else
            {
                //myListNode tempNode = first;
                //while (tempNode.nextNode != null)
                //{
                //    tempNode = tempNode.nextNode;
                //}
                //tempNode.nextNode = newNode;

                last.nextNode = newNode;    
            }
            last = newNode;
        }

        public int ElementAt(int index)
        {
            myListNode tempNode = first;

            for (int i = 0; i < index; i++)
            {
                tempNode = tempNode.nextNode;
            }
    
            return tempNode.data;
        }

    }

    class myListNode
    {
        public int data;
        public myListNode nextNode;
    }
}

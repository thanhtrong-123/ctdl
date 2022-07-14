using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXE2
{
    class Queue
    {
        private Node front;
        private Node rear;

        public int count
        {
            get
            {
                int count = 0;
                for (Node i = front; i!=null ; i=i.Next)
                {
                    count++;
                }
                return count;
            }
        }
        public Queue()
        {
            front = null;
            rear = null;
        }
        public void Enqueue(Donhang value)
        {
            Node newNode = new Node(value);
            if (newNode==null)
            {
                throw new Exception("Queue is empty");
            }
            if (front==null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }
        public Donhang Dequeue()
        {
            if (front==null)
            {
                throw new Exception("Queue is empty");
            }
            Donhang temp = front.Data;
            front = front.Next;
            if (front==null)
            {
                rear = null;
            }
            return temp;
        }
        public Donhang  Peek()
        {
            if (front==null)
            {
                throw new Exception("Queue is empty");
            }
            Donhang temp = front.Data;
            return temp;
        }
        public void Print()
        {
            for (Node p=front; p!=null; p=p.Next)
            {
                Console.WriteLine(p.Data);
            }
            Console.WriteLine();
        }
    }
}

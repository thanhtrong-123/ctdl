using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyQueue2
{
    class Queue
    {
        private Node front;
        private Node rear;

        public int Count
        {
            get
            {
                int count = 0;
                for (Node i = front; i != null; i = i.Next)
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
        //them  mot phan tu
        public void Enqueue(DonHang value)
        {
            Node newNode = new Node(value);
            if (newNode == null)
            {
                throw new Exception("Day vung nho");
            }
            if (front == null)
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
        //xoa mot phan tu
        public DonHang Dequeue()
        {
            if (front == null)
                throw new Exception("Queue is empty");

            DonHang temp = front.Data;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            return temp;
        }
        public DonHang Peek()
        {
            if (front == null)
                throw new Exception("Queue is empty");
            DonHang temp = front.Data;
            return temp;
        }
        public void Print()
        {
            for (Node p = front; p != null; p = p.Next)
            {
                Console.WriteLine(p.Data.ToString());
            }
            Console.WriteLine();
        }
    }
}
        
        


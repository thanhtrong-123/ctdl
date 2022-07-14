using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Queue
    {
        //field
        private Node front;
        private Node rear;
            
        //attributes
        internal Node Front
        {
            get
            {
                return front;
            }

            set
            {
                front = value;
            }
        }

        internal Node Rear
        {
            get
            {
                return rear;
            }

            set
            {
                rear = value;
            }
        }

        //constructors

        public Queue()
        {
            this.front = null;
            this.rear = null;
        }
        
        public int Count()
        {
            int count = 0;
            Node p = front;
            while (p!=null)
            {
                count += 1;
                p = p.Next;
            }
            return count;
        }

        public void EnQueue(DonHang data)
        {
            Node newNode = new Node(data);
            if (newNode == null)
            {
                throw new Exception("Queue is full");
            }
            else if (front == null)
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

        public DonHang DeQueue()
        {
            if (front == null)
            {
                throw new Exception("Queue is empty");
            }
            Node tempNode = front;
            front = front.Next;
            DonHang tempDonHang = tempNode.Data;
            tempNode = null;
            if (front == null)
            {
                rear = null;
            }
            return tempDonHang;
        }

        public DonHang Peek()
        {
            if (front == null)
            {
                throw new Exception("Queue is empty");
            }
            return front.Data;
        }

        public void Display()
        {
            if (front == null)
            {
                throw new Exception("Queue is empty");
            }
            Node p = front;
            while (p!=null)
            {
                Console.WriteLine(p.Data.ToString());
                p = p.Next;
            }
            Console.WriteLine();
        }

        public void Clear()
        {
            if (front == null)
            {
                throw new Exception("Queue is empty");
            }
            Node p;
            while (front != null)
            {
                p = front;
                front = front.Next;
                p = null;
            }
            front = null;
            rear = null;
        }
    }
}

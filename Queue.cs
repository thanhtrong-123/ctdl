using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyQueue
{
    //tao kdl cho 1 danh sach
    class Queue
    {
        //thanh phan luu tru
        private Node front;
        private Node rear;

        public int Count
        {
            get
            {
                //chay tu front-->rear
                int count = 0;
                for (Node i = front; i != null; i = i.Next)
                {
                    count++;
                }
                return count;
            }

        }

        //cac chuc nang tren kdl
        public Queue()
        {
            front = null;
            rear = null;
        }

        /// <summary>
        /// them mot phan tu vao cuoi hang doi
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(HangHoa value)
        {
            //b1: tao nut co du lieu la value
            Node newNode = new Node(value);
            if (newNode == null)
            {
                throw new Exception("Day vung nho");
            }

            //b2: gan nut moi nay vao cuoi danh sach
            if (front == null) // neu ds dang rong
            {
                front = newNode;
                rear = newNode;
            }
            else // khi ds khac rong
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }
        
        /// <summary>
        /// xoa mot phan tu o dau danh sach
        /// </summary>
        public HangHoa Dequeue()// 
        {
            if (front == null)
                throw new Exception("Queue is empty");

            HangHoa temp = front.Data;

            front = front.Next;
            if (front == null)
            {
                rear = null;
            }

            return temp;

        }

        public HangHoa Peek()
        {
            if (front == null)
                throw new Exception("Queue is empty");

            HangHoa temp = front.Data;
            return temp;
        }

        /// <summary>
        /// duyet danh sach de in gia tri ra man hinh
        /// </summary>
        public void Print()
        {
            for (Node p = front; p != null; p = p.Next)
            {
                //do st
                Console.WriteLine(p.Data.ToString());
            }
            Console.WriteLine();
        }


    }
}

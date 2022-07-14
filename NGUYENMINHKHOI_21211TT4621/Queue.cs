using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NGUYENMINHKHOI_21211TT4621
{
    class Queue
    {
        private Node _front;
        private Node _rear;

        internal Node Front
        {
            get
            {
                return _front;
            }

            set
            {
                _front = value;
            }
        }

        internal Node Rear
        {
            get
            {
                return _rear;
            }

            set
            {
                _rear = value;
            }
        }

        public Queue()
        {
            Front = null;
            Rear = null;
        }

        public void EnQueue(DonHang value)
        {
            Node temp = new Node(value);
            //if (temp == null)
            //{
            //    throw new Exception("SAI");
            //}
            if (Front == null)
            {
                Front = temp;
                Rear = temp;
            }
            else
            {
                Rear.Next = temp;
                Rear = temp;
            }
        }

        public string Peek()
        {
            if (Front == null)
            {
                return "Khong co don hang nao can xu ly";
            }
            DonHang temp = Front.Data;
            return temp.ToString();
        }

        //public void XuLyTatCaDonHang()
        //{
        //    if (Front == null)
        //    {
        //        Console.WriteLine("Khong co don hang nao can xu ly");
        //    }
        //    else
        //    {
        //        while (Front != null)
        //        {
        //            Node temp = Front;
        //            Console.WriteLine($"Xu ly don hang thu {Front.Data.Stt}");
        //            Console.WriteLine(Front.Data.ToString());
        //            Front = Front.Next;
        //            temp = null;
        //        }
        //        Rear = null;
        //    }

        //}

        public void DeQueue()
        {
            Node temp = Front;
            Console.WriteLine($"Xu ly don hang thu {Front.Data.Stt}");
            Console.WriteLine(Front.Data.ToString());
            Front = Front.Next;
            temp = null;
        }

        public void Print()
        {
            if (Front == null)
            {
                Console.WriteLine("Khong co don hang nao");
            }
            else
            {
                Console.WriteLine("Thong tin tat ca don hang: ");
                for (Node i = Front; i != null; i = i.Next)
                {
                    Console.WriteLine(i.Data.ToString());
                }
            }
        }
            
    }
}

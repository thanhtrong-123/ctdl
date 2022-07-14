using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenVuAnh_21211TT1568
{
    /*
     * Nguyen Vu Anh
     * 21211TT1568
     * class: Quere
     */
    class Quere
    {
        // fileds
        private Node front;
        private Node rear;
        private int count;
        /// <summary>
        /// ham tao khong tham so
        /// </summary>
        public Quere()
        {
            front = null;
            rear = null;
            count = 0;
        }
        /// <summary>
        /// ham tao co tham so
        /// </summary>
        /// <param name="donhang"></param>
        public Quere(Donhang donhang)
        {
            Node newnode = new Node(donhang);
            front = newnode;
            rear = newnode;
            count = 1;
        }
        /// <summary>
        /// Them don hang vao trong danh sach Quere
        /// </summary>
        /// <param name="donhang"></param>
        public void EnQuere(Donhang donhang)
        {
            Node newnode = new Node(donhang);
            if (newnode == null)
            {
                throw new Exception("Don hang khong duoc them vao Quere");
            }
            if (front == null)
            {
                front = newnode;
                rear = newnode;
                count++;
            }
            else
            {
                rear.Next = newnode;
                rear = newnode;
                count++;
            }
        }
        /// <summary>
        /// Lay mot don hang ra ==> lay va xoa don hang r khoi danh sach
        /// </summary>
        /// <returns></returns>
        public Donhang DeQuere()
        {
            Donhang donhang;
            if (rear == null)
            {
                throw new Exception("Danh sch rong");
            }
            else
            {
                donhang = front.Data;
                front = front.Next;
                if (front == null)
                {
                    rear = null;
                }
                count--;
            }
            return donhang;
        }
        /// <summary>
        /// Lay don hang tai vi tri front ==> Lay nhung khong xoa
        /// </summary>
        /// <returns></returns>
        public Donhang Peek()
        {
            Donhang donhang;
            if (rear == null)
            {
                throw new Exception("Danh sach rong");
            }
            else
            {
                donhang = front.Data;
            }
            return donhang;
        }
        /// <summary>
        /// Kiem tra xem danh sach co rong khong ==> neu rong thi tra ve true, neu khong rong thi tra ve false
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (front == null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Xoa het danh sach
        /// </summary>
        public void Clear()
        {
            Node temp;
            while(front != null)
            {
                temp = front;
                front = front.Next;
                temp = null;
            }
            rear = null;
            count = 0;

        }
        /// <summary>
        ///  xuat so luong don hang
        /// </summary>
        /// <returns></returns>
        public int getCount()
        {
            return count;
        }
        /// <summary>
        /// Xuat tat ca don hang trong danh sach
        /// </summary>
        public void DisPlay()
        {
            Node q = front;
            if (front == null)
            {
                Console.WriteLine("Danh sach rong, khong co don hang nao");
            }
            else
            {
                while (q != null)
                {
                    Console.WriteLine(q.Data.toString());
                    q = q.Next;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra
{
    class Node
    {
        private DonHang data;
        private Node next;

        public Node(DonHang value)
        {
            data = value;
            next = null;
        }

        internal DonHang Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        internal Node Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }
    }
}

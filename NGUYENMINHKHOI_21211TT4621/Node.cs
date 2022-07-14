using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NGUYENMINHKHOI_21211TT4621
{
    class Node
    {
        private DonHang _data;
        private Node next;


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

        internal DonHang Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

        public Node(DonHang value)
        {
            Data = value;
            Next = null;
        }
    }
}

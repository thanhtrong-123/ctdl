using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Node
    {
        //fiedls
        private DonHang data;
        private Node next;

        // attributes
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

        // method
        public Node(DonHang data)
        {
            this.data = data;
            this.next = null;
        }
    }
}

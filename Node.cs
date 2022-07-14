using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyQueue
{
    //tao kdl cho 1 pt trong dslk
    class Node
    {
        private HangHoa data;
        private Node next;

        public Node(HangHoa value)
        {
            data = value;
            next = null;
        }

        public HangHoa Data
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

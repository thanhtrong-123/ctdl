using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXE2
{
    class Node
    {
        private Donhang data;
        private Node next;

        public Node(Donhang value)
        {
            data = value;
            next = null;
        }

        internal Donhang Data
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

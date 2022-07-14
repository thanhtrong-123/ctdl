using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenVuAnh_21211TT1568
{
    /*
     * Nguyen Vu Anh
     * 21211TT1568
     * class: Node
     */
    class Node
    {
        // fields
        private Donhang data;
        private Node next;
        //propreties
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
        /// <summary>
        /// Ham tao Node
        /// </summary>
        /// <param name="donhang"></param>
        public Node(Donhang donhang)
        {
            data = donhang;
            next = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MP3_Player
{
    public class Node
    {
        private object data;
        private Node next;
        private Node prev;

        public Node(object data, Node next, Node prev)
        {
            this.data = data;
            this.next = next;
            this.prev = prev;
        }

        public object Data
        {
            get { return this.data;}
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
        }


    }
}

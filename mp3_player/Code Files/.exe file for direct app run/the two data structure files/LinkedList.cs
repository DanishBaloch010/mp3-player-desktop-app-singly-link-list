 using System;
using System.Collections.Generic;
using System.Text;

namespace MP3_Player
{
    public class LinkedList
    {
        private Node head;
        private Node tail; //
        private int count;

        // constructor used for intializing the private variables.
        public LinkedList()
        {
            this.head = null;
            this.tail = null; //
            this.count = 0;
        }

        public bool Empty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public object Add(int index, object o)
        {
            if (index < 0)
            {

            }
            if (index > count)
                index = count;

            Node current = this.head;

            if (this.Empty || index == 0)
            {
                this.head = new Node(o, this.head, this.tail); //
            }

            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                current.Next = new Node(o, current.Next, current.Prev = current); //
            }
            count++;
            return o;
        }

        public object Add(object o)
        {
            return this.Add(count, o);
        }

        public object remove(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index :" + index);

            if (this.Empty)
                return null;

            if (index >= this.count)
                index = count - 1;

            Node current = this.head;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.Next;

                result = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;

            return result;
        }

        public void Clear()
        {
            this.head = null;
            this.count = 0;
        }

        public int IndexOf(object o)
        {
            Node current = this.head;

            for (int i = 0; i < this.count; i++)
            {
                if (current.Data.Equals(o))
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }

        public bool Contains(object o)
        {
            return this.IndexOf(o) >= 0;
        }

        public object Get(int index)
        {
            if (index < 0)
                //throw new ArgumentOutOfRangeException("index :" +index);

                if (this.Empty)
                    return null;

            if (index >= this.count)
                index = this.count - 1;

            Node current = this.head;

            for (int i = 0; i < index; i++)
                current = current.Next;

            return current.Data;
        }

        public object this[int index]
        {
            get { return this.Get(index); }
        }

    }
}

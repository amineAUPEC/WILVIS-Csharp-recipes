using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MiklosLinkedList
{
    class ChainedList <T> : IEnumerator, IEnumerable
    {
        private ListItem head;
        private ListItem head_pointer;



        class ListItem
        {
            public T content;
            public ListItem next;
        }

        // -------------------------

        public T this[int i]
        {
            get
            {
                return SearchItem(i);
            }
            set
            {
                ModItem(i, value);
            }
        }

        private T SearchItem(int index)
        {
            ListItem p = head;
            int count = 0;
            while (p != null && count < index)
            {
                p = p.next;
                count++;
            }

            if (p != null && count == index)
            {
                return p.content;
            }
            else
            {
                throw new NoSuchItemException("no item");
            }
        }

        private void ModItem(int index, T newValue)
            {
                ListItem p = head;
                int count = 0;
                while (p != null && count < index)
                {
                    p = p.next;
                    count++;
                }

                if (p != null && count == index)
                {
                    p.content = newValue;
                }
                else
                {
                    throw new NoSuchItemException("no item");
                }
            }



        // -------------------------
        #region methods
        public void Insert2Front(T newContent)
        {
            ListItem newItem = new ListItem();
            newItem.content = newContent;
            newItem.next = head;
            head = newItem;
        }

        public void Traversal()
        {
            ListItem p = head;
            while (p != null)
            {
                Process(p);
                p = p.next;
            }
        }

        private void Process(ListItem p)
        {
            Console.WriteLine(p.content);
        }

        // -------------------------

        public int Count()
        {
            int count = 0;
            ListItem p = head;
            while (p != null)
            {
                p = p.next;
                count++;
            }
            return count;
        }

        public T[] CopyToArray()
        {
            T[] arrayToReturn = new T[Count()];
            int i = 0;

            ListItem p = head;

            while (p != null)
            {
                arrayToReturn[i] = p.content;
                i++;
                p = p.next;
            }

            return arrayToReturn;
        }


        #endregion
        // -------------------------

        public object Current
        {
            get
            {
                return this.head_pointer.content;
            }
        }

        public bool MoveNext()
        {
            if (this.head_pointer == null)
            {
                // first call
                this.head_pointer = head;
                return true;
            }
            else if(this.head_pointer.next != null)
            {
                this.head_pointer = this.head_pointer.next;
                return true;
            }
            else
            {
                this.Reset();
                return false;
            }
        }

        public void Reset()
        {
            this.head_pointer = null;
        }

        public IEnumerator GetEnumerator() 
        {
            return this;
        }


    }

}

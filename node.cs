using System;
using System.Collections.Generic;
using System.Text;

namespace final2._1
{
    class node
    {
        private instructor root = null;
        public void Push(instructor newname)
        {
            if (root == null)
            {
                root = newname;
            }
            else
            {
                instructor name = root;
                while (name.Next != null)
                {
                    name = name.Next;
                }
                name.Next = newname;
            }
        }
        public instructor Pop()
        {
            instructor name = root;
            root = root.Next;
            name.Next = null;
            return name;
        }
        public String Get(int index)
        {
            instructor name = root;
            while (index > 0)
            {
                if (name == null)
                {
                    throw new IndexOutOfRangeException();
                }
                name = name.Next;
                index--;
            }
            return String.Format("{0}", name); 
        }
    }
}

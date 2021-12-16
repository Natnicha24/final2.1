using System;
using System.Collections.Generic;
using System.Text;

namespace final2._1
{
    class Node { protected Node next = null; }
    class instructor : Node
    {
        public instructor Next
        {
            get { return next as instructor; }
            set { next = value; }
        }
        public string Name;
        public instructor(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return String.Format("{0}", Name);
        }
    }
}

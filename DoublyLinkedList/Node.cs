using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class Node
    {
        public string name;
        public Node next;
        public Node previous;

        public Node(string name, Node next, Node previous)
        {
            this.name = name;
            this.next = next;
            this.previous = previous;
        }
    }
}
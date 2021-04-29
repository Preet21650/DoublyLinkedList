using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList
{
    class DoublyLinkedList
    {
        Node head = null;
        Node Tail = null;

        public DoublyLinkedList()
        {

        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.name);
                current = current.next;
            }
        }

        public void ReversePrintList()
        {
            Node current = Tail;
            while (current != null)
            {
                Console.WriteLine(current.name);
                current = current.previous;
            }
        }

        public void Append(string name)
        {
            Node current = head;
            if (current == null)
            {
                head = new Node(name, null, null);
                Tail = head;
            }
            else
            {
                Node newNode = new Node(name, null, null);
                Tail.next = newNode;
                newNode.previous = Tail;
                Tail = newNode;
            }
        }

        public void Prepend(string name)
        {
            if (head == null)
            {
                head = new Node(name, null, null);
                Tail = head;
            }
            else
            {
                Node newNode = new Node(name, null, null);
                Node Current = head;
                Current.previous = newNode;
                newNode.next = Current;
                head = newNode;
                
            }


        }

        public void Delete(string name)
        {

        }
    }
}

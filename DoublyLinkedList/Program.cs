using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList mylist = new DoublyLinkedList();

            mylist.Append("Preet");
            mylist.Append("David");
            mylist.Append("Paul");
            mylist.Prepend("Shaw");
            mylist.PrintList();
        }
    }
}

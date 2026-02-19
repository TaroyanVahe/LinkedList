using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Linked_List
    {
        public Node head;
        public Node tail;
        public int Count;

        public void Insert(int data)
        {

            if (head == null)
            {
                head = new Node(data);
                tail = head;
                Count++;
            }
            else
            {
                tail.Next = new Node(data);
                tail = tail.Next;
                Count++;
            }

        }
        public void Print()
        {
            Node cur = head;
            while (cur != null)
            {
                Console.Write($"{cur.value} ");
                cur = cur.Next;
            }
            Console.WriteLine();

        }
        public bool Find(int data)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.value == data)
                {
                    return true;
                }
                cur = cur.Next;

            }
            return false;


        }
        public void Remove(int data)
        {
            Node cur = head;//5  1 2 3
            Node temp = head;
            while (cur != null)
            {
                if (cur.value == data && head.value == data)
                {
                    head = head.Next;
                    Count--;
                }
                if (cur.value == data)
                {
                    temp.Next = cur.Next;
                    Count--;
                }
                temp = cur;

                cur = cur.Next;

            }
        }
    }
}

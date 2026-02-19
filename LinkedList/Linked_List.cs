using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Linked_List <T>: IDataStructure<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public int Count;

        public void Insert(T data)
        {

            if (head == null)
            {
                head = new Node<T>(data);
                tail = head;
                Count++;
            }
            else
            {
                tail.Next = new Node<T>(data);
                tail = tail.Next;
                Count++;
            }

        }
        public void Print()
        {
            Node<T> cur = head;
            while (cur != null)
            {
                Console.Write($"{cur.value} ");
                cur = cur.Next;
            }
            Console.WriteLine();

        }
        public bool Find(T data)
        {
            Node<T> cur = head;
            while (cur != null)
            {
                if (cur.value.Equals( data))
                {
                    return true;
                }
                cur = cur.Next;

            }
            return false;


        }
        public void Remove(T data)
        {
            Node<T> cur = head;//5  1 2 3
            Node<T> temp = head;
            while (cur != null)
            {
                if (cur.value.Equals(data) && head.value.Equals( data))
                {
                    head = head.Next;
                    Count--;
                }
                if (cur.value.Equals(data))
                {
                    temp.Next = cur.Next;
                    Count--;
                    if(cur.Next==null)
                    {
                        tail = temp;
                    }
                }
                temp = cur;

                cur = cur.Next;

            }
        }
    }
}

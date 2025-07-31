using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameQuest
{
    public class Node
    {
        public int Number;
        public string Text;
        public Node Next;

        public Node(int number, string text)
        {
            Number = number;
            Text = text;
        }
    }

    public class StoryLinkedList
    {
        public Node Head;

        public void Add(int number, string text)
        {
            Node newNode = new Node(number, text);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
                current = current.Next;
            current.Next = newNode;
        }

        public void Sort()
        {
            if (Head == null || Head.Next == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Node current = Head;
                while (current.Next != null)
                {
                    if (current.Number > current.Next.Number)
                    {
                        (current.Number, current.Next.Number) = (current.Next.Number, current.Number);
                        (current.Text, current.Next.Text) = (current.Next.Text, current.Text);
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }

        public List<string> ToList()
        {
            List<string> list = new List<string>();
            Node current = Head;
            while (current != null)
            {
                list.Add($"{current.Number} {current.Text}");
                current = current.Next;
            }
            return list;
        }
    }
}
using System;

namespace Cwiczenie1_strukturyLinkowane
{
    class Program
    {
        class Node<X>
        {
            public X value;
            public Node<X> next;

            public Node(X wartosc, Node<X> nastepny)
            {
                this.value = wartosc;
                this.next = nastepny;
            }

            public override string ToString()
            {
                if (next == null)
                    return $"{value} -> NULL";
                else
                    return $"{value} -> {next}";
            }
        }
        static void Main(string[] args)
        {
            var head = new Node<string>("aaa", null);
            Console.WriteLine(head);

            var p1 = new Node<string>("bbb", null);
            head.next = p1;
            Console.WriteLine(head);
        }
    }
}

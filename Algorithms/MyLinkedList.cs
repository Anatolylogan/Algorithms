namespace Algorithms
{
    public class MyLinkedList<T>
    {
        private class Node
        {
            public T Value;
            public Node Next;

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }
        private Node head;

        public MyLinkedList()
        {
            head = null;
        }й
        public void Add(T value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Remove(T value)
        {
            if (head == null)
            {
                Console.WriteLine("Список пуст, удаление невозможно.");
                return;
            }

            if (head.Value.Equals(value))
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && !current.Next.Value.Equals(value))
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.WriteLine("Элемент не найден.");
            }
            else
            {
                current.Next = current.Next.Next;
            }
        }


        public bool Contains(T value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("Список пуст.");
                return;
            }

            Node current = head;
            while (current != null)
            {
                Console.Write(current.Value + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}

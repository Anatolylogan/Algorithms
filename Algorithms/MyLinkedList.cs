namespace Algorithms
{
    public class MyLinkedList<T>
    {
        private Node head; 
        private Node tail; 

        public MyLinkedList()
        {
            head = null;
            tail = null; 
        }
        public void Add(T value)
        {
            Node newNode = new Node(value); 

            if (head == null) 
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }
        public bool Remove(T value)
        {
            if (head == null) 
                return false;

            if (head.Value.Equals(value))
            {
                head = head.Next; 
                if (head == null) 
                    tail = null; 
                return true;
            }

            Node current = head;
            while (current.Next != null && !current.Next.Value.Equals(value))
            {
                current = current.Next;
            }

            if (current.Next == null) 
                return false;

            current.Next = current.Next.Next; 

            if (current.Next == null) 
                tail = current; 

            return true;
        }
        public bool Contains(T value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
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
    }
}
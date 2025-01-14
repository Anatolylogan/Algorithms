namespace Algorithms.DataStructure
{
    public class MyQueue<T>
    {
        private T[] items;
        private int head;
        private int tail;
        private int count;
        private const int InitialCapacity = 4;
        public MyQueue()
        {
            items = new T[InitialCapacity];
            head = 0;
            tail = 0;
            count = 0;
        }
        public void Enqueue(T value)
        {
            if (count == items.Length)
            {
                Resize(items.Length * 2);
            }
            items[tail] = value;
            tail = (tail + 1) % items.Length;
            count++;
        }
        public T Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T value = items[head];
            items[head] = default;
            head = (head + 1) % items.Length;
            count--;
            return value;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return items[head];
        }
        public int Count => count;
        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = items[(head + i) % items.Length];
            }
            items = newArray;
            head = 0;
            tail = count;
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[(head + i) % items.Length]);
            }
        }
    }
}


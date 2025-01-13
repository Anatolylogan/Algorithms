namespace Algorithms
{
    public class MyStack<T>
    {
        private T[] items; 
        private int count; 
        private const int InitialCapacity = 4;
        public MyStack()
        {
            items = new T[InitialCapacity];
            count = 0;
        }
        public void Push(T value)
        {
            if (count == items.Length)
            {
                Resize(items.Length * 2);
            }
            items[count] = value;
            count++;
        }
        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty"); 
            }
            count--;
            T value = items[count]; 
            items[count] = default; 
            return value; 
        }
        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty"); 
            }
            return items[count - 1];
        }
        public int Count => count;
        private void Resize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < count; i++) 
            {
                newArray[i] = items[i];
            }
            items = newArray; 
        }
        public void Print()
        {
            for (int i = count - 1; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
namespace HackerRank
{
    using System.Collections.Generic;

    public class Queue<T>
    {
        private Stack<T> input = new Stack<T>();
        private Stack<T> output = new Stack<T>();

        public void Enqueue(T item)
        {
            input.Push(item);
        }

        public T Dequeue()
        {
            if (output.Count == 0)
            {
                while (input.Count != 0)
                {
                    output.Push(input.Pop());
                }
            }

            return output.Pop();
        }
    }
}

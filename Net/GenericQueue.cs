using System;
using System.Collections.Generic;

namespace Net
{
    public class GenericQueue<T> : IOperations<T> where T : class
    {
        public List<T> Queue { get; set; }

        public GenericQueue()
        {
            Queue = new List<T>();
        }

        public void Push(T element)
        {
            Queue.Add(element);
        }

        public T Pop()
        {
            return GetElementAndRemove();
        }

        public T StackTop()
        {
            return GetElement();
        }

        private T GetElementAndRemove()
        {
            if (Queue.Count > 0)
            {
                var response = Queue[0];
                Queue.RemoveAt(0);
                return response;
            }
            throw new Exception("Queue is empty");
        }

        private T GetElement()
        {
            if (Queue.Count > 0)
            {
                var response = Queue[0];
                return response;
            }
            throw new Exception("Queue is empty");
        }

        public override string ToString()
        {
            var response = string.Empty;
            foreach (var element in Queue)
            {
                response += element.ToString() + Environment.NewLine;
            }
            return response;
        }
    }
}

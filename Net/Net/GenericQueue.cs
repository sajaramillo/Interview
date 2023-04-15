using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var response = StackTop();
            Queue.RemoveAt(0);
            return response;

            //if (Queue.Count > 0)
            //{
            //    var response = Queue[0];
            //    Queue.RemoveAt(0);
            //    return response;
            //}

        }

        public T StackTop()
        {
            if(Queue.Count == 0) throw new Exception("Queue is empty");

            return Queue[0];


            //if (Queue.Count > 0)
            //{
            //    var response = Queue[0];
            //    return response;
            //}
            //throw new Exception("Queue is empty");
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
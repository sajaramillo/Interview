using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    public class GenericStack<T> : IOperations<T> where T : class
    {
        public List<T> Stack { get; set; }
        public T Pop()
        {
            var item = StackTop();
            Stack.RemoveAt(Stack.Count - 1);
            return item;
        }

        public void Push(T item) => Stack.Add(item);

        public T StackTop()
        {
            if (Stack.Count == 0) throw new Exception("Queue is empty");

            return Stack.ElementAt(Stack.Count - 1);
        }

        public override string ToString() //modificar
        {
            var response = string.Empty;
            foreach (var element in Stack)
            {
                response += element.ToString() + Environment.NewLine;
            }
            return response;

        }
    }
}

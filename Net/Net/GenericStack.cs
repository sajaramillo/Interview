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

        public GenericStack()
        {
            Stack = new List<T>();
        }

        public T Pop()
        {
            var item = StackTop();
            Stack.RemoveAt(Stack.Count - 1);
            return item;
        }

        public void Push(T item)
        {
            Stack.Add(item);
        }

        public T StackTop()
        {
            if (Stack.Count > 0)
            {
                var response = Stack[Stack.Count - 1];
                return response;
            }

            throw new Exception("Stack is empty");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var element in Stack) 
                sb.AppendLine(element.ToString());

            return sb.ToString();
        }
    }
}

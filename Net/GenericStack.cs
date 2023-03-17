using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    public class GenericStack<T> : IOperations<T> where T : class
    {
        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T item)
        {
            throw new NotImplementedException();
        }

        public T StackTop()
        {
            throw new NotImplementedException();
        }
    }
}

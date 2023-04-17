using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net
{
    internal interface IOperations<T> where T : class
    {
        /// <summary>
        /// Add an element inside
        /// </summary>
        /// <param name="item">Item to be added</param>
        public void Push(T item);
        /// <summary>
        /// Get an remove the next element
        /// </summary>
        /// <returns>Returns the next element</returns>
        public T Pop();
        /// <summary>
        /// Get the next element
        /// </summary>
        /// <returns>Returns the next element</returns>
        public T StackTop();
    }
}

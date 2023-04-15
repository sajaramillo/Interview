
using Net;
using Net.Data.Entities;
using System.Linq;

namespace Net
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //inicializamos la cola genérica
            var queue = new GenericQueue<Customer>();
            //creamos 5 clientes
            var customer1 = new Customer { Id = 1, Name = "Juan", LastName = "Perez", Age = 27 };
            var customer2 = new Customer { Id = 2, Name = "María", LastName = "Cevallos", Age = 35 };
            var customer3 = new Customer { Id = 3, Name = "Carlos", LastName = "Andrade", Age = 22 };
            var customer4 = new Customer { Id = 4, Name = "Daniela", LastName = "Guitierrez", Age = 41 };
            var customer5 = new Customer { Id = 5, Name = "Nelson", LastName = "Jara", Age = 18 };

            var stack = new GenericStack<Customer>();

            try
            {
                //añadimos los 5 clientes a la cola 
                queue.Push(customer1);
                queue.Push(customer2);
                queue.Push(customer3);
                queue.Push(customer4);
                queue.Push(customer5);

                // imprimimos la cola 
                Console.WriteLine("Cola: ");
                Console.WriteLine(queue.ToString());

                //imprimimos la cola luego de hacer un pop
                Console.WriteLine($"Cola sin un elemento (Pop): {queue.Pop()}");

                //imprimimos la cola luego d ehacer un stacktop
                Console.WriteLine(queue.ToString());
                Console.WriteLine($"Siguiente elemento a ser atendido (stackTop): {queue.StackTop()}");


                Console.WriteLine(queue.ToString());




                 
                stack.Push(customer1);
                stack.Push(customer2);
                stack.Push(customer3);
                stack.Push(customer4);
                stack.Push(customer5);

                Console.WriteLine("Pila: ");
                Console.WriteLine(stack.ToString());

                Console.WriteLine($"Pila sin un elemento (Pop): {stack.Pop()}");

                Console.WriteLine(stack.ToString());
                Console.WriteLine($"Siguiente elemento a ser atendido (stackTop): {stack.StackTop()}");


                Console.WriteLine(stack.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
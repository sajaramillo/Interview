
using Net;
using System.Linq;

namespace Net
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StackTest();
            PushTest();
        }

        private static void StackTest()
        {
            //inicializamos la pila genérica
            var stack = new GenericStack<Customer>();
            //creamos 5 clientes
            var customer1 = new Customer { Id = 1, Name = "Juan", LastName = "Perez", Age = 27 };
            var customer2 = new Customer { Id = 2, Name = "María", LastName = "Cevallos", Age = 35 };
            var customer3 = new Customer { Id = 3, Name = "Carlos", LastName = "Andrade", Age = 22 };
            var customer4 = new Customer { Id = 4, Name = "Daniela", LastName = "Guitierrez", Age = 41 };
            var customer5 = new Customer { Id = 5, Name = "Nelson", LastName = "Jara", Age = 18 };

            try
            {
                //añadimos los 5 clientes a la pila 
                stack.Push(customer1);
                stack.Push(customer2);
                stack.Push(customer3);
                stack.Push(customer4);
                stack.Push(customer5);

                // imprimimos la pila 
                Console.WriteLine("Pila: ");
                Console.WriteLine(stack.ToString());

                //imprimimos la pila luego de hacer un pop
                Console.WriteLine($"Pila sin un elemento (Pop): {stack.Pop()}");

                //imprimimos la pila luego d ehacer un stacktop
                Console.WriteLine(stack.ToString());
                Console.WriteLine($"Siguiente elemento a ser atendido (stackTop): {stack.StackTop()}");


                Console.WriteLine(stack.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PushTest()
        {
            //inicializamos la cola genérica
            var queue = new GenericQueue<Customer>();
            //creamos 5 clientes
            var customer1 = new Customer { Id = 1, Name = "Juan", LastName = "Perez", Age = 27 };
            var customer2 = new Customer { Id = 2, Name = "María", LastName = "Cevallos", Age = 35 };
            var customer3 = new Customer { Id = 3, Name = "Carlos", LastName = "Andrade", Age = 22 };
            var customer4 = new Customer { Id = 4, Name = "Daniela", LastName = "Guitierrez", Age = 41 };
            var customer5 = new Customer { Id = 5, Name = "Nelson", LastName = "Jara", Age = 18 };

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

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
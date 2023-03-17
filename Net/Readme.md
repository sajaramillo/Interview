# Entrevista técnica - Reto .NET

En esta sección, el postulante deberá resolver una serie de retos para medir su conocimiento básico sobre aplicaciones construidas en Microsoft .NET.

## **Descripción de la aplicación**

La aplicación que se encuentra desarrollada en este repositorio contiene los siguientes archivos que se describen a continuación:
| #  | Archivo  | Descripción  |
| ------------ | ------------ | ------------ |
| 1  | Customer.cs  | Esta clase contiene los siguientes atributos del cliente: Id, apellido (lastname), nombre (name), edad (age)  |
| 2  |  IOperations | Esta interface contiene los métodos base a ser implementados por los archivos GenericQueue (cola genérica) y GenericStack (pila genérica). El método **push** permite insertar elementos en la pila o cola. El método **pop** obtiene el siguiente elemento a ser atendido por la pila o cola y lo elimina. El método **stackTop** permite consultar el siguiente elemento a ser atendido por la pila o cola.  |
| 3 | GenericQueue.cs | Contine la implementación de una cola genérica, debemos recordar que una cola trabaja con la metodología FIFO (first input, first output) esto quiere decir que el primero en entrar a la cola es el primero en ser atendido  |
| 4 | GenericStack.cs  | Este archivo deberá contener la implementación de una pila genérica. recordemos que una pila trabaja con la metodología LIFO (last input, first output) esto quiere decir que el último elemento en ingresar a la pila será el primero ens er atendido  |
| 5 | Program.cs  | Contiene el método principal del aplicativo en el cual se ilustra el manejo de la cola genérica. En esta clase se hace un **push** de 5 clientes a la cola, luego de llos se hace un **pop** es decir se extrae un elemento de la cola y finalmente se hace un **stackTop** es decir se consulta el siguiente elemento a ser atendido en la cola   |

### Antes de comenzar
Clona el repositorio y crea un branch a partir de **main** el cual tenga el siguiente formato: **feature/NombreAppllido** por ejemplo **feature/CarlosNaranjo** una vez que termines tus retos, genera un pull request contra el branch main.

**"Buena Suerte"**

### **Retos a cumplir**

1. 

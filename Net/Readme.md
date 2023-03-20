# Entrevista técnica - Reto .NET

En esta sección, el postulante deberá resolver una serie de retos para medir su conocimiento básico sobre aplicaciones construidas en Microsoft .NET.

## **Descripción de la aplicación**

La aplicación que se encuentra desarrollada en este repositorio contiene los siguientes archivos que se describen a continuación:
| #  | Archivo  | Descripción  |
| ------------ | ------------ | ------------ |
| 1  | Customer.cs  | Esta clase contiene los siguientes atributos del cliente: Id, apellido (lastname), nombre (name), edad (age)  |
| 2  |  IOperations | Esta interface contiene los métodos base a ser implementados por los archivos GenericQueue (cola genérica) y GenericStack (pila genérica). El método **push** permite insertar elementos en la pila o cola. El método **pop** obtiene el siguiente elemento a ser atendido por la pila o cola y lo elimina. El método **stackTop** permite consultar el siguiente elemento a ser atendido por la pila o cola.  |
| 3 | GenericQueue.cs | Contine la implementación de una cola genérica, debemos recordar que una cola trabaja con la metodología FIFO (first input, first output) esto quiere decir que el primero en entrar a la cola es el primero en ser atendido  |
| 4 | GenericStack.cs  | Este archivo deberá contener la implementación de una pila genérica. recordemos que una pila trabaja con la metodología LIFO (last input, first output) esto quiere decir que el último elemento en ingresar a la pila será el primero en ser atendido  |
| 5 | Program.cs  | Contiene el método principal del aplicativo en el cual se ilustra el manejo de la cola genérica. En esta clase se hace un **push** de 5 clientes a la cola, luego de ello se hace un **pop** es decir se extrae un elemento de la cola y finalmente se hace un **stackTop** es decir se consulta el siguiente elemento a ser atendido en la cola   |

### Antes de comenzar
Clona el repositorio y crea un branch a partir de **main** el cual tenga el siguiente formato: **feature/NombreAppllido** por ejemplo **feature/CarlosNaranjo** una vez que termines tus retos, genera un pull request contra el branch main.

**"Buena Suerte"**

### **Retos a cumplir**

#### Nivel básico

1. Comenzaremos con algo fácil de cumplir. En esta primera parte necesitas demostrar tus habilidades para **refactorizar código** esto quiere decir eliminar código repetido y optimizarlo. Para ello eres libre de hacerlo como mejor te parezca solamente debes respetar las siguientes condiciones.
	- Solo podrás modificar el archivo **GenericQueue.cs**
	-  Deberás hacerlo con el mejor criterio técnico posible.
El código a refactorizar es  correspondiente a los métodos **Pop** y **StackTop** que como puedes observar, solo se diferencian en una sola línea de código (**Queue.RemoveAt(0);**) ubicado en la línea #26. Esto quiere decir que la única diferencia entre ambos métodos es que el método **pop** además de consultar el siguiente elemento a ser atendido lo remueve, mientas que el método **StackTop** solo lo consulta. No olvides de probar tu código antes de continuar con el siguiente paso.
2. Implementar los métodos Push, Pop y StackTop para la pila genérica. En este caso solo puede modificar el archivo **GenericStack.cs**. Una vez terminado realiza las pruebas que consideres necesarias.
3. Sobre escribe el método **ToString** para la clase GenerickStack y agrega código de prueba en la clase **Program.cs**

#### Nivel intermedio
4. Crea un nuevo proyecto en la solución del tipo **class library (.net core 7.0)** cuto nombre sea **Net.Data**. Mueve la clase Customer.cs al nuevo proyecto y agrega las referencias necesarias para que toda la solución siga funcionando correctamente.
5. En el nuevo proyecto **Net.Data** usando Entity Framework Core, Crea una base de datos en tu SQL server local cuyo nombre sea **Interview** y cuya única tabla de momento sea Customer.cs. No olvide que la columna ID será su clave primaria y deberá ser una columna de tipo **identity autogenerada**.
6. Implemente el **patrón repository** para la clase Customer. Recuerde que la implementación de dicho patrón debe de contener por lo menos una Interfaz y la clase que lo implemente y como mínimo debería contener las siguientes operaciones: **Get, GetById, Insert, Delete, Update**

#### Nivel intermedio - alto

7. Implemente el patrón Unit of Work para lo cual se deberá hacer una generalización del repositorio de clientes, creando una clase llamada GeneriRepository.cs y clase UnitOfWork.cs.
8. Generar un nuevo proyecto llamado **Net.API** el cual contenga un controlador llamado **CustomerController.cs** en el cual se implementen las llamadas al repositorio genérico: **Get, GetById, Insert, Delete, Update** utilice los verbos http correspondientes.
9. Implemente una política general de manejo de excepciones en la cual cada vez que ocurra un error en el aplicativo, siempre se devuelva un objeto con los siguientes campos:
	-  Mensaje: "Ha ocurrido un error inesperado en el aplicativo"
	- Detalle: El error real que ha ocurrido en el aplicativo
	 El tipo de error que debe devolver siempre será un 404 Bad Request
	 **Nota: ** Utilice filtros de Excepción de ASP.Net

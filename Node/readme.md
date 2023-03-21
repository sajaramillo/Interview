# Entrevista técnica - Reto NodeJS

En esta sección, el postulante deberá resolver una serie de retos para medir su conocimiento en el desarrollo de aplicaciones usando NodeJS

## **Requerimientos para el postulante**
El postulante debe tener instalado en su ordenador las siguientes herramientas:
- Node
- MongoDB
- Un editor de código (Visual Studio Code "Recomendado")

## **Descripción de la aplicación**

La aplicación que se encuentra desarrollada en este repositorio contiene un par de métodos básicos, el primero de ellos ilustra la petición de un método get el cual devuelve un saludo de bienvenida:
http://localhost:3000/api/users/hello (GET)

El segundo método, permite la creación de usuarios que luego serán utilizados para desarrollar nuevas tareas
http://localhost:3000/api/users/signup (POST)

### Antes de comenzar
Clona el repositorio y crea un branch a partir de **main** el cual tenga el siguiente formato: **feature/NombreAppllido** por ejemplo **feature/CarlosNaranjo** una vez que termines tus retos, genera un pull request contra el branch main.

**"Buena Suerte"**

### **Retos a cumplir**

1. Dentro del método **signup** implementar un proceso de hashing para la clave de usuario, de esta manera, no se podrá almacenar la clave del usuario en texto claro.
2. Añadir una validación a los parámetros de entrada del método **signup** (email, password). Las reglas de validación de cada una de las propiedades son las siguientes:
	-  email:
		- Debe ser un email válido
	- password:
		- Debe tener una longitud entre 4 y 20 caracteres.
		- Debe contener al menos una letra mayúscula
		- Debe contener al menos un número

Las validaciones a los parámetros de entrada deben efectuarse antes de procesarse el Request, para ello busque una librería apropiada que le ayude. Si el usuario, comete algún error en el envío de parámetros, devolver una excepción 404 y con el detalle de los errores cometidos. (Ver ejemplo a continuación)

	{
		statusCode: 400
		error:[{
				"message":"El correo electrónico debe ser un email válido",
				"parameter": "email"
			},
			{
				"message": "La clave debe contener al menos una letra mayúscula",
				"parameter":"password"
			}]
		}
	}

3. Dentro del mismo archivo **signup.ts** validar que el usuario que se está creando no exista. Esto quiere decir, que no podrá haber dos usuarios con el mismo correo electrónico. En caso de que el usuario repita el correo electrónico, devolver un error 400 con el siguiente formato:

	{
		statusCode: 400
		error:[{
				"message":"El correo electrónico enviado ya se encuentra en uso",
				"parameter": "email"
			}]
		}
	}

4. Implemente el método **signin** para ello, crear la ruta respectiva **signin.ts**. El objetivo de este método es poder implementar el logeo de un usuario válido. Esto quiere decir de un correo  existente y una clave válida. Si existe algún error ya sea email o clave incorrecta, devolver la excepción correspondiente. Se tomará en cuenta su criterio para mantener la seguridad del aplicativo.
5. Dentro del método **signin**, implementar la generación de un token de seguridad **JWT** siempre y cuando el proceso de login sea exitoso. Adicionalmente a ello, almacenar el token en una cookie de sesión. Luego para probar que su implementación es correcta, asegure la ruta **hello.ts** para que solo puedan acceder a ella usuarios logeados.
6. Implementar el método de singout, para ellos cree la ruta respectiva **sigout.ts** No olvide destruir el token de seguridad.

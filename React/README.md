# Entrevista técnica - Reto React

En esta sección, el postulante deberá resolver una serie de retos para medir su conocimiento básico sobre aplicaciones construidas en react.

## **Descripción de la aplicación**

La aplicación que se encuentra desarrollada en este repositorio tiene como objetivo mostrar un listado de estudiantes en una tabla simple a partir de la cual se irán solicitando nuevos requerimientos a ser agregados.

[![](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto0.png)](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto0.png)

### Antes de comenzar
Clona el repositorio y crea un branch a partir de **main** el cual tenga el siguiente formato: **feature/NombreAppllido** por ejemplo **feature/CarlosNaranjo** una vez que termines tus retos, genera un pull request contra el branch main.

**"Buena Suerte"**

### **Retos a cumplir**

1. Como se puede apreciar en la columna # todas las tuplas contienen el número 1, en esta parte se desea agregar un número secuencial, el cual vaya cambiando automáticamente según el número de registros que muestre la tabla. [![](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto1.png)](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto1.png)
2. En la tabla que muestra la aplicación hay una columna llamada **Estado** la cuál tiene tres posibles valores: "Aprobado, Suspenso y Reprobado". Dicho estado se encuentra quemado en código. Se desea cambiar este comportamiento y generar el estado de manera automática en base al siguiente criterio:
	- Notas mayores o iguales a 7 ---> Aprobado
	- Notas entre 5.5 y menores a 7 --> Suspenso
	- Notas menores a 5.5 --> Reprobado 
	
	[![](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto2.png)](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto2.png)
3. Una vez completado el punto anterior, agregar un estilo en la columna **Estado** el cual permita mostrar el texto con un fondo color verde claro si el estado es Aprobado, en color amarillo claro si el estado es Suspenso y en color en rojo claro si el estado es Reprobado. [![](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto3.png)](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto3.png)
4. Junto a la columna Estado, agregar una nueva columna la cual no tendrá ninguna cabecera, sino que contendrá un botón cuyo texto será **See details** cuyo color de fondo será un azul eléctrico y el color de texto será blanco. [![](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto4.png)](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto4.png)
5. Agregar la siguiente funcionalidad al botón recientemente agregado. Cuando el usuario hace clic sobre este, mostrar un pop-up (Ventana emergente o modal), la cual contenga la siguiente información:
	- Nombre del alumno
	- Score o calificación obtenida
	 un botón que permita cerrar la ventana modal [![](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto5.png)](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto5.png)
6. Generar un mock de un API que permita obtener la data quemada para mostrar los datos en la aplicación. Puede usar herramientas libres en línea como **mockapi.io** para obtener la data de manera externa. [![](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto6.png)](https://github.com/sajaramillo/Interview/blob/main/React/Images/reto6.png)
7. Modifique la aplicación para que lea la data del API antes creado en lugar de la data quemada en el código fuente.


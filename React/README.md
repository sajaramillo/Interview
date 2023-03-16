# Entrevista técnica - Reto React

En esta sección, el postulante deberá resolver una serie de retos para medir su conocimiento básico sobre aplicaciones construidas en react.

## **Descripción de la aplicación**

La aplicación que se encuentra desarrollada en este repositorio tiene como objetivo mostrar un listado de estudiantes en una tabla simple a partir de la cual se iran solicitando nuevos requerimientos a ser agregados.

### **Retos a cumplir**

1. Como se puede apreciar en la columna # todas las tuplas contienen el número 1, en esta parte se desea agregar un número secuenacial, el cual vaya cambiando automáticamente según el número de registros que muestre la tabla.
2. En la tabla que muestra la aplicación hay una columna llamada **Estado** la cuál tiene tres posibles valores: "Aprobado, Suspenso y Reprobado". Dicho estado se encuentra quemado en código. Se desea cambiar este comportamiento y generar el estado de manera automática en base al siguiente criterio:
	- Notas mayores o iguales a 7 ---> Aprobado
	- Notas entre 5.5 y menores a 7 --> Suspenso
	- Notas menores a 5.5 --> Reprobado
3. Una vez completado el punto anterior, agregar un estilo en la columna **Estado** el cual permita mostrar el texto con un fondo color verde claro si el estado es Aprobado, en color amarillo claro si el estado es Suspenso y en color en rojo claro si el estado es Reprobado.
4. Junto a la columna Estado, agregar una nueva columna la cual no tendrá ninguna cabecera, sino que contendrá un botón cuyo texto será **See details** cuyo color de fondo será un azul electrico y el color de texto será blanco.
5. Agregar la siguiente funcionalidad al botón recientemente agregado. Cuando el usuario hace click sobre este, mostrar un pop-up (Ventana emergente o modal), la cual contenga la siguiente información:
	- Nombre del alumno
	- Score o calificación obtenida
	 un botón que permita cerrar la ventana modal
6. Generar un mock de un API que permita obtener la data quemada para mostrar los datos en la aplicación. Puede usar herramientas libres en línea como **mockapi.io** para obtener la data de manera externa.
7. Modifique la aplicación para que lea la data del API antes creado en lugar de la data quemada


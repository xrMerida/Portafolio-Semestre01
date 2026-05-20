# **Laboratorio 14**

## **Objetivos**


  Identificar atributos y métodos clave al diseñar una clase por medio de abstracción.

  Modelar situaciones y entidades simples del mundo real mediante clases y objetos.


**Clases:**


Una clase encapsula las abstracciones de datos y operaciones necesarias para describir una
entidad del mundo real. Funge como una plantilla, definiendo las cualidades (atributos) y
acciones (métodos) que describen a estas entidades u objetos. Visualmente podemos
representarlas de la siguiente manera:




---

**Conceptos clave de Programación Orientada a Objetos:**


Abstracción: Consiste en tener en cuenta solo los aspectos más importantes al definir o crear

una clase. Ocultando los detalles internos o innecesarios.


**Objeto**


Un objeto es una instancia concreta de una clase. Si la clase es el molde, el objeto es el


elemento creado a partir de ese molde.


**Atributos**


Los atributos son los datos o características del objeto. Por ejemplo: nombre, edad, saldo,


precio o cantidad.


**Métodos**


Los métodos son acciones o comportamientos del objeto. Por ejemplo:


MostrarInformacion(), Sumar(), Depositar() o CalcularTotal().


**Consturctor:**


Método especial de una clase que se ejecuta automáticamente al crear un objeto. Su función


principal es inicializar los atributos de la clase. Se caracteriza por tener el mismo nombre


que la clase, no devolver ningún valor (ni siquiera void) y puede recibir cero o más


parámetros según las necesidades de inicialización.


**Métodos Set**


Establece o da un valor a un atributo de la clase.


**Métodos Get**


Recupera o consigue el valor del atributo para que pueda ser utilizado más tarde.




---

Cree un proyecto nuevo de C#. El nombre del proyecto debe seguir la siguiente sintaxis
L14+_+<iniciales>+<carné>. Guárdelo en repositorio creado en el laboratorio anterior y
realice los siguientes ejercicios. No olvide incluir las respuestas del primer inciso en su

solución:


Recuerde utilizar la siguiente estructura en su archivo principal

using System;
class Program {

static void Main() {

// Entrada de usuario

Console.Write("¿Cómo te llamas? ");

string nombre = Console.ReadLine();

// Salida de datos

Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

}

}




---

**Ejercicio #1:**


Se desea implementar un sistema sencillo para gestionar cuentas bancarias.


Crea una clase llamada CuentaBancaria con los siguientes atributos:


  - titular (cadena)

  - numeroCuenta (cadena)

  - saldo (decimal)


La clase debe tener los siguientes métodos:


  - Constructor con todos los datos.

  - mostrarInformacion()

  depositar(monto) que aumente el saldo.

  retirar(monto) que disminuya el saldo si hay fondos suficientes.


En el programa principal:


  - Crea dos cuentas.

  - Muestra su información.

  Realiza depósitos y retiros.

  Muestra el saldo antes y después de cada operación.


**Ejercicio #2:**


Se desea implementar un sistema para gestionar productos en una tienda.


Crea una clase llamada **Producto** con los siguientes atributos:


  - nombre (cadena)


  precio (decimal)

  - cantidad (entero)


La clase debe tener los siguientes métodos:


  - Constructor.


  - mostrarInformacion()




---

  vender(cantidadVendida) que reduzca el stock.


  reabastecer(cantidadNueva) que aumente el stock.


En el programa principal:


  Crea dos productos.

  - Muestra su información.


  Realiza una venta y un reabastecimiento.

  - Muestra cambios en la cantidad.


**Ejercicio #3:**


Se desea implementar un sistema sencillo para gestionar estudiantes en una escuela.


Crea una clase llamada Estudiante con los siguientes atributos:


    - nombre (cadena)

    - edad (entero)

    grado (cadena)

    notas (arreglo de decimales)


La clase debe tener los siguientes métodos:


    Un constructor que reciba todos los datos del estudiante, incluyendo el arreglo

de notas.

    Un método calcularPromedio() que calcule el promedio a partir del arreglo de

notas.

    Un método mostrarInformacion() que muestre todos los datos del estudiante,
incluyendo el promedio calculado.

    Un método aprobar() que indique si el estudiante aprobó (promedio ≥ 61).

    Un método agregarNota(nuevaNota) que permita añadir una nueva nota al
arreglo y recalcular el promedio.


En el programa principal:


    Crea al menos dos objetos de tipo Estudiante con varias notas cada uno (usando
arreglos).

    Calcula el promedio de cada estudiante.

    - Muestra la información de ambos.




---

   Verifica si aprobaron.


   Agrega una nueva nota a uno de los estudiantes, recalcula el promedio y muestra

el resultado actualizado.










|Ejercicio|Criterio|Descripcion|Puntos|Total|
|---|---|---|---|---|
|**Ejercicio 1**|Clase y atributos|Define correctamente titular, numeroCuenta y<br>saldo|6|**30 ptos**|
|**Ejercicio 1**|Constructor|Inicializa todos los atributos|5|5|
|**Ejercicio 1**|Métodos|mostrarInformacion, depositar, retirar<br>correctamente implementados|10|10|
|**Ejercicio 1**|Programa principal|Creación de cuentas y operaciones|6|6|
|**Ejercicio 1**|Funcionamiento|Validación de saldo y operaciones correctas|3|3|
|**Ejercicio 2**|Clase y atributos|Define nombre, precio y cantidad<br>correctamente|6|**30 ptos**|
|**Ejercicio 2**|Constructor|Inicializa atributos|5|5|
|**Ejercicio 2**|Métodos|mostrarInformacion, vender, reabastecer|10|10|
|**Ejercicio 2**|Programa principal|Prueba de venta y reabastecimiento|6|6|
|**Ejercicio 2**|Funcionamiento|Control correcto del stock|3|3|
|**Ejercicio 3**|Clase y atributos|Incluye arreglo de notas|6|**40 ptos**|
|**Ejercicio 3**|Constructor|Inicializa incluyendo arreglo|5|5|
|**Ejercicio 3**|Uso de arreglos|Manejo correcto del arreglo|8|8|
|**Ejercicio 3**|Promedio|Cálculo correcto|6|6|
|**Ejercicio 3**|Métodos|mostrarInformacion, aprobar, agregarNota|8|8|
|**Ejercicio 3**|Programa principal|Flujo completo del programa|5|5|
|**Ejercicio 3**|Funcionamiento|Correcto funcionamiento|2|2|



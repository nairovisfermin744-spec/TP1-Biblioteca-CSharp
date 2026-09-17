# Trabajo Práctico Biblioteca - C#

## Descripción

Este proyecto implementa un sistema básico de gestión de una biblioteca utilizando **C#** y **Programación Orientada a Objetos (POO)**.

El sistema permite administrar libros y lectores, realizar préstamos y controlar el límite de préstamos por lector.

## Clases principales

### Libro

Representa un libro de la biblioteca.

**Atributos:**
- Título
- Autor
- Editorial

### Lector

Representa a una persona que puede solicitar libros en préstamo.

**Atributos:**
- Nombre
- DNI
- Lista de libros prestados

### Biblioteca

Administra los libros disponibles y los lectores registrados.

**Funciones principales:**
- `AgregarLibro()`
- `BuscarLibro()`
- `EliminarLibro()`
- `AltaLector()`
- `BuscarLector()`
- `PrestarLibro()`
- `ListarLibros()`

## Regla de préstamos

Cada lector puede tener como máximo **3 libros en préstamo**.

Para realizar un préstamo deben existir tanto el lector como el libro.

Cuando el préstamo se realiza correctamente, el libro se elimina de la lista de libros disponibles y se agrega a la lista de libros prestados del lector.

## Mensajes del sistema

El método `PrestarLibro()` devuelve los siguientes mensajes según el resultado de la operación:

- `PRESTAMO EXITOSO`
- `LIBRO INEXISTENTE`
- `LECTOR INEXISTENTE`
- `TOPE DE PRESTAMO ALCANZADO`

## Programa principal

El archivo `Program.cs` contiene las pruebas de funcionamiento del sistema.

Se realizan seis pruebas:

1. Préstamo exitoso de un libro.
2. Segundo préstamo exitoso.
3. Tercer préstamo exitoso.
4. Intento de préstamo de un libro inexistente.
5. Intento de préstamo con un lector inexistente.
6. Intento de realizar un cuarto préstamo, verificando el límite máximo de 3 libros.

## Archivos del proyecto

- `Libro.cs` — clase que representa los libros.
- `Lector.cs` — clase que representa a los lectores y sus préstamos.
- `Biblioteca.cs` — clase que administra libros, lectores y préstamos.
- `Program.cs` — programa principal y pruebas.
- `README.md` — documentación del proyecto.

## Lenguaje

**C#**

## Tema

**Programación Orientada a Objetos - UML y desarrollo en C#**

# Trabajo Práctico Biblioteca - C#

## Descripción

Este proyecto implementa un sistema básico de gestión de una biblioteca utilizando el lenguaje C# y programación orientada a objetos.

## Clases principales

### Libro
Representa un libro de la biblioteca.

Atributos:
- Título
- Autor
- Editorial

### Lector
Representa a una persona que puede solicitar libros en préstamo.

Atributos:
- Nombre
- DNI
- Lista de préstamos

### Biblioteca
Administra los libros y lectores registrados.

Funciones principales:
- Agregar libros.
- Agregar lectores.
- Buscar libros.
- Buscar lectores.
- Realizar préstamos.
- Listar libros.
- Listar lectores.

## Regla de préstamos

Cada lector puede tener como máximo **3 libros en préstamo**.

El préstamo solamente se realiza si existe el libro y existe el lector.

## Programa principal

El archivo `Program.cs` contiene un ejemplo de funcionamiento del sistema, creando libros y lectores y realizando un préstamo.

## Archivos del proyecto

- `Libro.cs`
- `Lector.cs`
- `Biblioteca.cs`
- `Program.cs`
- `README.md`

## Lenguaje

**C#**

## Tema

Programación Orientada a Objetos - UML y desarrollo en C#

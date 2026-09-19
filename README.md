Trabajo Práctico 1 - La Biblioteca

Descripción

Este proyecto implementa el sistema de biblioteca solicitado en el TP1 La Biblioteca, utilizando C# y Programación Orientada a Objetos (POO).

La biblioteca administra una colección de libros y una colección de lectores registrados. Cada lector puede tener como máximo 3 préstamos vigentes.

Cuando se realiza un préstamo correctamente, el libro se elimina de la lista de libros disponibles de la biblioteca y se agrega a los préstamos del lector.

Clases principales

Libro

Representa un libro de la biblioteca.

Atributos:

- "titulo : string"
- "autor : string"
- "editorial : string"

Métodos principales:

- "Libro(string titulo, string autor, string editorial)"
- "getTitulo() : string"
- "ToString() : string"

Lector

Representa a un lector registrado en la biblioteca.

Atributos:

- "nombre : string"
- "dni : int"
- "prestamos : List<Libro>"

Métodos principales:

- "Lector(string nombre, int dni)"
- "getDni() : int"
- "agregarPrestamo(Libro libro) : void"
- "cantidadPrestamos() : int"
- "ToString() : string"

Biblioteca

Administra los libros disponibles y los lectores registrados.

Atributos:

- "libros : List<Libro>"
- "lectores : List<Lector>"

Métodos principales:

- "agregarLibro(string titulo, string autor, string editorial) : bool"
- "buscarLibro(string titulo) : Libro"
- "eliminarLibro(string titulo) : bool"
- "listarLibros() : void"
- "altaLector(string nombre, int dni) : bool"
- "buscarLector(int dni) : Lector"
- "prestarLibro(string titulo, int dni) : string"

Regla de préstamos

Cada lector puede tener como máximo 3 libros prestados.

Para realizar un préstamo:

1. Debe existir el lector indicado por su DNI.
2. El lector no debe haber alcanzado el límite de 3 préstamos.
3. Debe existir el libro solicitado.
4. El libro se elimina de los libros disponibles.
5. El libro se agrega a la lista de préstamos del lector.

Mensajes de "prestarLibro"

El método "prestarLibro()" devuelve uno de los siguientes mensajes:

- "PRESTAMO EXITOSO"
- "LIBRO INEXISTENTE"
- "TOPE DE PRESTAMO ALCANZADO"
- "LECTOR INEXISTENTE"

Alta de lectores

El método "altaLector()" recibe el nombre y el DNI del lector.

- Devuelve "true" cuando el lector se registra correctamente.
- Devuelve "false" si ya existe un lector con ese DNI.

Pruebas realizadas

El archivo "Program.cs" contiene pruebas para verificar el funcionamiento del sistema:

1. Primer préstamo exitoso.
2. Segundo préstamo exitoso.
3. Tercer préstamo exitoso.
4. Intento de préstamo de un libro inexistente.
5. Intento de préstamo con un lector inexistente.
6. Intento de realizar un cuarto préstamo, verificando el límite máximo de 3 libros.
7. Intento de registrar nuevamente un lector con el mismo DNI.

Archivos del proyecto

- "Libro.cs" — clase que representa los libros.
- "Lector.cs" — clase que representa a los lectores y sus préstamos.
- "Biblioteca.cs" — clase que administra libros, lectores y préstamos.
- "Program.cs" — programa principal y pruebas.
- "TP1-Biblioteca-CSharp.csproj" — archivo de configuración del proyecto C#.
- "README.md" — documentación del proyecto.

Tecnología

- Lenguaje: C#
- Framework: .NET 10
- Paradigma: Programación Orientada a Objetos (POO)
- Modelado: UML

Estado del proyecto

El código se encuentra organizado según la estructura del TP1 La Biblioteca y preparado para ser probado en Visual Studio o en otro entorno compatible con .NET 10.

## Diagramas

Los diagramas del trabajo fueron realizados en draw.io y se encuentran organizados en dos páginas dentro del mismo archivo:

- **Página 1:** Diagrama UML
- **Página 2:** Diagrama de Casos de Uso

[Ver y editar los diagramas en draw.io](https://app.diagrams.net/?title=Diagrama%20tp1%20%2FPoo&dark=auto#Uhttps%3A%2F%2Fdrive.google.com%2Fuc%3Fid%3D1UtfMjyRTf_2f3UAPDQn6JM4G7drWIXne%26export%3Ddownload)

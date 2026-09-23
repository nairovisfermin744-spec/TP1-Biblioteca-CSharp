# TP1 - La Biblioteca

## Descripción

Este proyecto implementa el TP1 La Biblioteca, utilizando C# y Programación Orientada a Objetos (POO), siguiendo los requerimientos de la consigna.

La Biblioteca administra una colección de libros y una colección de lectores registrados. Cada lector puede tener como máximo 3 préstamos vigentes.

Cuando un préstamo es exitoso, el libro se retira de la colección disponible de la Biblioteca y se agrega a la colección de préstamos del lector.

## Requerimientos implementados

- Colección de lectores registrados.
- Datos del lector: nombre y DNI.
- Máximo de 3 préstamos vigentes por lector.
- altaLector(nombre, dni) para registrar lectores sin duplicar el DNI.
- prestarLibro(titulo, dni) con los cuatro resultados indicados por la consigna:
  - PRESTAMO EXITOSO
  - LIBRO INEXISTENTE
  - TOPE DE PRESTAMO ALCANZADO
  - LECTOR INEXISTENTE
- Al prestar correctamente, el libro pasa de la lista de la Biblioteca a los préstamos del lector.

## Clases

### Libro

Atributos privados:
- titulo : string
- autor : string
- editorial : string

Métodos:
- Libro(string titulo, string autor, string editorial)
- getTitulo() : string
- ToString() : string

### Lector

Atributos privados:
- nombre : string
- dni : string
- prestamos : List<Libro>

Métodos:
- Lector(string nombre, string dni)
- getDni() : string
- agregarPrestamo(Libro libro) : void
- cantidadPrestamos() : int
- ToString() : string

### Biblioteca

Atributos privados:
- libros : List<Libro>
- lectores : List<Lector>

Métodos públicos:
- Biblioteca()
- agregarLibro(string titulo, string autor, string editorial) : bool
- listarLibros() : void
- eliminarLibro(string titulo) : bool
- altaLector(string nombre, string dni) : bool
- prestarLibro(string titulo, string dni) : string

Métodos privados de apoyo:
- buscarLibro(string titulo) : Libro
- buscarLector(string dni) : Lector

## Regla de préstamos

El método prestarLibro() valida:

1. Que el lector esté registrado.
2. Que el libro exista en la Biblioteca.
3. Que el lector tenga menos de 3 préstamos.
4. Retira el libro de la colección de la Biblioteca.
5. Agrega el libro a los préstamos del lector.

## Pruebas en Program.cs

El programa prueba:

1. Alta de Ana.
2. Alta de Juan.
3. Intento de alta duplicada de Ana.
4. Tres préstamos exitosos.
5. Libro inexistente.
6. Lector inexistente.
7. Intento de cuarto préstamo.
8. Intento de agregar un libro duplicado.
9. Eliminación de un libro.

## Diagramas actualizados

- [UML - versión de entrega](Diagrama%20UML%20-%20Entrega.svg)
- [Casos de Uso - versión de entrega](Diagrama%20CASO%20DE%20USO%20-%20Entrega.svg)

También se conservan los dos PNG anteriores del trabajo.

El UML de entrega representa las clases, atributos, métodos, relaciones y multiplicidades. Los métodos buscarLibro() y buscarLector() aparecen como privados porque son lógica interna de Biblioteca.

## Narrativa

La explicación paso a paso de altaLector() y prestarLibro() se encuentra en [NARRATIVA.md](NARRATIVA.md).

## Archivos del proyecto

- Libro.cs
- Lector.cs
- Biblioteca.cs
- Program.cs
- TP1-Biblioteca-CSharp.csproj
- README.md
- NARRATIVA.md
- Diagrama UML - Entrega.svg
- Diagrama CASO DE USO - Entrega.svg
- Diagrama UML.drawio.png
- Diagrama CASO DE USO.drawio.png

## Tecnología

- Lenguaje: C#
- Paradigma: Programación Orientada a Objetos (POO)
- Proyecto: aplicación de consola .NET

## Entrega

La consigna indica entregar todos los archivos correspondientes dentro de un archivo comprimido con el nombre solicitado por la cátedra y presentar un video grupal de máximo 10 minutos, con cámaras activas, explicando el desarrollo y funcionamiento del proyecto. El enlace al video puede ser de YouTube o Drive con permiso de visualización.

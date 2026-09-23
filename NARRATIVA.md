# Narrativa de procesos - TP1 La Biblioteca

## 1. Alta de lector

1. El método recibe nombre y DNI.
2. Biblioteca busca un lector con ese DNI mediante buscarLector().
3. Si ya existe, no se agrega otro lector y el método devuelve false.
4. Si no existe, se crea un nuevo objeto Lector.
5. El nuevo lector se agrega a la lista privada lectores de Biblioteca.
6. El método devuelve true.

## 2. Prestar libro

1. El método recibe el título del libro y el DNI del lector.
2. Biblioteca busca al lector por DNI.
3. Si el lector no está registrado, devuelve LECTOR INEXISTENTE.
4. Biblioteca busca el libro por título dentro de la colección de libros disponibles.
5. Si el libro no existe en la Biblioteca, devuelve LIBRO INEXISTENTE.
6. Se consulta la cantidad de préstamos vigentes del lector.
7. Si el lector ya tiene 3 préstamos, devuelve TOPE DE PRESTAMO ALCANZADO.
8. Si todas las validaciones son correctas, el libro se elimina de la lista de libros de Biblioteca.
9. El mismo objeto Libro se agrega a la lista prestamos del lector.
10. El método devuelve PRESTAMO EXITOSO.

## 3. Relación con la consigna

La implementación cubre los requerimientos centrales: lectores registrados, nombre y DNI, límite de tres préstamos, traslado del libro desde la colección de Biblioteca hacia los préstamos del lector, altaLector() y prestarLibro() con los cuatro resultados solicitados.

## 4. Pruebas realizadas en Program.cs

- Alta de dos lectores.
- Alta duplicada de un DNI.
- Tres préstamos exitosos para un mismo lector.
- Libro inexistente.
- Lector inexistente.
- Intento de cuarto préstamo.
- Alta de un libro duplicado.
- Eliminación de un libro.

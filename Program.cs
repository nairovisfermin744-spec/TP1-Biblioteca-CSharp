using System;

public class Program
{
    public static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        // Cargar libros
        biblioteca.agregarLibro("El Principito", "Antoine de Saint-Exupéry", "Salamandra");
        biblioteca.agregarLibro("Don Quijote", "Miguel de Cervantes", "Francisco de Robles");
        biblioteca.agregarLibro("1984", "George Orwell", "Secker & Warburg");
        biblioteca.agregarLibro("Rayuela", "Julio Cortázar", "Sudamericana");

        // Alta de lectores
        Console.WriteLine("ALTA DE LECTORES");
        Console.WriteLine(
            "Ana: " + biblioteca.altaLector("Ana", "11111111"));

        Console.WriteLine(
            "Juan: " + biblioteca.altaLector("Juan", "22222222"));

        Console.WriteLine(
            "Ana nuevamente: " + biblioteca.altaLector("Ana", "11111111"));

        Console.WriteLine();

        // PRUEBA 1: préstamo exitoso
        Console.WriteLine("PRUEBA 1:");
        Console.WriteLine(
            biblioteca.prestarLibro("El Principito", "11111111"));

        // PRUEBA 2: préstamo exitoso
        Console.WriteLine("PRUEBA 2:");
        Console.WriteLine(
            biblioteca.prestarLibro("Don Quijote", "11111111"));

        // PRUEBA 3: préstamo exitoso
        Console.WriteLine("PRUEBA 3:");
        Console.WriteLine(
            biblioteca.prestarLibro("1984", "11111111"));

        // PRUEBA 4: libro inexistente
        Console.WriteLine("PRUEBA 4:");
        Console.WriteLine(
            biblioteca.prestarLibro("Libro inexistente", "11111111"));

        // PRUEBA 5: lector inexistente
        Console.WriteLine("PRUEBA 5:");
        Console.WriteLine(
            biblioteca.prestarLibro("Rayuela", "99999999"));

        // PRUEBA 6: se intenta superar el límite de 3 préstamos
        Console.WriteLine("PRUEBA 6:");
        Console.WriteLine(
            biblioteca.prestarLibro("Rayuela", "11111111"));
    }
}

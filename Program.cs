using System;

public class Program
{
    public static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        Libro libro1 = new Libro(
            "El Principito",
            "Antoine de Saint-Exupéry",
            "Salamandra"
        );

        Libro libro2 = new Libro(
            "Don Quijote de la Mancha",
            "Miguel de Cervantes",
            "Espasa"
        );

        biblioteca.AgregarLibro(libro1);
        biblioteca.AgregarLibro(libro2);

        Lector lector1 = new Lector(
            "Juan Perez",
            "12345678"
        );

        biblioteca.AgregarLector(lector1);

        Console.WriteLine("=== LIBROS DE LA BIBLIOTECA ===");
        biblioteca.ListarLibros();

        Console.WriteLine();
        Console.WriteLine("=== LECTORES ===");
        biblioteca.ListarLectores();

        Console.WriteLine();
        Console.WriteLine("=== PRÉSTAMO ===");

        bool prestamo = biblioteca.PrestarLibro(
            "El Principito",
            "12345678"
        );

        if (prestamo)
        {
            Console.WriteLine("Préstamo realizado correctamente.");
        }
        else
        {
            Console.WriteLine("No se pudo realizar el préstamo.");
        }

        Console.WriteLine();
        Console.WriteLine("=== LECTOR DESPUÉS DEL PRÉSTAMO ===");
        biblioteca.ListarLectores();
    }
}

using System;

public class Programa
{
    public static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        // Cargar libros
        biblioteca.AgregarLibro(
            "El Principito",
            "Antoine de Saint-Exupéry",
            "Salamandra");

        biblioteca.AgregarLibro(
            "Don Quijote",
            "Miguel de Cervantes",
            "Francisco de Robles");

        biblioteca.AgregarLibro(
            "1984",
            "George Orwell",
            "Secker & Warburg");

        biblioteca.AgregarLibro(
            "Rayuela",
            "Julio Cortázar",
            "Sudamericana");

        // Dar de alta al lector
        biblioteca.AltaLector(
            "Juan Perez",
            "11111111");

        // Pruebas
        Console.WriteLine(
            "PRUEBA 1: " +
            biblioteca.PrestarLibro(
                "El Principito",
                "11111111"));

        Console.WriteLine(
            "PRUEBA 2: " +
            biblioteca.PrestarLibro(
                "Don Quijote",
                "11111111"));

        Console.WriteLine(
            "PRUEBA 3: " +
            biblioteca.PrestarLibro(
                "1984",
                "11111111"));

        Console.WriteLine(
            "PRUEBA 4: " +
            biblioteca.PrestarLibro(
                "Otro libro",
                "11111111"));

        Console.WriteLine(
            "PRUEBA 5: " +
            biblioteca.PrestarLibro(
                "Rayuela",
                "99999999"));

        Console.WriteLine(
            "PRUEBA 6: " +
            biblioteca.PrestarLibro(
                "Rayuela",
                "11111111"));
    }
}

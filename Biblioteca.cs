using System;
using System.Collections.Generic;

public class Biblioteca
{
    private List<Libro> libros;
    private List<Lector> lectores;

    public Biblioteca()
    {
        libros = new List<Libro>();
        lectores = new List<Lector>();
    }

    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
    }

    public void AgregarLector(Lector lector)
    {
        lectores.Add(lector);
    }

    public Libro BuscarLibro(string titulo)
    {
        foreach (Libro libro in libros)
        {
            if (libro.GetTitulo() == titulo)
            {
                return libro;
            }
        }

        return null;
    }

    public Lector BuscarLector(string dni)
    {
        foreach (Lector lector in lectores)
        {
            if (lector.GetDni() == dni)
            {
                return lector;
            }
        }

        return null;
    }

    public bool PrestarLibro(string titulo, string dni)
    {
        Libro libro = BuscarLibro(titulo);
        Lector lector = BuscarLector(dni);

        if (libro == null || lector == null)
        {
            return false;
        }

        if (lector.CantidadPrestamos() >= 3)
        {
            return false;
        }

        lector.AgregarPrestamo(libro);
        return true;
    }

    public void ListarLibros()
    {
        foreach (Libro libro in libros)
        {
            Console.WriteLine(libro);
        }
    }

    public void ListarLectores()
    {
        foreach (Lector lector in lectores)
        {
            Console.WriteLine(lector);
        }
    }
}

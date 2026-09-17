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

    public Libro BuscarLibro(string titulo)
    {
        int i = 0;

        while (i < libros.Count)
        {
            if (libros[i].Titulo == titulo)
            {
                return libros[i];
            }

            i++;
        }

        return null;
    }

    public Lector BuscarLector(string dni)
    {
        int i = 0;

        while (i < lectores.Count)
        {
            if (lectores[i].Dni == dni)
            {
                return lectores[i];
            }

            i++;
        }

        return null;
    }

    public bool AgregarLibro(string titulo, string autor, string editorial)
    {
        Libro libro = BuscarLibro(titulo);

        if (libro == null)
        {
            libro = new Libro(titulo, autor, editorial);
            libros.Add(libro);
            return true;
        }

        return false;
    }

    public void ListarLibros()
    {
        foreach (Libro libro in libros)
        {
            Console.WriteLine(libro);
        }
    }

    public bool EliminarLibro(string titulo)
    {
        Libro libro = BuscarLibro(titulo);

        if (libro != null)
        {
            libros.Remove(libro);
            return true;
        }

        return false;
    }

    public void AltaLector(string nombre, string dni)
    {
        Lector lector = BuscarLector(dni);

        if (lector == null)
        {
            lector = new Lector(nombre, dni);
            lectores.Add(lector);
        }
    }

    public string PrestarLibro(string titulo, string dni)
    {
        Lector lector = BuscarLector(dni);

        if (lector == null)
        {
            return "LECTOR INEXISTENTE";
        }

        Libro libro = BuscarLibro(titulo);

        if (libro == null)
        {
            return "LIBRO INEXISTENTE";
        }

        if (lector.LibrosPrestados.Count >= 3)
        {
            return "TOPE DE PRESTAMO ALCANZADO";
        }

        libros.Remove(libro);
        lector.LibrosPrestados.Add(libro);

        return "PRESTAMO EXITOSO";
    }
}

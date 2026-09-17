using System;
using System.Collections.Generic;

public class Biblioteca
{
    private List<Libro> libros;
    private List<Lector> lectores;

    public Biblioteca()
    {
        this.libros = new List<Libro>();
        this.lectores = new List<Lector>();
    }

    private Libro buscarLibro(string titulo)
    {
        Libro libroBuscado = null;
        int i = 0;

        while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
        {
            i++;
        }

        if (i != libros.Count)
        {
            libroBuscado = libros[i];
        }

        return libroBuscado;
    }

    private Lector buscarLector(int dni)
    {
        Lector lectorBuscado = null;
        int i = 0;

        while (i < lectores.Count && lectores[i].getDni() != dni)
        {
            i++;
        }

        if (i != lectores.Count)
        {
            lectorBuscado = lectores[i];
        }

        return lectorBuscado;
    }

    public bool agregarLibro(string titulo, string autor, string editorial)
    {
        Libro libro = buscarLibro(titulo);

        if (libro == null)
        {
            libro = new Libro(titulo, autor, editorial);
            libros.Add(libro);
            return true;
        }

        return false;
    }

    public void listarLibros()
    {
        foreach (Libro libro in libros)
        {
            Console.WriteLine(libro);
        }
    }

    public bool eliminarLibro(string titulo)
    {
        Libro libro = buscarLibro(titulo);

        if (libro != null)
        {
            libros.Remove(libro);
            return true;
        }

        return false;
    }

    public bool altaLector(string nombre, int dni)
    {
        bool resultado = false;
        Lector lector = buscarLector(dni);

        if (lector == null)
        {
            lector = new Lector(nombre, dni);
            lectores.Add(lector);
            resultado = true;
        }

        return resultado;
    }

    public string prestarLibro(string titulo, int dni)
    {
        Lector lector = buscarLector(dni);

        if (lector == null)
        {
            return "LECTOR INEXISTENTE";
        }

        if (lector.cantidadPrestamos() >= 3)
        {
            return "TOPE DE PRESTAMO ALCANZADO";
        }

        Libro libro = buscarLibro(titulo);

        if (libro == null)
        {
            return "LIBRO INEXISTENTE";
        }

        libros.Remove(libro);
        lector.agregarPrestamo(libro);

        return "PRESTAMO EXITOSO";
    }
}

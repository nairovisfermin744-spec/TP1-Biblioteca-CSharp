using System;
using System.Collections.Generic;

public class Lector
{
    private string nombre;
    private string dni;
    private List<Libro> prestamos;

    public Lector(string nombre, string dni)
    {
        this.nombre = nombre;
        this.dni = dni;
        this.prestamos = new List<Libro>();
    }

    public string getDni()
    {
        return dni;
    }

    public void agregarPrestamo(Libro libro)
    {
        prestamos.Add(libro);
    }

    public int cantidadPrestamos()
    {
        return prestamos.Count;
    }

    public override string ToString()
    {
        return "Nombre: " + nombre + " DNI: " + dni;
    }
}

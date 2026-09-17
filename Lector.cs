using System;
using System.Collections.Generic;

public class Lector
{
    private string nombre;
    private int dni;
    private List<Libro> prestamos;

    public Lector(string nombre, int dni)
    {
        this.nombre = nombre;
        this.dni = dni;
        this.prestamos = new List<Libro>();
    }

    public int getDni()
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

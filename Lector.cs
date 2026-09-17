using System;
using System.Collections.Generic;

public class Lector
{
    private string nombre;
    private string dni;
    private List<Libro> librosPrestados;

    public Lector(string nombre, string dni)
    {
        this.nombre = nombre;
        this.dni = dni;
        librosPrestados = new List<Libro>();
    }

    public string Dni
    {
        get { return dni; }
    }

    public string Nombre
    {
        get { return nombre; }
    }

    public List<Libro> LibrosPrestados
    {
        get { return librosPrestados; }
    }

    public override string ToString()
    {
        return nombre + " - " + dni;
    }
}

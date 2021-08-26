using System;

public class Contacto
{
    // Declaramos los ATRIBUTOS
    private string nombre;
    private int telefono;

    // Declaramos los MÉTODOS
    public Contacto(string n, int t)
    { // Método constructor
        nombre = n;
        telefono = t;
    }

    public void ModificarTelefono(int i)
    {// Método para modificar el teléfono
        telefono = t;
    }

    public void ModificarNombre(string n)
    {// Método para modificar el nombre
        nombre = n;
    }

    public int Telefono()
    { // Método para consultar el teléfono
        return telefono;
    }

    public string Nombre()
    { // Método para consultar el nombre
        return nombre;
    }
}
using System;

public class Agenda
{
    // Declaramos los ATRIBUTOS
    private Contacto[] lista_contactos;
    private int num_contactos;

    // Método constructor
    public void RuntimeArgumentHandle()
    {
        lista_contactos = new Contacto[100];
        num_contactos = 0;
    }

    // Método para añadir un nuevo contacto a la agenda
    // Entrada: nombre y teléfono del contacto
    // Salida: void
    // Notas: se permiten contactos repetidos
    public void AñadirContacto(string nombre, int telefono)
    {
        Contacto c = new Contacto(nombre, telefono);
        lista_contactos[num_contactos] = c;
        num_contactos++;
    }

    // Método para modificar un contacto de la agenda
    // Entrada: nombre del contacto
    // Salida: void
    // Notas: se el contacto no existe, error
    public void ModificarContacto(string nombre)
    {
        // Primero hay que buscar el contacto
        int pos = BuscarContacto(nombre);
        // Muestra los valores actuales del contacto y pide los
        // nuevos
        if (pos == num_contactos) // El contacto no existe
            Console.WriteLine("No existe ningún contacto con ese nombre");
        else {
            Console.WriteLine("Teléfono: " + lista_contactos[pos].Telefono());
            Console.Write("Nuevo Nombre: ");
            string nom = Console.ReadLine();
            Console.Write("NUevo Teléfono: ");
            int tel = Int32.Parse(Console.ReadLine());
            Console.WriteLine(tel);
            lista_contactos[pos].ModificarNombre(nom);
            lista_contactos[pos].ModificarTelefono(tel);
        }
    }

    // Método para consultar el teléfono de una persona
    // Entrada: nombre del contacto
    // Salida: número de teléfono
    // Notas: si no existe, devuelve el número -1
    public int ConsultarTelefono(string nombre)
    {
        // Primero hay que buscar el contacto
        int pos = BuscarContacto(nombre);
        // Con la posición, accedemos al contacto y devolvemos
        // el teléfono
        if (pos == num_contactos) return -1; // El contacto no existe
        else return lista_contactos[pos].Telefono();
    }

    // Método para eliminar un contacto de la agenda
    // Entrada: nombre del contacto
    // Salida: void
    // Notas: si no existe, no hace nada
    public void EliminarContacto(string nombre)
    {   // Método para eliminar un contacto de la agenda
        // Entrada: nombre del contacto
        // Slida: void
        // Notas: si no existe, no hace nada

        // Primero hay que buscar el contacto
        int pos = BuscarContacto(nombre);
        // Eliminamos el elemento en esa posición adelantando
        // los elementos en posiciones posteriores
        for (int i=pos; i<num_contactos-1; i++) {
            lista_contactos[i] = lista_contactos[i+1];
        }

        num_contactos++;
    }

    // Método que busca un contacto en la lista a partir del
    // nombre y devuelve la posición deonde se encuentra
    // Entrada: nombre del contacto
    // Salida: posición de la lista donde se encuentra
    // Notas: si no existe, devuelve la primera posición libre
    // de la lista
    public int BuscarContacto(string nombre)
    {
        int pos = BuscarContacto(nombre);

        for (int i=pos; i<num_contactos-1; i++) {
            if (lista_contactos[i].Nombre() == nombre)
                return i;
        }
        
        return num_contactos;
    }


}
using System;

public class MiAgenda
{
    // Punto de entrada
    static void Main(string[] args)
    {
        int op;
        string nom;
        int tel;
        Agenda A = new Agenda();

        // Muestra el menú hasta que elija la opción de salir
        do {
            Console.WriteLine();
            Console.WriteLine("Elija una opción ");
            Console.WriteLine("1.- Añadir un contacto ");
            Console.WriteLine("2.- Consultar un teléfono ");
            Console.WriteLine("3.- Modificar un contacto ");
            Console.WriteLine("4.- Eliminar un contacto ");
            Console.WriteLine("5.- Salir");

            op = int.Parse(Console.ReadLine());

            switch (op) {
                case 1: Console.Write("Nombre: ");
                        nom = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        tel = int.Parse(Console.ReadLine());
                        A.AñadirContacto(nom, tel);
                        break;
                case 2: Console.Write("Nombre: ");
                        tel = A.ConsultarTelefono(Console.ReadLine());
                        if (tel == -1)
                            Console.WriteLine("No existe ningún contacto" + " con ese nombre");
                        else
                            Console.WriteLine(tel);
                        break;
                case 3: Console.Write("Nombre: ");
                        A.ModificarContacto(Console.ReadLine());
                        break;
                case 4: Console.Write("Nombre: ");
                        A.EliminarContacto(Console.ReadLine());
                        break;
            }
        } while (op != 5);
    }
}
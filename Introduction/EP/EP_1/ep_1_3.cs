using System;

class EP_1_3
{
    static void Main()
    {
        // Variables
        string name;
        string date;
        string topic;

        // Ask name
        Console.Write("Escribe tu nombre: ");
        name = Console.ReadLine();

        // Ask date
        Console.Write("Escribe una fecha: ");
        date = Console.ReadLine();

        // Ask topic
        Console.Write("Escribe un tema: ");
        topic = Console.ReadLine();

        Console.Write("\n\n");
    
        // Print data
        Console.WriteLine("*********************************");
        Console.WriteLine("*** Autor: " + name);
        Console.WriteLine("*** Fecha: " + date);
        Console.WriteLine("*** Tema: " + topic);
        Console.WriteLine("*********************************");
    }
}
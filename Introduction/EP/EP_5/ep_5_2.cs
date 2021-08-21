
using System;

class EP_5_2
{
    static void Main()
	{
        Random random = new Random();

        Console.Write("Tamaño de la lista: ");
        int n = int.Parse(Console.ReadLine());
        int [] tabla1 = new int[n];

        for (int i=0; i < tabla1.Length; i++)
            tabla1[i] = random.Next(10);
        
        Console.Write("\nIngresa un número entre 0 y 9: ");
        int z = int.Parse(Console.ReadLine());
        
        /*
            //Imprimir lista.
            
            for (int i=0; i < tabla1.Length; i++)
                Console.Write(tabla1[i] + (i == tabla1.Length-1 ? " \n\n" : ", "));
        */

        if (Array.Exists(tabla1, item => item == z))
            Console.WriteLine("\n" + Array.IndexOf(tabla1, z));
        else
            Console.WriteLine("\nEl número no se encuentra dentro de la lista.");

    }
  
}

using System;

class Excercise_2_3
{
	static void Main()
	{
        // VARIABLES
		int a, b, c, suma = 0;
		float media = 0;

		Console.WriteLine("\n** EJERCICIO RESUELTO 2.3");
		
        // GET INPUTS
		Console.Write("Escribe el primer valor: ");
		a = Int32.Parse(Console.ReadLine());

		Console.Write("Escribe el segundo valor: ");
		b = Int32.Parse(Console.ReadLine());

		Console.Write("Escribe el tercer valor: ");
		c = Int32.Parse(Console.ReadLine());

        // ADDITION
        suma = a + b + c;

        // CAST
        media = (float) suma / 3;

        // PRINT RESULTS
        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("La media es: " + media);

	}
}

/*
	NOTAS.

	- los enteros en C# son de 32 bits.
    - Int32.Parse(Console.ReadLine()); // Transforma String a Int.
    - CAST: trata el valor como un formato diferente

*/
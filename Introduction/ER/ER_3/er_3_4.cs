
using System;

class Excercise_2_3
{
	static void Main()
	{
        int number;

        Random random = new Random();
        int SECRET_NUM = random.Next(10);

        Console.WriteLine("\n** EJERCICIO RESUELTO 3.4 **\n");
        Console.WriteLine("Adivina mi número secreto.");
        Console.Write("Escribe tu número: ");

        number = int.Parse(Console.ReadLine());

        if (number == SECRET_NUM) {
            Console.WriteLine("¡Enhorabuena!");
        } else {
            Console.WriteLine("Lo siento, ese número no es.");
        }

         Console.WriteLine("Mi número secreto era: " + SECRET_NUM);
        
    }
}

/*
	NOTAS.

    - int.Parse(Console.ReadLine());; // Transforma String a Int.

*/
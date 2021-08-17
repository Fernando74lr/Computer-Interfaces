
using System;

class Excercise_4_6
{
	static void Main()
	{
        int dato;

        Console.WriteLine("\n** EJERCICIO RESUELTO 4.6 **\n");
        Console.Write("Introduzca un número entero mayor que 0: ");

        dato = int.Parse(Console.ReadLine());

        Console.WriteLine("x\t2x\tx^2\tsqrt(x)");
        Console.WriteLine("-\t--\t---\t-------");
        
        for(int i = 1; i <= dato; i++) {
            Console.WriteLine("{0}\t{1}\t{2}\t{3:###.###}", i, 2*i, Math.Pow(i, 2), Math.Sqrt(i));
        }
        
    }
}
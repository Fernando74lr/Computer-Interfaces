using System;

namespace  ER_6_5
{
    class Program
    {
        /*
            Este método determina si n es primo.
            Entrada: 1 número entero mayor que 0.
            Salida: true si es primo, false si no lo es.
        */

        static Boolean Primo(int n)
        {
            for (int m = 2; m < n; m++)
                if (n % m == 0)
                    return false;
            return true;
        }

        static void Main()
        {
            int num;
            
            do {
                // Repite lecturra del número hasta
                // que sea mayor que 0.
                Console.Write("Escriba un número entero mayor que cero: ");
                num = int.Parse(Console.ReadLine());
            } while(num <= 0);

            Console.WriteLine($"Los primos menores que {num} son: ");

            for (int i = 0; i < num; i++)
                if (Primo(i))
                    Console.WriteLine(i);
        }
    }
}
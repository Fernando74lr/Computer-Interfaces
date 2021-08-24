using System;

namespace  ER_6_3
{
    class Program
    {
        /*
            Devuelve el mayor de los tres números dados.
            Entrada: 3 números enteros.
            Salida: el número mayor.
        */

        static int Mayor(int a, int b, int c)
        {
            if (a > b)
                if (a > c)
                    return a;
                else
                    return c;
            else
                if (b > c)
                    return b;
                else
                    return c;
        }

        static void Main()
        {
            int num1, num2, num3;
            Console.Write("Escribe primer número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Escribe segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Escribe tercer número: ");
            num3 = int.Parse(Console.ReadLine());

           Console.WriteLine("El mayor es: " + Mayor(num1, num2, num3));
        }
    }
}
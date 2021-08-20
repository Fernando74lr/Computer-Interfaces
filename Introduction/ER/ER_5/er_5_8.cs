
using System;

class ER_5_8
{
    static void Main()
    {
        // Inicializar matriz con datos y matriz vacía.

        int i, j;

        // Matriz con valores iniciales;
        int[,] matriz = {{1,2,3,4},{6,5,4,3},{0,1,2,3},{9,8,7,6}};

        // Como no tiene valores iniciales se necesita poner el constructor "new";
        int [,] rotar = new int[4,4];

        for (i=0; i < 4; i++)
            for(j=0; j < 4; j++)
                rotar[i,j] = matriz[3-j,i];
        

        Console.WriteLine("La matriz es:");
        for (i=0; i < 4; i++)
        {
            for(j=0; j < 4; j++)
                Console.WriteLine("{0,3}", matriz[i,j]); // ",3" --> spaces
            Console.WriteLine();
        }

        Console.WriteLine("Rotando en sentido horario es: ");
        for (i=0; i < 4; i++)
        {
            for(j=0; j < 4; j++)
                Console.WriteLine("{0,3}", rotar[i,j]);
            Console.WriteLine();
        }
        
    }
}

using System;

class EP_5_12
{
    static void Main()
	{
	    Console.Write("Filas: ");
	    int rows = int.Parse(Console.ReadLine());
	    
	    Console.Write("Columnas: ");
	    int columns = int.Parse(Console.ReadLine());
	    
	    Console.Write("Planos: ");
	    int planes = int.Parse(Console.ReadLine());
	    
        int [,,] cube = new int[rows, columns, planes];
        int [,,] cube_copy = new int[rows, columns, planes];

        Console.WriteLine();
        
        for (int i=0; i < cube.GetLength(0); i++) {
            for (int j=0; j < cube.GetLength(1); j++) {
                for (int k=0; k < cube.GetLength(2); k++) {
                    // Asignar suma de los índices a la posición actual.
                    cube[i,j,k] = i + j + k;

                    // Hacer copia.
                    cube_copy[i,j,k] = cube[i,j,k];

                    // Valor de la posición (de la copia).
                    Console.Write("{0,3}", cube_copy[i,j,k]);

                    // Imprimir posiciones.
                    // Console.Write("[{0},{1},{2}]  ", i, j, k);
                }
                Console.WriteLine();
            }
        }
        
    }
    
}

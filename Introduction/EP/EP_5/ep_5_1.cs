
using System;

class ER_5_1
{
    static void Main()
	{
        int [] tabla1 = new int[2];
        int [,] tabla2 = new int[2,2];
        int [,,] tabla3 = new int[2,2,2];
        int [,,,] tabla4 = new int[2,2,2,2];

        Console.WriteLine("Dimensión de tabla 1: {0}", tabla1.Rank);
        Console.WriteLine("Dimensión de tabla 2: {0}", tabla2.Rank);
        Console.WriteLine("Dimensión de tabla 3: {0}", tabla3.Rank);
        Console.WriteLine("Dimensión de tabla 4: {0}", tabla4.Rank);
    }
  
}

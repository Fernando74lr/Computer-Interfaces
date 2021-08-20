
using System;

class ER_5_6
{
    static void Main()
    {
        int[] multiplos = new int[5]; // 0...4
        for (int i=0; i < multiplos.Length; i++)
        {
            multiplos[i] = (i+1)*10;
        }

        for (int i=0; i < multiplos.Length; i++)
        {
            Console.WriteLine(" {0}x10 = {1}", i+1, multiplos[i]);
        }
    }
}
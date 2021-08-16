using System;

class EP_1_4
{
    static void Main()
    {
        // Variables
        string word_1;
        string word_2;
        string word_3;

        // Ask for word 1
        Console.Write("Palabra 1: ");
        word_1 = Console.ReadLine();

        // Ask for word 2
        Console.Write("Palabra 2: ");
        word_2 = Console.ReadLine();

        // Ask for word 3
        Console.Write("Palabra 3: ");
        word_3 = Console.ReadLine();

        Console.Write("\n\n");
    
        // Print data
        Console.WriteLine(word_3 + ' ' + word_2 + ' ' + word_1);
    }
}
// Workspace
using System;

class Excercise_1_2
{
    /* This program ask for the lastname */
    static void Main()
    {
        string name;
        string lastname;
        
        Console.Write("Write your name: ");
        name = Console.ReadLine();
        
        Console.Write("Write your lastname: ");
        lastname = Console.ReadLine();
        
        Console.WriteLine("Welcome, " + name + " " + lastname);
        
    }
}
/*

    Escriba un programa que, a partir de 3 variables reales que representan las 
    longitudes de los lados de un triángulo, dé respuestas a las siguientes 
    preguntas usando valores lógicos:
    
    - ¿Es un triángulo? (Afirmativo cuando la suma de dos de ellas es mayor que la tercera)
    - ¿Es escaleno? (Afirmativo cuando es triángulo y los tres lados son distintos entre sí)
    - ¿Es equilátero? (Afirmativo cuando es triángulo y los tres lados son iguales)
    - ¿Es isósceles? (Afirmativo cuando es triángulo y dos lados son iguales)

*/

using System;

class EP_2_8
{
	static void Main()
	{
        float lado_1, lado_2, lado_3;

        Console.Write("Introduzca lado 1: ");
        lado_1 = float.Parse(Console.ReadLine());

        Console.Write("Introduzca lado 2: ");
        lado_2 = float.Parse(Console.ReadLine());

        Console.Write("Introduzca lado 3: ");
        lado_3 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nTriángulo\tEscaleno\tEquilátero\tIsósceles");
        Console.WriteLine("---------\t--------\t----------\t---------");
        Console.WriteLine(
            "    {0}\t           {1}\t            {2}\t            {3}",
            esTriangulo(lado_1, lado_2, lado_3) ? "Sí" : "No",
            esEscaleno(lado_1, lado_2, lado_3) ? "Sí" : "No",
            esEquilatero(lado_1, lado_2, lado_3) ? "Sí" : "No",
            esIsosceles(lado_1, lado_2, lado_3) ? "Sí" : "No"
        );
    }

    static Boolean esTriangulo(float l_1, float l_2, float l_3) {
        // Checar si a suma de dos de ellas es mayor que la tercera.
        if ((l_1 + l_2) > l_3) return true;
        return false;
    }

    static Boolean esEscaleno(float l_1, float l_2, float l_3) {
        // Checar si es triángulo
        if (esTriangulo(l_1, l_2, l_3)) {
            // Checar que los 3 lados sean distintos.
            if ((l_1 != l_2) && (l_2 != l_3) && (l_3 != l_1)) return true;
        }
        return false;   
    }

    static Boolean esEquilatero(float l_1, float l_2, float l_3) {
        // Checar si es triángulo
        if (esTriangulo(l_1, l_2, l_3)) {
            // Checar que los 3 lados sean iguales.
            if ((l_1 == l_2) && (l_2 == l_3) && (l_3 == l_1)) return true;
        }
        return false;   
    }

    static Boolean esIsosceles(float l_1, float l_2, float l_3) {
        // Checar si es triángulo
        if (esTriangulo(l_1, l_2, l_3)) {
            // Checar que 2 de sus lados sean iguales.
            if ((l_1 == l_2) || (l_2 == l_3) || (l_3 == l_1)) return true;
        }
        return false;   
    }
}
